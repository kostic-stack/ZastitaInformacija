using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public class Knapsack
    {
        public Knapsack()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        ArrayList privateKey = new ArrayList();
        ArrayList publicKey = new ArrayList();

        public ArrayList PublicKey
        {
            get
            {
                return this.publicKey;
            }
            set
            {
                this.publicKey = value;
            }
        }

        public ArrayList PrivateKey
        {
            get
            {
                return this.privateKey;
            }
            set
            {
                this.privateKey = value;
            }
        }

        public int Crypt(string binaryByte)
        {
            int C = 0;

            for (int i = 0; i < binaryByte.Length; i++)
            {
                char c = binaryByte[i];
                if (c == '1')
                {
                    C += Convert.ToInt32(publicKey[i]);
                }
            }

            return C;
        }

        public byte[] ConvertIntToByteArray(int toConvert)
        {
            ArrayList al = new ArrayList();

            while (toConvert > 0)
            {
                al.Add(Convert.ToByte(toConvert % 256));
                toConvert /= 256;
            }

            byte[] output = new byte[al.Count];
            al.CopyTo(output);

            return output;
        }

        public string Decrypt(int C)
        {
            int im = Convert.ToInt32(this.privateKey[this.privateKey.Count - 2]);
            int n = Convert.ToInt32(this.privateKey[this.privateKey.Count - 1]);

            int d = (im * C) % n;
            int startIndex = this.privateKey.Count - 3;
            string dcr = "";

            while (startIndex >= 0 && d > 0)
            {
                int val = (int)this.privateKey[startIndex];
                if (val > d)
                {
                    dcr = "0" + dcr;
                }
                else
                {
                    dcr = "1" + dcr;
                    d -= val;
                }

                startIndex--;
            }

            return dcr;
        }
    }
}
