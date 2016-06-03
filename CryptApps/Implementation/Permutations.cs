using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApps
{
    class Permutations : IPermutations
    {
        public Array getEncryptedText(string text, string key)
        {
            string[] stringWithoutSymbols = text.Split(new[] { '!', '~', '\'', '\"', ' ', '(', ')', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
            char[] charArrayOfText;
            int length = 0;
            foreach (var items in stringWithoutSymbols)
            {
                if (items != null && items != " ")
                {
                    charArrayOfText = items.ToCharArray();
                    length += charArrayOfText.Length;
                    Console.WriteLine(items);
                }
                else
                {
                    Console.WriteLine("The array is null");
                    continue;
                }
            }
            //string[] keyWithoutSymbols = key.Split(new[] { '!', '~', '\'', '\"', ' ', '(', ')', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //char[] charArrayOfKey = (keyWithoutSymbols.ToString()).ToCharArray();
            char[] charArrayOfKey = key.ToCharArray();
            int countCharArrayOfKey = charArrayOfKey.Length; //rows
            char[] keyLenght = new char[countCharArrayOfKey];
            //keyLenght = (charArrayOfKey.ToString()).ToCharArray();
            keyLenght = key.ToCharArray();
            Array.Sort(keyLenght);
            //int rowLength = Convert.ToInt32(Math.Ceiling((double)(length / charArrayOfKey.Length)));
            double rowL = 0;
            if (charArrayOfKey.Length != 0)
            {
                rowL = ((double)length / charArrayOfKey.Length);
            }
            else
            {
                Console.WriteLine("You have error");
            }
            int rowLength = Convert.ToInt32(Math.Ceiling(rowL));

            char[,] encryptResult = new char[/*rows*/countCharArrayOfKey, /*cols*/rowLength];
            int l = 0, k = 0;
            for (int i = 0; i < stringWithoutSymbols.Length; i++)
            {
                char[] arrayOfstringWithoutSymbols = stringWithoutSymbols[i].ToCharArray();
                for (int j = 0; j < arrayOfstringWithoutSymbols.Length; j++)
                {
                    encryptResult[k, l] = arrayOfstringWithoutSymbols[j];
                    if (k != (charArrayOfKey.Length - 1)) // если к будет равен длине ключа, то обнуляем к и переходим к следующему столбцу
                    {
                        k++; //
                    }
                    else
                    {
                        k = 0;
                        l++;
                    }
                }
            }
            getEncryptedText(charArrayOfKey, keyLenght, rowLength, encryptResult);
            return encryptResult;
        }

        private static void getEncryptedText(char[] charArrayOfKey, char[] keyLenght, int rowLength, char[,] encryptResult)
        {
            foreach (var items in keyLenght)
            {
                for (int i = 0; i < charArrayOfKey.Length; i++)
                {
                    if (charArrayOfKey[i] == items)
                    {
                        for (int j = 0; j < rowLength; j++)
                        {                            
                            Console.Write(encryptResult[i, j]);
                        }
                        Console.Write("\n");
                        Console.Write(" ");
                        charArrayOfKey[i] = ' ';
                    }
                }
            }
        }

        public Array getDecryptedText(string encryptedText, string key)
        {
            string[] stringWithoutSymbols = encryptedText.Split(new[] { '!', '~', '\'', '\"', ' ', '(', ')', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //for(int i =0; i < stringWithoutSymbols.Length; i++)
            //{
            //    if(stringWithoutSymbols[i] == "")
            //    {
            //        stringWithoutSymbols[i] = null;
            //    }
            //}
            int length = 0;
            foreach (var items in stringWithoutSymbols)
            {
                if (items != null || items != " ")
                {
                    char[] charArrayOfText = items.ToCharArray();
                    length += charArrayOfText.Length;
                }
            }
            char[] charArrayOfKey = key.ToCharArray();
            int charArrayOfKeyLength = charArrayOfKey.Length;
            char[] charArrayLength = new char[charArrayOfKeyLength];
            charArrayLength = key.ToCharArray();
            Array.Sort(charArrayLength);
            int rowLength = Convert.ToInt32(Math.Ceiling((double)(length / charArrayOfKey.Length)));
            char[,] encryptResult = new char[charArrayLength.Length, rowLength];
            int k = 0, l = 0;
            for (int i = 0; i < stringWithoutSymbols.Length; i++)
            {
                char[] decryptedResult = stringWithoutSymbols[i].ToCharArray();
                for (int j = 0; j < charArrayOfKey.Length; j++)
                {
                    if (charArrayOfKey[j] == charArrayLength[i])
                    {
                        k = j;
                        charArrayOfKey[j] = ' ';
                        break;
                    }
                }
                for (int t = 0; t < rowLength; t++)
                {
                    encryptResult[k, t] = decryptedResult[t];
                }
            }
            getDecriptedText(charArrayOfKey, rowLength, encryptResult);
            return null;
        }

        private static void getDecriptedText(char[] charArrayOfKey, int rowLength, char[,] encryptResult)
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < charArrayOfKey.Length; j++)
                {
                    Console.Write(encryptResult[j, i]);
                }
                Console.Write(" ");
            }
        }
    }
}
