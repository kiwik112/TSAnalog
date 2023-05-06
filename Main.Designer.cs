namespace TSAnalog
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveConfigToolStripMenuItem = new ToolStripMenuItem();
            loadConfigToolStripMenuItem = new ToolStripMenuItem();
            trainSimToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            lsBxBinds = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, trainSimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(243, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveConfigToolStripMenuItem, loadConfigToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigToolStripMenuItem
            // 
            saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            saveConfigToolStripMenuItem.Size = new Size(149, 22);
            saveConfigToolStripMenuItem.Text = "Save config as";
            // 
            // loadConfigToolStripMenuItem
            // 
            loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            loadConfigToolStripMenuItem.Size = new Size(149, 22);
            loadConfigToolStripMenuItem.Text = "Load config";
            // 
            // trainSimToolStripMenuItem
            // 
            trainSimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem });
            trainSimToolStripMenuItem.Name = "trainSimToolStripMenuItem";
            trainSimToolStripMenuItem.Size = new Size(67, 20);
            trainSimToolStripMenuItem.Text = "Train Sim";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(119, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // lsBxBinds
            // 
            lsBxBinds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsBxBinds.FormattingEnabled = true;
            lsBxBinds.ItemHeight = 15;
            lsBxBinds.Items.AddRange(new object[] { "Not connected to Train Sim" });
            lsBxBinds.Location = new Point(12, 27);
            lsBxBinds.Name = "lsBxBinds";
            lsBxBinds.Size = new Size(216, 364);
            lsBxBinds.TabIndex = 1;
            lsBxBinds.SelectedIndexChanged += lsBxBinds_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(12, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 25);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(86, 406);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(68, 25);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRemove.Enabled = false;
            btnRemove.Location = new Point(160, 406);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(68, 25);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 443);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lsBxBinds);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            FormClosed += Main_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveConfigToolStripMenuItem;
        private ToolStripMenuItem loadConfigToolStripMenuItem;
        private ListBox lsBxBinds;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private ToolStripMenuItem trainSimToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
    }
}