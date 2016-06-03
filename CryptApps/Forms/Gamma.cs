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
using CryptApps.Interfaces;

namespace CryptApps
{
    public partial class Gamma : Form
    {
        public Gamma()
        {
            InitializeComponent();
            DecryptButton.Enabled = false;
            ScreenBoxKey.Enabled = false;
        }

        private void permutationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 analytics = new Form1();
            analytics.Show();
            Hide();
        }

        #region Encrypt | Decrypt Part
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            IGammirovanie gam = new Gammirovanie();
            string text = ScreenBoxCT.Text.ToLower();
            byte[] gamma, encryptArray;
            Random rand = new Random();
            int gammaLength = rand.Next(25);
            gamma = new byte[gammaLength];
            rand.NextBytes(gamma);
            byte[] textArray = System.Text.Encoding.Default.GetBytes(text);
            encryptArray = gam.getEncryptedText(textArray, gamma);
            foreach (var items in encryptArray)
            {
                //Console.Write("\t" + items);
            }
            //Console.WriteLine();
            string[] encryptArray2 = gam.getEncryptedText2(textArray, gamma);
            foreach (var items in encryptArray2)
            {
                ScreenBoxResult.Text += " " + items.ToString();
            }

            byte[] decryptArray = gam.getDecryptArray(encryptArray, gamma);
            string result = System.Text.Encoding.Default.GetString(decryptArray);
            foreach (var items in result)
            {
                ScreenBoxResult.Text += "\t" + items.ToString();
            }
            int lengthPB = encryptArray2.Length;
            progressBar1.Maximum = lengthPB;
            for (int i = 0; i < lengthPB + 1; i++)
            {
                progressBar1.Value = i;
            }

        }
        #endregion

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            //DecryptButton.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
            Hide();
        }

        private void ScreenBoxCT_TextChanged(object sender, EventArgs e)
        {
            if (ScreenBoxCT.Text == null || ScreenBoxCT.Text != null)
            {
                DecryptButton.Enabled = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        #region Clear Part
        private void ClearAllButton_Click(object sender, EventArgs e)
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

        #region Close Part Application
        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        #endregion

        #region Open File
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                ScreenBoxCT.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        #endregion Clode File

        #region Analytics Part Button
        private void analiticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamma gamma = new Gamma();
            gamma.Show();
            Hide();
        }
        #endregion

        #region Save File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(openFileDialog1.FileName);
                writer.Write(ScreenBoxResult.Text);
                writer.Close();
            }
        }
        #endregion

        private void Gamma_Load(object sender, EventArgs e)
        {

        }
    }
}
