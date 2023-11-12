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
            lsBxDevice = new ListBox();
            comboAxis = new ComboBox();
            lblAxis = new Label();
            progAxis = new ProgressBar();
            chkbxInvert = new CheckBox();
            SuspendLayout();
            // 
            // lsBxDevice
            // 
            lsBxDevice.FormattingEnabled = true;
            lsBxDevice.ItemHeight = 15;
            lsBxDevice.Location = new Point(12, 12);
            lsBxDevice.Name = "lsBxDevice";
            lsBxDevice.Size = new Size(284, 349);
            lsBxDevice.TabIndex = 3;
            // 
            // comboAxis
            // 
            comboAxis.FormattingEnabled = true;
            comboAxis.Location = new Point(89, 367);
            comboAxis.Name = "comboAxis";
            comboAxis.Size = new Size(207, 23);
            comboAxis.TabIndex = 4;
            // 
            // lblAxis
            // 
            lblAxis.AutoSize = true;
            lblAxis.Location = new Point(12, 370);
            lblAxis.Name = "lblAxis";
            lblAxis.Size = new Size(29, 15);
            lblAxis.TabIndex = 5;
            lblAxis.Text = "Axis";
            // 
            // progAxis
            // 
            progAxis.Location = new Point(12, 396);
            progAxis.Name = "progAxis";
            progAxis.Size = new Size(284, 23);
            progAxis.TabIndex = 6;
            // 
            // chkbxInvert
            // 
            chkbxInvert.AutoSize = true;
            chkbxInvert.Location = new Point(12, 425);
            chkbxInvert.Name = "chkbxInvert";
            chkbxInvert.Size = new Size(81, 19);
            chkbxInvert.TabIndex = 7;
            chkbxInvert.Text = "Invert Axis";
            chkbxInvert.UseVisualStyleBackColor = true;
            // 
            // ControlDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 558);
            Controls.Add(chkbxInvert);
            Controls.Add(progAxis);
            Controls.Add(lblAxis);
            Controls.Add(comboAxis);
            Controls.Add(lsBxDevice);
            Name = "ControlDialog";
            Text = "ControlDialog";
            Load += ControlDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsBxDevice;
        private ComboBox comboAxis;
        private Label lblAxis;
        private ProgressBar progAxis;
        private CheckBox chkbxInvert;
    }
}