namespace Pretest02_02
{
    partial class frmBattingAverage
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
            this.lblAtBats = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblTotNumOfAvg = new System.Windows.Forms.Label();
            this.lblLowestAvg = new System.Windows.Forms.Label();
            this.lblHighestAvg = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.txtAtBat = new System.Windows.Forms.TextBox();
            this.txtTotNumOfAvg = new System.Windows.Forms.TextBox();
            this.txtLowestAvg = new System.Windows.Forms.TextBox();
            this.txtHighestAvg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(54, 343);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(165, 50);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(319, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(598, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAtBats
            // 
            this.lblAtBats.AutoSize = true;
            this.lblAtBats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtBats.Location = new System.Drawing.Point(64, 57);
            this.lblAtBats.Name = "lblAtBats";
            this.lblAtBats.Size = new System.Drawing.Size(119, 36);
            this.lblAtBats.TabIndex = 9;
            this.lblAtBats.Text = "At Bats:";
            this.lblAtBats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHits.Location = new System.Drawing.Point(109, 144);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(74, 36);
            this.lblHits.TabIndex = 10;
            this.lblHits.Text = "Hits:";
            this.lblHits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(49, 245);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(134, 36);
            this.lblAvg.TabIndex = 11;
            this.lblAvg.Text = "Average:";
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotNumOfAvg
            // 
            this.lblTotNumOfAvg.AutoSize = true;
            this.lblTotNumOfAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotNumOfAvg.Location = new System.Drawing.Point(355, 245);
            this.lblTotNumOfAvg.Name = "lblTotNumOfAvg";
            this.lblTotNumOfAvg.Size = new System.Drawing.Size(208, 36);
            this.lblTotNumOfAvg.TabIndex = 14;
            this.lblTotNumOfAvg.Text = "Total # of Avg:";
            this.lblTotNumOfAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLowestAvg
            // 
            this.lblLowestAvg.AutoSize = true;
            this.lblLowestAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestAvg.Location = new System.Drawing.Point(384, 147);
            this.lblLowestAvg.Name = "lblLowestAvg";
            this.lblLowestAvg.Size = new System.Drawing.Size(179, 36);
            this.lblLowestAvg.TabIndex = 13;
            this.lblLowestAvg.Text = "Lowest Avg:";
            this.lblLowestAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHighestAvg
            // 
            this.lblHighestAvg.AutoSize = true;
            this.lblHighestAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestAvg.Location = new System.Drawing.Point(377, 57);
            this.lblHighestAvg.Name = "lblHighestAvg";
            this.lblHighestAvg.Size = new System.Drawing.Size(185, 36);
            this.lblHighestAvg.TabIndex = 12;
            this.lblHighestAvg.Text = "Highest Avg:";
            this.lblHighestAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAvg
            // 
            this.txtAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvg.Location = new System.Drawing.Point(189, 242);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(144, 41);
            this.txtAvg.TabIndex = 5;
            // 
            // txtHits
            // 
            this.txtHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHits.Location = new System.Drawing.Point(189, 144);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(144, 41);
            this.txtHits.TabIndex = 1;
            // 
            // txtAtBat
            // 
            this.txtAtBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtBat.Location = new System.Drawing.Point(189, 54);
            this.txtAtBat.Name = "txtAtBat";
            this.txtAtBat.Size = new System.Drawing.Size(144, 41);
            this.txtAtBat.TabIndex = 0;
            // 
            // txtTotNumOfAvg
            // 
            this.txtTotNumOfAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotNumOfAvg.Location = new System.Drawing.Point(568, 242);
            this.txtTotNumOfAvg.Name = "txtTotNumOfAvg";
            this.txtTotNumOfAvg.ReadOnly = true;
            this.txtTotNumOfAvg.Size = new System.Drawing.Size(144, 41);
            this.txtTotNumOfAvg.TabIndex = 8;
            // 
            // txtLowestAvg
            // 
            this.txtLowestAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowestAvg.Location = new System.Drawing.Point(568, 144);
            this.txtLowestAvg.Name = "txtLowestAvg";
            this.txtLowestAvg.ReadOnly = true;
            this.txtLowestAvg.Size = new System.Drawing.Size(144, 41);
            this.txtLowestAvg.TabIndex = 7;
            // 
            // txtHighestAvg
            // 
            this.txtHighestAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighestAvg.Location = new System.Drawing.Point(568, 54);
            this.txtHighestAvg.Name = "txtHighestAvg";
            this.txtHighestAvg.ReadOnly = true;
            this.txtHighestAvg.Size = new System.Drawing.Size(144, 41);
            this.txtHighestAvg.TabIndex = 6;
            // 
            // frmBattingAverage
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.txtHighestAvg);
            this.Controls.Add(this.txtLowestAvg);
            this.Controls.Add(this.txtTotNumOfAvg);
            this.Controls.Add(this.txtAtBat);
            this.Controls.Add(this.txtHits);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.lblHighestAvg);
            this.Controls.Add(this.lblLowestAvg);
            this.Controls.Add(this.lblTotNumOfAvg);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.lblAtBats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmBattingAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batting Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAtBats;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblTotNumOfAvg;
        private System.Windows.Forms.Label lblLowestAvg;
        private System.Windows.Forms.Label lblHighestAvg;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.TextBox txtAtBat;
        private System.Windows.Forms.TextBox txtTotNumOfAvg;
        private System.Windows.Forms.TextBox txtLowestAvg;
        private System.Windows.Forms.TextBox txtHighestAvg;
    }
}

