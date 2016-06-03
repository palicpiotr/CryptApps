using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptApps.Interfaces;

namespace CryptApps
{
    class Gammirovanie : IGammirovanie
    {
        public byte[] getEncryptedText(byte[] text, byte[] gamma)
        {
            byte[] textEncryptArray = new byte[text.Length];
            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                if (j >= gamma.Length)
                    j = 0;
                textEncryptArray[i] = (byte)(text[i] ^ gamma[j]);
                Convert.ToString(BitConverter.DoubleToInt64Bits(textEncryptArray[i]), 2);
            }
            return textEncryptArray;
        }

        public string[] getEncryptedText2(byte[] text, byte[] gamma)
        {
            byte[] textEncryptArray = new byte[text.Length];
            string[] textEncryptArray2 = new string[text.Length];
            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                if (j >= gamma.Length)
                    j = 0;
                textEncryptArray[i] = (byte)(text[i] ^ gamma[j]);
                textEncryptArray2[i] = Convert.ToString((textEncryptArray[i]), 2);
            }
            return textEncryptArray2;
        }

        public byte[] getDecryptArray(byte[] encryptedArray, byte[] gamma)
        {
            byte[] textArray = new byte[encryptedArray.Length];
            for (int i = 0, j = 0; i < encryptedArray.Length; i++, j++)
            {
                if (j >= gamma.Length)
                    j = 0;
                textArray[i] = (byte)(encryptedArray[i] ^ gamma[j]);
            }
            return textArray;
        }
    }
}
