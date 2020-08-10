using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CryptoLibrary;
using System.Collections;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdMain = new OpenFileDialog();
            if (ofdMain.ShowDialog() != DialogResult.Cancel)
            {
                FileStream objFileStream = new FileStream(ofdMain.FileName, FileMode.Open, FileAccess.Read);
                int intLength = Convert.ToInt32(objFileStream.Length);
                byte[] objData;
                objData = new byte[intLength];
                string[] strPath = ofdMain.FileName.Split(Convert.ToChar(@"\"));
                objFileStream.Read(objData, 0, intLength);
                objFileStream.Close();
                if (tabControl1.SelectedTab == tabControl1.TabPages["dt"])
                {
                    if (matX.Text == "" || matY.Text == "" || permX.Text == "" || permY.Text == "")
                    {
                        MessageBox.Show("Popunite sva polja!");
                    }
                    else
                    {
                        DoubleTransposition dt = new DoubleTransposition(Int32.Parse(matX.Text), Int32.Parse(matY.Text), permX.Text, permY.Text);
                        string converted = Encoding.UTF8.GetString(objData, 0, objData.Length);
                        string d = dt.Crypt(converted);
                        byte[] buffer = Encoding.UTF8.GetBytes(d);
                        MD5 m = new MD5();
                        client.savefile(strPath, intLength, buffer, m.Encrypt(converted.Substring(0, Int32.Parse(matX.Text)* Int32.Parse(matY.Text))));
                        string createText = "dt " + matX.Text + " " + matY.Text + " " + permX.Text + " " + permY.Text;
                        File.WriteAllText("C: \\Users\\acer\\source\\repos\\ZI\\ClientApp\\EncryptedFIles\\" + strPath[strPath.Length - 1], createText);
                    }
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["kn"])
                {
                    if (txtpublic.Text == "" || txtprivate.Text == "" || txtm.Text == "" || txtn.Text == "")
                    {
                        MessageBox.Show("Popunite sva polja!");
                    }
                    else
                    {
                        string[] pubKeys = this.txtpublic.Text.Split(',');
                        ArrayList pubKeysAL = new ArrayList();
                        for (int i = 0; i < pubKeys.Length; i++)
                        {
                            pubKeysAL.Add(Convert.ToInt32(pubKeys[i]));
                        }
                        Knapsack ks = new Knapsack();
                        ks.PublicKey = pubKeysAL;

                        byte[] inputBytes = objData;

                        string output = "";
                        foreach (byte b in inputBytes)
                        {
                            string s = FromDeciamlToBinary(b);
                            //				output += System.Text.Encoding.ASCII.GetString(ks.ConvertIntToByteArray(ks.Crypt(s)));
                            output += ks.Crypt(s) + " ";
                        }
                        byte[] buffer = Encoding.UTF8.GetBytes(output);
                        MD5 m = new MD5();
                        client.savefile(strPath, intLength, buffer, m.Encrypt(Encoding.UTF8.GetString(objData, 0, objData.Length)));
                        string createText = "kn " + txtprivate.Text + " " + txtm.Text + " " + txtn.Text + " " + txtpublic.Text;
                        File.WriteAllText("C: \\Users\\acer\\source\\repos\\ZI\\ClientApp\\EncryptedFIles\\" + strPath[strPath.Length - 1], createText);
                    }
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["xtea"])
                {
                    if (txtkey.Text == "")
                    {
                        MessageBox.Show("Popunite sva polja!");
                    }
                    else
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(txtkey.Text);
                        byte[] encrypteddata = XTEA.Encrypt(objData, buffer);
                        MD5 m = new MD5();
                        client.savefile(strPath, intLength, encrypteddata, m.Encrypt(Encoding.UTF8.GetString(objData, 0, objData.Length)));
                        string createText = "xtea " + txtkey.Text;
                        File.WriteAllText("C: \\Users\\acer\\source\\repos\\ZI\\ClientApp\\EncryptedFIles\\" + strPath[strPath.Length - 1], createText);
                    }
                }
                    dataGridView1.DataSource = client.updatedatagridview();
            }
        }

        public static string FromDeciamlToBinary(byte binary)
        {
            if (binary < 0)
            {
                Console.WriteLine("It requires a integer greater than 0.");
                return null;
            }

            string binarystring = "";
            byte factor = 128;

            for (int i = 0; i < 8; i++)
            {
                if (binary >= factor)
                {
                    binary -= factor;
                    binarystring += "1";
                }
                else
                {
                    binarystring += "0";
                }
                factor /= 2;
            }

            return binarystring;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.updatedatagridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            if (!string.IsNullOrEmpty(strId))
            {

                SaveFileDialog objSfd = new SaveFileDialog();
                if (objSfd.ShowDialog() != DialogResult.Cancel)
                {
                    byte[][] objData;
                    objData = client.downloadfile(strId);
                    string strFileToSave = objSfd.FileName+".txt";
                    FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                    objFileStream.Write(objData[0], 0, objData[0].Length);
                    objFileStream.Close();
                }
                dataGridView1.DataSource = client.updatedatagridview();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string strFileName = dataGridView1.SelectedRows[0].Cells["fileName"].Value.ToString();
            if (!string.IsNullOrEmpty(strId))
            {

                SaveFileDialog objSfd = new SaveFileDialog();
                if (objSfd.ShowDialog() != DialogResult.Cancel)
                {
                    byte[][] objData;
                    objData = client.downloadfile(strId);
                    string readText = File.ReadAllText("C: \\Users\\acer\\source\\repos\\ZI\\ClientApp\\EncryptedFIles\\" + strFileName);
                    string[] words = readText.Split(new[] { ' ' });
                    if (words[0] == "dt")
                    { 
                        DoubleTransposition dt = new DoubleTransposition(Int32.Parse(words[1]), Int32.Parse(words[2]), words[3], words[4]);
                        string converted = Encoding.UTF8.GetString(objData[0], 0, objData[0].Length);
                        string d = dt.Decrypt(converted);
                        byte[] buffer = Encoding.UTF8.GetBytes(d);
                        MD5 m = new MD5();
                        string hashcode = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                        string hashcode1 = m.Decrypt(Encoding.UTF8.GetString(objData[1], 0, objData[1].Length));
                        if (hashcode == hashcode1)
                        {
                            MessageBox.Show("MD5 is verfying file!");
                            string strFileToSave = objSfd.FileName+".txt";
                            FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                            objFileStream.Write(buffer, 0, buffer.Length);
                            objFileStream.Close();
                        }
                        else
                        {
                            MessageBox.Show("Doslo je do greske prilikom dekodiranja!" +hashcode1);
                        }
                    }
                    else if (words[0] == "kn")
                    {
                        string[] prKeys = words[1].Split(',');
                        ArrayList prKeysAL = new ArrayList();
                        for (int i = 0; i < prKeys.Length; i++)
                        {
                            prKeysAL.Add(Convert.ToInt32(prKeys[i]));
                        }

                        Knapsack ks = new Knapsack();
                        ks.PrivateKey = prKeysAL;

                        string[] codes = Encoding.UTF8.GetString(objData[0], 0, objData[0].Length).Split(' ');

                        string output = "";
                        foreach (string s in codes)
                        {
                            try
                            {
                                int C = Convert.ToInt32(s);
                                output += System.Convert.ToChar(System.Convert.ToInt32(ks.Decrypt(C), 2));
                            }
                            catch
                            {
                            }


                        }
                        byte[] buffer = Encoding.UTF8.GetBytes(output);
                        MD5 m = new MD5();
                        string hashcode = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                        string hashcode1 = m.Decrypt(Encoding.UTF8.GetString(objData[1], 0, objData[1].Length));
                        if (hashcode == hashcode1)
                        {
                            MessageBox.Show("MD5 is verifying file!");
                            string strFileToSave = objSfd.FileName+".txt";
                            FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                            objFileStream.Write(buffer, 0, buffer.Length);
                            objFileStream.Close();
                        }
                        else
                        {
                            MessageBox.Show("Doslo je do greske prilikom dekodiranja!");
                        }
                    }
                    else if (words[0] == "xtea")
                    {
                        string converted = Encoding.UTF8.GetString(objData[0], 0, objData.Length);
                        byte[] key = Encoding.UTF8.GetBytes(words[1]);
                        byte[] buffer = XTEA.Decrypt(objData[0], key);
                        MD5 m = new MD5();
                        string hashcode = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                        string hashcode1 = m.Decrypt(Encoding.UTF8.GetString(objData[1], 0, objData[1].Length));
                        if (hashcode == hashcode1)
                        {
                            MessageBox.Show("MD5 is verifying file!");
                            string strFileToSave = objSfd.FileName+".txt";
                            FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                            objFileStream.Write(buffer, 0, buffer.Length);
                            objFileStream.Close();
                        }
                        else
                        {
                            MessageBox.Show("Doslo je do greske prilikom dekodiranja!");
                        }
                    }
                }
                dataGridView1.DataSource = client.updatedatagridview();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] prKeys = this.txtprivate.Text.Split(',');

            string pubKey = "";
            int m = System.Convert.ToInt32(this.txtm.Text);
            int n = System.Convert.ToInt32(this.txtn.Text);

            foreach (string k in prKeys)
            {
                int ik = System.Convert.ToInt32(k);

                ik = (ik * m) % n;

                pubKey += ik.ToString() + ",";

            }

            int im = 1;

            while (((im * m) % n != 1) && (m < n))
            {
                im++;
            }

            if ((im * m) % n == 1)
            {
                this.txtprivate.Text += "," + im.ToString() + "," + this.txtn.Text;
            }
            else
            {
                this.txtprivate.Text += ",-1,-1";
            }

            pubKey = pubKey.TrimEnd(',');

            this.txtpublic.Text = pubKey;
        }
    }
}
