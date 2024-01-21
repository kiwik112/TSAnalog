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
			startToolStripMenuItem = new ToolStripMenuItem();
			debugToolStripMenuItem = new ToolStripMenuItem();
			lsBxDevices = new ListBox();
			btnAdd = new Button();
			btnEdit = new Button();
			btnRemove = new Button();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, trainSimToolStripMenuItem, startToolStripMenuItem, debugToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(243, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
			// startToolStripMenuItem
			// 
			startToolStripMenuItem.Enabled = false;
			startToolStripMenuItem.Name = "startToolStripMenuItem";
			startToolStripMenuItem.Size = new Size(43, 20);
			startToolStripMenuItem.Text = "Start";
			startToolStripMenuItem.Click += startToolStripMenuItem_Click;
			// 
			// debugToolStripMenuItem
			// 
			debugToolStripMenuItem.Enabled = false;
			debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			debugToolStripMenuItem.Size = new Size(83, 20);
			debugToolStripMenuItem.Text = "Debug Loco";
			debugToolStripMenuItem.Click += debugToolStripMenuItem1_Click;
			// 
			// lsBxDevices
			// 
			lsBxDevices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lsBxDevices.FormattingEnabled = true;
			lsBxDevices.ItemHeight = 15;
			lsBxDevices.Items.AddRange(new object[] { "Not connected to Train Sim" });
			lsBxDevices.Location = new Point(12, 27);
			lsBxDevices.Name = "lsBxDevices";
			lsBxDevices.Size = new Size(216, 364);
			lsBxDevices.TabIndex = 1;
			lsBxDevices.SelectedIndexChanged += lsBxDevices_SelectedIndexChanged;
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
			btnRemove.Click += btnRemove_Click;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(243, 443);
			Controls.Add(btnRemove);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(lsBxDevices);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			Name = "Main";
			Text = "Main";
			FormClosed += Main_FormClosed;
			Load += Main_Load;
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
        private ListBox lsBxDevices;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private ToolStripMenuItem trainSimToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
		private ToolStripMenuItem debugToolStripMenuItem;
	}
}