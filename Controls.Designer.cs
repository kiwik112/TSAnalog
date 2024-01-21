namespace TSAnalog
{
    partial class Controls
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
			btnRemove = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			lsBxControls = new ListBox();
			SuspendLayout();
			// 
			// btnRemove
			// 
			btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemove.Enabled = false;
			btnRemove.Location = new Point(160, 412);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(68, 25);
			btnRemove.TabIndex = 9;
			btnRemove.Text = "Remove";
			btnRemove.UseVisualStyleBackColor = true;
			btnRemove.Click += btnRemove_Click;
			// 
			// btnEdit
			// 
			btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnEdit.Enabled = false;
			btnEdit.Location = new Point(86, 412);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(68, 25);
			btnEdit.TabIndex = 8;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnAdd.Location = new Point(12, 412);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(68, 25);
			btnAdd.TabIndex = 7;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// lsBxControls
			// 
			lsBxControls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lsBxControls.FormattingEnabled = true;
			lsBxControls.ItemHeight = 15;
			lsBxControls.Location = new Point(12, 18);
			lsBxControls.Name = "lsBxControls";
			lsBxControls.Size = new Size(216, 379);
			lsBxControls.TabIndex = 6;
			lsBxControls.SelectedIndexChanged += lsBxControls_SelectedIndexChanged;
			// 
			// Controls
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(243, 443);
			Controls.Add(btnRemove);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(lsBxControls);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Controls";
			Text = "Controls";
			Load += Controls_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private ListBox lsBxControls;
    }
}