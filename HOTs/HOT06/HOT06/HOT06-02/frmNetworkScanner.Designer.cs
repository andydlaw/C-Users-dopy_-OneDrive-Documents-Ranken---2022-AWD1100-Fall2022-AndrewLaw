namespace HOT05_02
{
    partial class frmNetworkScanner
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
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblIPAddressOutput = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblServicesOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(31, 47);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(283, 27);
            this.txtIPAddress.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(364, 40);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(113, 40);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(27, 21);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(91, 20);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "IP Address";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(26, 113);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 25);
            this.lblComputer.TabIndex = 3;
            // 
            // lblIPAddressOutput
            // 
            this.lblIPAddressOutput.AutoSize = true;
            this.lblIPAddressOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddressOutput.Location = new System.Drawing.Point(27, 138);
            this.lblIPAddressOutput.Name = "lblIPAddressOutput";
            this.lblIPAddressOutput.Size = new System.Drawing.Size(0, 20);
            this.lblIPAddressOutput.TabIndex = 4;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(27, 170);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(82, 20);
            this.lblServices.TabIndex = 5;
            this.lblServices.Text = "Services";
            // 
            // lblServicesOutput
            // 
            this.lblServicesOutput.AutoSize = true;
            this.lblServicesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicesOutput.Location = new System.Drawing.Point(27, 190);
            this.lblServicesOutput.Name = "lblServicesOutput";
            this.lblServicesOutput.Size = new System.Drawing.Size(0, 20);
            this.lblServicesOutput.TabIndex = 6;
            // 
            // frmNetworkScanner
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 557);
            this.Controls.Add(this.lblServicesOutput);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblIPAddressOutput);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtIPAddress);
            this.Name = "frmNetworkScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblIPAddressOutput;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblServicesOutput;
    }
}

