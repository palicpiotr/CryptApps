namespace CryptApps
{
    partial class Analytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScreenBoxCT = new System.Windows.Forms.TextBox();
            this.ScreenBoxResult = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.ScreenBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScreenBoxProcess = new System.Windows.Forms.TextBox();
            this.ScreenBoxError = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permutationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenBoxCT
            // 
            this.ScreenBoxCT.Location = new System.Drawing.Point(13, 34);
            this.ScreenBoxCT.Multiline = true;
            this.ScreenBoxCT.Name = "ScreenBoxCT";
            this.ScreenBoxCT.Size = new System.Drawing.Size(665, 134);
            this.ScreenBoxCT.TabIndex = 8;
            // 
            // ScreenBoxResult
            // 
            this.ScreenBoxResult.Location = new System.Drawing.Point(12, 260);
            this.ScreenBoxResult.Multiline = true;
            this.ScreenBoxResult.Name = "ScreenBoxResult";
            this.ScreenBoxResult.Size = new System.Drawing.Size(666, 137);
            this.ScreenBoxResult.TabIndex = 9;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(13, 174);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(159, 23);
            this.EncryptButton.TabIndex = 10;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(187, 174);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(158, 23);
            this.DecryptButton.TabIndex = 11;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // ScreenBoxKey
            // 
            this.ScreenBoxKey.Location = new System.Drawing.Point(437, 177);
            this.ScreenBoxKey.Name = "ScreenBoxKey";
            this.ScreenBoxKey.Size = new System.Drawing.Size(100, 20);
            this.ScreenBoxKey.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Key:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(552, 177);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 213);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(666, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Process Panel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Error Panel:";
            // 
            // ScreenBoxProcess
            // 
            this.ScreenBoxProcess.Location = new System.Drawing.Point(16, 426);
            this.ScreenBoxProcess.Multiline = true;
            this.ScreenBoxProcess.Name = "ScreenBoxProcess";
            this.ScreenBoxProcess.ReadOnly = true;
            this.ScreenBoxProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScreenBoxProcess.Size = new System.Drawing.Size(329, 20);
            this.ScreenBoxProcess.TabIndex = 18;
            // 
            // ScreenBoxError
            // 
            this.ScreenBoxError.Enabled = false;
            this.ScreenBoxError.Location = new System.Drawing.Point(363, 426);
            this.ScreenBoxError.Name = "ScreenBoxError";
            this.ScreenBoxError.ReadOnly = true;
            this.ScreenBoxError.Size = new System.Drawing.Size(315, 20);
            this.ScreenBoxError.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // encryptorsToolStripMenuItem
            // 
            this.encryptorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gammaToolStripMenuItem,
            this.analyticsToolStripMenuItem,
            this.permutationsToolStripMenuItem});
            this.encryptorsToolStripMenuItem.Name = "encryptorsToolStripMenuItem";
            this.encryptorsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.encryptorsToolStripMenuItem.Text = "Encryptors";
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click_1);
            // 
            // analyticsToolStripMenuItem
            // 
            this.analyticsToolStripMenuItem.Name = "analyticsToolStripMenuItem";
            this.analyticsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.analyticsToolStripMenuItem.Text = "Analytics";
            this.analyticsToolStripMenuItem.Click += new System.EventHandler(this.analyticsToolStripMenuItem_Click_1);
            // 
            // permutationsToolStripMenuItem
            // 
            this.permutationsToolStripMenuItem.Name = "permutationsToolStripMenuItem";
            this.permutationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.permutationsToolStripMenuItem.Text = "Permutations";
            this.permutationsToolStripMenuItem.Click += new System.EventHandler(this.permutationsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 458);
            this.Controls.Add(this.ScreenBoxError);
            this.Controls.Add(this.ScreenBoxProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScreenBoxKey);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ScreenBoxResult);
            this.Controls.Add(this.ScreenBoxCT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScreenBoxCT;
        private System.Windows.Forms.TextBox ScreenBoxResult;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox ScreenBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ScreenBoxProcess;
        private System.Windows.Forms.TextBox ScreenBoxError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permutationsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}