namespace TSAnalog
{
    partial class ConnectPrompt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            label1 = new Label();
            tbPath = new TextBox();
            btnBrowse = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(565, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(71, 38);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 1;
            label1.Text = "Path to RailWorks\\Plugins:";
            // 
            // tbPath
            // 
            tbPath.Location = new Point(12, 27);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(470, 23);
            tbPath.TabIndex = 2;
            tbPath.Text = "D:\\Program Files (x86)\\Steam\\steamapps\\common\\RailWorks\\plugins";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(488, 27);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(71, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.InitialDirectory = "D:\\Program Files (x86)\\Steam\\steamapps\\common\\RailWorks\\plugins";
            folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // ConnectPrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 58);
            Controls.Add(btnBrowse);
            Controls.Add(tbPath);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConnectPrompt";
            Text = "TSAnalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Label label1;
        private TextBox tbPath;
        private Button btnBrowse;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}