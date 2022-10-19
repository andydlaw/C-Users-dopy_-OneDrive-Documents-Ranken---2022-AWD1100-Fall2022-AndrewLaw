namespace Chapt12_Lab05
{
    partial class frmJobEstimate
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHoursToComplete = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTripFee = new System.Windows.Forms.Label();
            this.lblCurrentTotal = new System.Windows.Forms.Label();
            this.lblCurrentHourlyRate = new System.Windows.Forms.Label();
            this.lblCurrentHoursToComplete = new System.Windows.Forms.Label();
            this.lblCurrentValueDescr = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHoursToComplete = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(37, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 16);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblHoursToComplete
            // 
            this.lblHoursToComplete.AutoSize = true;
            this.lblHoursToComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursToComplete.Location = new System.Drawing.Point(37, 128);
            this.lblHoursToComplete.Name = "lblHoursToComplete";
            this.lblHoursToComplete.Size = new System.Drawing.Size(135, 16);
            this.lblHoursToComplete.TabIndex = 1;
            this.lblHoursToComplete.Text = "Hours to Complete";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(37, 181);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(89, 16);
            this.lblHourlyRate.TabIndex = 2;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(37, 242);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Fee";
            // 
            // lblTripFee
            // 
            this.lblTripFee.AutoSize = true;
            this.lblTripFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripFee.Location = new System.Drawing.Point(169, 242);
            this.lblTripFee.Name = "lblTripFee";
            this.lblTripFee.Size = new System.Drawing.Size(138, 16);
            this.lblTripFee.TabIndex = 4;
            this.lblTripFee.Text = "Plus Trip Fee ($35)";
            // 
            // lblCurrentTotal
            // 
            this.lblCurrentTotal.AutoSize = true;
            this.lblCurrentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTotal.Location = new System.Drawing.Point(345, 242);
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            this.lblCurrentTotal.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentTotal.TabIndex = 5;
            // 
            // lblCurrentHourlyRate
            // 
            this.lblCurrentHourlyRate.AutoSize = true;
            this.lblCurrentHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHourlyRate.Location = new System.Drawing.Point(345, 181);
            this.lblCurrentHourlyRate.Name = "lblCurrentHourlyRate";
            this.lblCurrentHourlyRate.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentHourlyRate.TabIndex = 6;
            // 
            // lblCurrentHoursToComplete
            // 
            this.lblCurrentHoursToComplete.AutoSize = true;
            this.lblCurrentHoursToComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHoursToComplete.Location = new System.Drawing.Point(345, 128);
            this.lblCurrentHoursToComplete.Name = "lblCurrentHoursToComplete";
            this.lblCurrentHoursToComplete.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentHoursToComplete.TabIndex = 7;
            // 
            // lblCurrentValueDescr
            // 
            this.lblCurrentValueDescr.AutoSize = true;
            this.lblCurrentValueDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentValueDescr.Location = new System.Drawing.Point(345, 79);
            this.lblCurrentValueDescr.Name = "lblCurrentValueDescr";
            this.lblCurrentValueDescr.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentValueDescr.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(186, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // txtHoursToComplete
            // 
            this.txtHoursToComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursToComplete.Location = new System.Drawing.Point(186, 125);
            this.txtHoursToComplete.Name = "txtHoursToComplete";
            this.txtHoursToComplete.Size = new System.Drawing.Size(133, 22);
            this.txtHoursToComplete.TabIndex = 10;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(186, 178);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(133, 22);
            this.txtHourlyRate.TabIndex = 11;
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewValue.Location = new System.Drawing.Point(183, 33);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(81, 16);
            this.lblNewValue.TabIndex = 12;
            this.lblNewValue.Text = "New Value";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentValue.Location = new System.Drawing.Point(336, 33);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(100, 16);
            this.lblCurrentValue.TabIndex = 13;
            this.lblCurrentValue.Text = "Current Value";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(186, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmJobEstimate
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 358);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtHoursToComplete);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCurrentValueDescr);
            this.Controls.Add(this.lblCurrentHoursToComplete);
            this.Controls.Add(this.lblCurrentHourlyRate);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.lblTripFee);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblHoursToComplete);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmJobEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harold\'s Home Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHoursToComplete;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTripFee;
        private System.Windows.Forms.Label lblCurrentTotal;
        private System.Windows.Forms.Label lblCurrentHourlyRate;
        private System.Windows.Forms.Label lblCurrentHoursToComplete;
        private System.Windows.Forms.Label lblCurrentValueDescr;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHoursToComplete;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblNewValue;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Button btnUpdate;
    }
}

