namespace Chapt06_Lab06
{
    partial class frmPaintingEstimate
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblTotSqFt = new System.Windows.Forms.Label();
            this.lblTotCost = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblTotSqFtOutput = new System.Windows.Forms.Label();
            this.lblTotCostOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(28, 40);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(112, 25);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length (ft)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(158, 40);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(102, 25);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width (ft)";
            // 
            // lblTotSqFt
            // 
            this.lblTotSqFt.AutoSize = true;
            this.lblTotSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotSqFt.Location = new System.Drawing.Point(420, 40);
            this.lblTotSqFt.Name = "lblTotSqFt";
            this.lblTotSqFt.Size = new System.Drawing.Size(252, 25);
            this.lblTotSqFt.TabIndex = 5;
            this.lblTotSqFt.Text = "Total Square Area (sq ft)";
            // 
            // lblTotCost
            // 
            this.lblTotCost.AutoSize = true;
            this.lblTotCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCost.Location = new System.Drawing.Point(724, 40);
            this.lblTotCost.Name = "lblTotCost";
            this.lblTotCost.Size = new System.Drawing.Size(146, 25);
            this.lblTotCost.TabIndex = 6;
            this.lblTotCost.Text = "Total Cost ($)";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(31, 71);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 30);
            this.txtLength.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(161, 71);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 30);
            this.txtWidth.TabIndex = 1;
            // 
            // lblTotSqFtOutput
            // 
            this.lblTotSqFtOutput.AutoSize = true;
            this.lblTotSqFtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotSqFtOutput.Location = new System.Drawing.Point(420, 74);
            this.lblTotSqFtOutput.Name = "lblTotSqFtOutput";
            this.lblTotSqFtOutput.Size = new System.Drawing.Size(0, 25);
            this.lblTotSqFtOutput.TabIndex = 7;
            // 
            // lblTotCostOutput
            // 
            this.lblTotCostOutput.AutoSize = true;
            this.lblTotCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCostOutput.Location = new System.Drawing.Point(724, 74);
            this.lblTotCostOutput.Name = "lblTotCostOutput";
            this.lblTotCostOutput.Size = new System.Drawing.Size(0, 25);
            this.lblTotCostOutput.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(275, 69);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmPaintingEstimate
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 141);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotCostOutput);
            this.Controls.Add(this.lblTotSqFtOutput);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblTotCost);
            this.Controls.Add(this.lblTotSqFt);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmPaintingEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painting Estimate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblTotSqFt;
        private System.Windows.Forms.Label lblTotCost;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblTotSqFtOutput;
        private System.Windows.Forms.Label lblTotCostOutput;
        private System.Windows.Forms.Button btnCalculate;
    }
}

