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
            tbName = new TextBox();
            label1 = new Label();
            lsBxControls = new ListBox();
            label2 = new Label();
            tbSearch = new TextBox();
            comboAxis = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            progAxis = new ProgressBar();
            btnOK = new Button();
            btnCancel = new Button();
            comboDevice = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(144, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(209, 23);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // lsBxControls
            // 
            lsBxControls.FormattingEnabled = true;
            lsBxControls.ItemHeight = 15;
            lsBxControls.Location = new Point(144, 41);
            lsBxControls.Name = "lsBxControls";
            lsBxControls.Size = new Size(209, 319);
            lsBxControls.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Control";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(144, 366);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(209, 23);
            tbSearch.TabIndex = 4;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // comboAxis
            // 
            comboAxis.FormattingEnabled = true;
            comboAxis.Location = new Point(144, 424);
            comboAxis.Name = "comboAxis";
            comboAxis.Size = new Size(209, 23);
            comboAxis.TabIndex = 5;
            comboAxis.SelectedIndexChanged += comboAxis_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 369);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 427);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Axis";
            // 
            // progAxis
            // 
            progAxis.Location = new Point(144, 453);
            progAxis.MarqueeAnimationSpeed = 0;
            progAxis.Maximum = 65536;
            progAxis.Name = "progAxis";
            progAxis.Size = new Size(209, 23);
            progAxis.Style = ProgressBarStyle.Continuous;
            progAxis.TabIndex = 8;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(254, 482);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(99, 23);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(144, 482);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboDevice
            // 
            comboDevice.FormattingEnabled = true;
            comboDevice.Location = new Point(144, 395);
            comboDevice.Name = "comboDevice";
            comboDevice.Size = new Size(209, 23);
            comboDevice.TabIndex = 11;
            comboDevice.SelectedIndexChanged += comboDevice_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 398);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Device";
            // 
            // ControlDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 512);
            Controls.Add(label5);
            Controls.Add(comboDevice);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(progAxis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboAxis);
            Controls.Add(tbSearch);
            Controls.Add(label2);
            Controls.Add(lsBxControls);
            Controls.Add(label1);
            Controls.Add(tbName);
            Name = "ControlDialog";
            Text = "ControlDialog";
            FormClosed += ControlDialog_FormClosed;
            Load += ControlDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private ListBox lsBxControls;
        private Label label2;
        private TextBox tbSearch;
        private ComboBox comboAxis;
        private Label label3;
        private Label label4;
        private ProgressBar progAxis;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox comboDevice;
        private Label label5;
    }
}