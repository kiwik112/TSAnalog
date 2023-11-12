namespace TSAnalog
{
    partial class DeviceDialog
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
            btnRefresh = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lsBxDevice
            // 
            lsBxDevice.FormattingEnabled = true;
            lsBxDevice.ItemHeight = 15;
            lsBxDevice.Location = new Point(12, 12);
            lsBxDevice.Name = "lsBxDevice";
            lsBxDevice.Size = new Size(284, 349);
            lsBxDevice.TabIndex = 0;
            lsBxDevice.SelectedIndexChanged += lsBxDevice_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(221, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(221, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // DeviceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 402);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(lsBxDevice);
            Name = "DeviceDialog";
            Text = "DeviceDialog";
            Load += DeviceDialog_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsBxDevice;
        private Button btnRefresh;
        private Button btnAdd;
    }
}