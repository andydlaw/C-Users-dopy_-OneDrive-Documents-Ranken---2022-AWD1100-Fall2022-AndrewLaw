namespace Chapt14_Lab01
{
    partial class frmLetterDelivery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtSentDate = new System.Windows.Forms.TextBox();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.lblSentDate = new System.Windows.Forms.Label();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.lblMemo);
            this.groupBox1.Controls.Add(this.txtRecipient);
            this.groupBox1.Controls.Add(this.txtSentDate);
            this.groupBox1.Controls.Add(this.txtTrackingNumber);
            this.groupBox1.Controls.Add(this.lblTrackingNumber);
            this.groupBox1.Controls.Add(this.lblSentDate);
            this.groupBox1.Controls.Add(this.lblRecipient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(235, 288);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(80, 243);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(208, 16);
            this.lblMemo.TabIndex = 7;
            this.lblMemo.Text = "(Additional Fee for Certified Letter)";
            this.lblMemo.Visible = false;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(189, 53);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(161, 22);
            this.txtRecipient.TabIndex = 0;
            // 
            // txtSentDate
            // 
            this.txtSentDate.Location = new System.Drawing.Point(189, 122);
            this.txtSentDate.Name = "txtSentDate";
            this.txtSentDate.Size = new System.Drawing.Size(161, 22);
            this.txtSentDate.TabIndex = 1;
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(189, 194);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(161, 22);
            this.txtTrackingNumber.TabIndex = 2;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Location = new System.Drawing.Point(28, 197);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(111, 16);
            this.lblTrackingNumber.TabIndex = 6;
            this.lblTrackingNumber.Text = "Tracking Number";
            // 
            // lblSentDate
            // 
            this.lblSentDate.AutoSize = true;
            this.lblSentDate.Location = new System.Drawing.Point(28, 125);
            this.lblSentDate.Name = "lblSentDate";
            this.lblSentDate.Size = new System.Drawing.Size(66, 16);
            this.lblSentDate.TabIndex = 5;
            this.lblSentDate.Text = "Sent Date";
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(28, 56);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(64, 16);
            this.lblRecipient.TabIndex = 4;
            this.lblRecipient.Text = "Recipient";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(11, 15);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(375, 317);
            this.txtOutput.TabIndex = 0;
            // 
            // frmLetterDelivery
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLetterDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Delivery";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtSentDate;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label lblSentDate;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

