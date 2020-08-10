using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool login = client.login(txtusername.Text, txtpassword.Text);
            if(login == true)
            {
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else if(login == false)
            {
                MessageBox.Show("Korisnik ne postoji!");
            }
            else
            {
                MessageBox.Show("Problemi sa konekcijom!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
