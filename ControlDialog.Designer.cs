namespace TSAnalog
{
    partial class ControlDialog
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
			lsBxControl = new ListBox();
			comboAxis = new ComboBox();
			lblAxis = new Label();
			progAxis = new ProgressBar();
			chkbxInvert = new CheckBox();
			udMin = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			udMax = new NumericUpDown();
			label3 = new Label();
			udTMax = new NumericUpDown();
			label4 = new Label();
			udTMin = new NumericUpDown();
			tbName = new TextBox();
			label5 = new Label();
			btnSave = new Button();
			btnCancel = new Button();
			chkbxInject = new CheckBox();
			((System.ComponentModel.ISupportInitialize)udMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)udMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)udTMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)udTMin).BeginInit();
			SuspendLayout();
			// 
			// lsBxControl
			// 
			lsBxControl.FormattingEnabled = true;
			lsBxControl.ItemHeight = 15;
			lsBxControl.Location = new Point(281, 12);
			lsBxControl.Name = "lsBxControl";
			lsBxControl.Size = new Size(267, 259);
			lsBxControl.TabIndex = 3;
			lsBxControl.SelectedIndexChanged += lsBxControl_SelectedIndexChanged;
			// 
			// comboAxis
			// 
			comboAxis.DropDownStyle = ComboBoxStyle.DropDownList;
			comboAxis.FormattingEnabled = true;
			comboAxis.Location = new Point(57, 41);
			comboAxis.Name = "comboAxis";
			comboAxis.Size = new Size(218, 23);
			comboAxis.TabIndex = 4;
			comboAxis.SelectedIndexChanged += comboAxis_SelectedIndexChanged;
			// 
			// lblAxis
			// 
			lblAxis.AutoSize = true;
			lblAxis.Location = new Point(12, 44);
			lblAxis.Name = "lblAxis";
			lblAxis.Size = new Size(29, 15);
			lblAxis.TabIndex = 5;
			lblAxis.Text = "Axis";
			// 
			// progAxis
			// 
			progAxis.Location = new Point(12, 70);
			progAxis.Name = "progAxis";
			progAxis.Size = new Size(263, 23);
			progAxis.TabIndex = 6;
			// 
			// chkbxInvert
			// 
			chkbxInvert.AutoSize = true;
			chkbxInvert.Location = new Point(12, 99);
			chkbxInvert.Name = "chkbxInvert";
			chkbxInvert.Size = new Size(81, 19);
			chkbxInvert.TabIndex = 7;
			chkbxInvert.Text = "Invert Axis";
			chkbxInvert.UseVisualStyleBackColor = true;
			chkbxInvert.CheckedChanged += chkbxInvert_CheckedChanged;
			// 
			// udMin
			// 
			udMin.Location = new Point(46, 125);
			udMin.Name = "udMin";
			udMin.Size = new Size(87, 23);
			udMin.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 127);
			label1.Name = "label1";
			label1.Size = new Size(28, 15);
			label1.TabIndex = 10;
			label1.Text = "Min";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(154, 129);
			label2.Name = "label2";
			label2.Size = new Size(30, 15);
			label2.TabIndex = 12;
			label2.Text = "Max";
			// 
			// udMax
			// 
			udMax.Location = new Point(190, 127);
			udMax.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
			udMax.Name = "udMax";
			udMax.Size = new Size(85, 23);
			udMax.TabIndex = 11;
			udMax.Value = new decimal(new int[] { 65535, 0, 0, 0 });
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(427, 279);
			label3.Name = "label3";
			label3.Size = new Size(30, 15);
			label3.TabIndex = 16;
			label3.Text = "Max";
			// 
			// udTMax
			// 
			udTMax.DecimalPlaces = 5;
			udTMax.Location = new Point(463, 275);
			udTMax.Maximum = new decimal(new int[] { 25535, 0, 0, 0 });
			udTMax.Name = "udTMax";
			udTMax.Size = new Size(85, 23);
			udTMax.TabIndex = 15;
			udTMax.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(285, 277);
			label4.Name = "label4";
			label4.Size = new Size(28, 15);
			label4.TabIndex = 14;
			label4.Text = "Min";
			// 
			// udTMin
			// 
			udTMin.DecimalPlaces = 5;
			udTMin.Location = new Point(319, 275);
			udTMin.Name = "udTMin";
			udTMin.Size = new Size(87, 23);
			udTMin.TabIndex = 13;
			// 
			// tbName
			// 
			tbName.Location = new Point(57, 12);
			tbName.Name = "tbName";
			tbName.Size = new Size(218, 23);
			tbName.TabIndex = 17;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 15);
			label5.Name = "label5";
			label5.Size = new Size(39, 15);
			label5.TabIndex = 18;
			label5.Text = "Name";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(473, 371);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 19;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(392, 371);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 20;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// chkbxInject
			// 
			chkbxInject.AutoSize = true;
			chkbxInject.Enabled = false;
			chkbxInject.Location = new Point(12, 154);
			chkbxInject.Name = "chkbxInject";
			chkbxInject.Size = new Size(55, 19);
			chkbxInject.TabIndex = 21;
			chkbxInject.Text = "Inject";
			chkbxInject.UseVisualStyleBackColor = true;
			chkbxInject.CheckedChanged += chkbxInject_CheckedChanged;
			// 
			// ControlDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(560, 406);
			Controls.Add(chkbxInject);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(label5);
			Controls.Add(tbName);
			Controls.Add(label3);
			Controls.Add(udTMax);
			Controls.Add(label4);
			Controls.Add(udTMin);
			Controls.Add(label2);
			Controls.Add(udMax);
			Controls.Add(label1);
			Controls.Add(udMin);
			Controls.Add(chkbxInvert);
			Controls.Add(progAxis);
			Controls.Add(lblAxis);
			Controls.Add(comboAxis);
			Controls.Add(lsBxControl);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "ControlDialog";
			Text = "ControlDialog";
			FormClosing += ControlDialog_FormClosing;
			Load += ControlDialog_Load;
			((System.ComponentModel.ISupportInitialize)udMin).EndInit();
			((System.ComponentModel.ISupportInitialize)udMax).EndInit();
			((System.ComponentModel.ISupportInitialize)udTMax).EndInit();
			((System.ComponentModel.ISupportInitialize)udTMin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox lsBxControl;
        private ComboBox comboAxis;
        private Label lblAxis;
        private ProgressBar progAxis;
        private CheckBox chkbxInvert;
        private NumericUpDown udMin;
        private Label label1;
        private Label label2;
        private NumericUpDown udMax;
        private Label label3;
        private NumericUpDown udTMax;
        private Label label4;
        private NumericUpDown udTMin;
        private TextBox tbName;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox chkbxInject;
    }
}