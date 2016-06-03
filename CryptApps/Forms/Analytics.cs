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

namespace CryptApps
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {         
        }

        #region Open File
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                ScreenBoxCT.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        #endregion

        #region Save File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(openFileDialog1.FileName);
                writer.Write(ScreenBoxResult.Text);
            }
        }
        #endregion

        #region Close Application
        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        #endregion

        private void gammaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Gamma gamma = new Gamma();
            gamma.Show();
            Hide();
        }

        private void analyticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            analytics.Show();
            Hide();
        }

        private void permutationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 permut = new Form1();
            permut.Show();
            Hide();
        }
    }
}
