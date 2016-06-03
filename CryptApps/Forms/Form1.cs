using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace CryptApps
{
    public partial class Form1 : Form
    {
        #region Animation Part
        public sealed class AnimateWindowFlags
        {
            public const int AW_HOR_POSITIVE = 0x00000001;
            public const int AW_HOR_NEGATIVE = 0x00000002;
            public const int AW_VER_POSITIVE = 0x00000004;
            public const int AW_VER_NEGATIVE = 0x00000008;
            public const int AW_CENTER = 0x00000010;
            public const int AW_HIDE = 0x00010000;
            public const int AW_ACTIVATE = 0x00020000;
            public const int AW_SLIDE = 0x00040000;
            public const int AW_BLEND = 0x00080000;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow
        (IntPtr hwand, int dwTime, int dwFlags);
        IPermutations permut = new Permutations();
        #endregion

        #region Initialize Part
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Load Part
        private void Form1_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 1000,
            AnimateWindowFlags.AW_BLEND |
            AnimateWindowFlags.AW_VER_POSITIVE);
            ScreenBoxCT.Text = "";
            ScreenBoxKey.Text = "";
            ScreenBoxResult.Text = "";
            ScreenBoxProcess.Text = "";
        }

        #endregion

        #region Encription Part
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // ScreenBoxCT.Text = "";
            ScreenBoxResult.Text = "";
            //progressBar1.Maximum = ScreenBoxCT.Text.Length;
            ScreenBoxProcess.Text += "Spliting the text array \n";
            string[] stringWithoutSymbols = ScreenBoxCT.Text.Split(new[] { '!', '~', '\'', '\"', ' ', '(', ')', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
            char[] charArrayOfText;
            ScreenBoxProcess.Text += "\nFinding the length of text array ";
            int length = 0;
            ScreenBoxProcess.Text += "\nSpliting the text array to char array ";
            foreach (var items in stringWithoutSymbols)
            {
                if (items != null && items != " ")
                {
                    charArrayOfText = items.ToCharArray();
                    length += charArrayOfText.Length;
                    //Console.WriteLine(items);
                    //ScreenBoxResult.Text = items.ToString();
                }
                else
                {
                    Console.WriteLine("The array is null");
                    continue;
                }
            }
            //string[] keyWithoutSymbols = ScreenBoxKey.Text.Split(new[] { '!', '~', '\'', '\"', ' ', '(', ')', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //char[] charArrayOfKey = (keyWithoutSymbols.ToString()).ToCharArray();
            char[] symbols = new char[] { '!', ',', '^', '`', '~', '\'', '#', '@', '<', '>', '(', ')', '{', '}', '[', ']' };
            ScreenBoxProcess.Text = "Creating the char array of key string \n";
            char[] charArrayOfKey = ScreenBoxKey.Text.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < charArrayOfKey.Length; j++)
                {
                    if (charArrayOfKey.Contains(symbols[i]) || char.IsNumber(charArrayOfKey[j]))
                    {
                        MessageBox.Show("Your key has the invalid characters! Please try it again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ScreenBoxError.Text += "There is an error! Your key has the invalid characters";
                        return;
                    }
                }            
            }
            ScreenBoxProcess.Text = "Creating the two-dimension array \n";
            int countCharArrayOfKey = charArrayOfKey.Length; //rows
            char[] keyLenght = new char[countCharArrayOfKey];
            //keyLenght = (charArrayOfKey.ToString()).ToCharArray();
            keyLenght = ScreenBoxKey.Text.ToCharArray();
            Array.Sort(keyLenght);
            //int rowLength = Convert.ToInt32(Math.Ceiling((double)(length / charArrayOfKey.Length)));
            double rowL = 0;
            if (charArrayOfKey.Length != 0)
            {
                rowL = ((double)length / charArrayOfKey.Length);
            }
            else
            {
                ScreenBoxError.Text += "You have an error".ToString();
                MessageBox.Show("Please enter the key! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int rowLength = Convert.ToInt32(Math.Ceiling(rowL));
            ScreenBoxProcess.Text += "Encrypting the char array text \n";
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
            ScreenBoxProcess.Text += "Progressing \n";
            ToProgressBarOne(encryptResult);
            getEncryptedResult(charArrayOfKey, keyLenght, rowLength, encryptResult);
        }
        #endregion

        #region Part For Progress Bar
        private void ToProgressBarOne(char[,] encryptResult)
        {
            int lengthPB = encryptResult.Length;
            progressBar1.Maximum = lengthPB;
            for (int i = 1; i < lengthPB + 1; i++)
            {
                progressBar1.Value = i;
            }
        }
        #endregion

        #region Get Encrypted Result Part
        private void getEncryptedResult(char[] charArrayOfKey, char[] keyLenght, int rowLength, char[,] encryptResult)
        {
            ScreenBoxProcess.Text += "Forming result of encrypted text \n";
            foreach (var items in keyLenght)
            {
                for (int i = 0; i < charArrayOfKey.Length; i++)
                {
                    if (charArrayOfKey[i] == items)
                    {
                        for (int j = 0; j < rowLength; j++)
                        {
                            ScreenBoxResult.Text += encryptResult[i, j].ToString();
                            //Console.Write(encryptResult[i, j]);
                        }
                        //Console.Write("\n");
                        ScreenBoxResult.Text += " ".ToString();
                        charArrayOfKey[i] = ' ';
                    }
                }
            }
            ScreenBoxProcess.Text += "DONE! ";
        }
        #endregion

        #region Clear Part
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll(this.Controls);
        }

        private static void ClearAll(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearAll(ctrl.Controls);
            }
        }

        #endregion

        #region Decription Part
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string[] stringWithoutSymbols = ScreenBoxCT.Text.Split(new[] { '!', '~', '\'', '\"', ' ', '(', ')', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
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
            char[] charArrayOfKey = ScreenBoxKey.Text.ToCharArray();
            int charArrayOfKeyLength = charArrayOfKey.Length;
            char[] charArrayLength = new char[charArrayOfKeyLength];
            charArrayLength = ScreenBoxKey.Text.ToCharArray();
            Array.Sort(charArrayLength);
            int rowLength = Convert.ToInt32(Math.Ceiling((double)(length / charArrayOfKey.Length)));
            //double rowL = 0.0;
            //rowL = ((double)length / charArrayOfKey.Length);
            //int rowLength = Convert.ToInt32(Math.Ceiling(rowL));
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
            GetDecriptedText(charArrayOfKey, rowLength, encryptResult);
        }

        private void GetDecriptedText(char[] charArrayOfKey, int rowLength, char[,] encryptResult)
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < charArrayOfKey.Length; j++)
                {
                    ScreenBoxResult.Text += encryptResult[j, i].ToString();
                }
                ScreenBoxResult.Text += " ".ToString();
            }
        }
        #endregion

        #region Menu Part: open, close, save
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                ScreenBoxCT.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(ScreenBoxResult.Text);
            }
        }
        #endregion

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamma gamma = new Gamma();
            gamma.Show();
            Hide();
        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analytics analytic = new Analytics();
            analytic.Show();
            Hide();
        }

        private void permutationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 permut = new Form1();
            permut.Show();
            Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
