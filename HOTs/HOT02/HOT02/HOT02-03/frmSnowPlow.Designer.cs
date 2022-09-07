namespace HOT02_03
{
    partial class frmSnowPlow
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtDrivewayLength = new System.Windows.Forms.TextBox();
            this.lblDrivewayLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(80, 351);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 57);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(343, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 57);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(590, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblResults.Location = new System.Drawing.Point(80, 173);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(653, 137);
            this.lblResults.TabIndex = 5;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDrivewayLength
            // 
            this.txtDrivewayLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDrivewayLength.Location = new System.Drawing.Point(423, 62);
            this.txtDrivewayLength.Name = "txtDrivewayLength";
            this.txtDrivewayLength.Size = new System.Drawing.Size(310, 34);
            this.txtDrivewayLength.TabIndex = 0;
            this.txtDrivewayLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDrivewayLength
            // 
            this.lblDrivewayLength.AutoSize = true;
            this.lblDrivewayLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDrivewayLength.Location = new System.Drawing.Point(85, 65);
            this.lblDrivewayLength.Name = "lblDrivewayLength";
            this.lblDrivewayLength.Size = new System.Drawing.Size(318, 29);
            this.lblDrivewayLength.TabIndex = 4;
            this.lblDrivewayLength.Text = "Driveway Length (In Feet):";
            // 
            // frmSnowPlow
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDrivewayLength);
            this.Controls.Add(this.txtDrivewayLength);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmSnowPlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andrew Law AWD1100 Chapter 2 Hands-on Test - Problem #3 Snow Plow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtDrivewayLength;
        private System.Windows.Forms.Label lblDrivewayLength;
    }
}

