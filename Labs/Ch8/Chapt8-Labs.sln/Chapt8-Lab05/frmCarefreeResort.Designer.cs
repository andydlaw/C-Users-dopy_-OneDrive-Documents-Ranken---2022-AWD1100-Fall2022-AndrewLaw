namespace Chapt8_Lab05
{
    partial class frmCarefreeResort
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
            this.lblNightsStayed = new System.Windows.Forms.Label();
            this.lblNC = new System.Windows.Forms.Label();
            this.lblTCOS = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNightsStayed = new System.Windows.Forms.TextBox();
            this.lblNightlyCost = new System.Windows.Forms.Label();
            this.lblTotalCostOfStay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNightsStayed
            // 
            this.lblNightsStayed.AutoSize = true;
            this.lblNightsStayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightsStayed.Location = new System.Drawing.Point(22, 30);
            this.lblNightsStayed.Name = "lblNightsStayed";
            this.lblNightsStayed.Size = new System.Drawing.Size(126, 20);
            this.lblNightsStayed.TabIndex = 4;
            this.lblNightsStayed.Text = "Nights Stayed";
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNC.Location = new System.Drawing.Point(379, 30);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(112, 20);
            this.lblNC.TabIndex = 5;
            this.lblNC.Text = "Nightly Cost";
            // 
            // lblTCOS
            // 
            this.lblTCOS.AutoSize = true;
            this.lblTCOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCOS.Location = new System.Drawing.Point(526, 30);
            this.lblTCOS.Name = "lblTCOS";
            this.lblTCOS.Size = new System.Drawing.Size(161, 20);
            this.lblTCOS.TabIndex = 6;
            this.lblTCOS.Text = "Total Cost of Stay";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(206, 52);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 40);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtNightsStayed
            // 
            this.txtNightsStayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNightsStayed.Location = new System.Drawing.Point(25, 59);
            this.txtNightsStayed.Name = "txtNightsStayed";
            this.txtNightsStayed.Size = new System.Drawing.Size(153, 27);
            this.txtNightsStayed.TabIndex = 0;
            // 
            // lblNightlyCost
            // 
            this.lblNightlyCost.AutoSize = true;
            this.lblNightlyCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightlyCost.Location = new System.Drawing.Point(387, 62);
            this.lblNightlyCost.Name = "lblNightlyCost";
            this.lblNightlyCost.Size = new System.Drawing.Size(0, 20);
            this.lblNightlyCost.TabIndex = 2;
            // 
            // lblTotalCostOfStay
            // 
            this.lblTotalCostOfStay.AutoSize = true;
            this.lblTotalCostOfStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostOfStay.Location = new System.Drawing.Point(537, 62);
            this.lblTotalCostOfStay.Name = "lblTotalCostOfStay";
            this.lblTotalCostOfStay.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCostOfStay.TabIndex = 3;
            // 
            // frmCarefreeResort
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 150);
            this.Controls.Add(this.lblTotalCostOfStay);
            this.Controls.Add(this.lblNightlyCost);
            this.Controls.Add(this.txtNightsStayed);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTCOS);
            this.Controls.Add(this.lblNC);
            this.Controls.Add(this.lblNightsStayed);
            this.Name = "frmCarefreeResort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Carefree Resort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNightsStayed;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.Label lblTCOS;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNightsStayed;
        private System.Windows.Forms.Label lblNightlyCost;
        private System.Windows.Forms.Label lblTotalCostOfStay;
    }
}

