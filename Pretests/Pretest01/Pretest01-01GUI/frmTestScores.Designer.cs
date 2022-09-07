namespace Pretest01_01GUI
{
    partial class frm
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
            this.lblTestScore1 = new System.Windows.Forms.Label();
            this.lblTestScore2 = new System.Windows.Forms.Label();
            this.lblTestScore3 = new System.Windows.Forms.Label();
            this.lblTestScore4 = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.txtTestScore1 = new System.Windows.Forms.TextBox();
            this.txtTestScore2 = new System.Windows.Forms.TextBox();
            this.txtTestScore3 = new System.Windows.Forms.TextBox();
            this.txtTestScore4 = new System.Windows.Forms.TextBox();
            this.txtAvgScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(47, 414);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(7);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 86);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(384, 414);
            this.btnClear.Margin = new System.Windows.Forms.Padding(7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(249, 86);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(734, 411);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 89);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTestScore1
            // 
            this.lblTestScore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTestScore1.Location = new System.Drawing.Point(191, 59);
            this.lblTestScore1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTestScore1.Name = "lblTestScore1";
            this.lblTestScore1.Size = new System.Drawing.Size(223, 62);
            this.lblTestScore1.TabIndex = 8;
            this.lblTestScore1.Text = "Test Score 1:";
            // 
            // lblTestScore2
            // 
            this.lblTestScore2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTestScore2.Location = new System.Drawing.Point(191, 121);
            this.lblTestScore2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTestScore2.Name = "lblTestScore2";
            this.lblTestScore2.Size = new System.Drawing.Size(223, 62);
            this.lblTestScore2.TabIndex = 9;
            this.lblTestScore2.Text = "Test Score 2:";
            // 
            // lblTestScore3
            // 
            this.lblTestScore3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTestScore3.Location = new System.Drawing.Point(191, 183);
            this.lblTestScore3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTestScore3.Name = "lblTestScore3";
            this.lblTestScore3.Size = new System.Drawing.Size(223, 62);
            this.lblTestScore3.TabIndex = 10;
            this.lblTestScore3.Text = "Test Score 3:";
            // 
            // lblTestScore4
            // 
            this.lblTestScore4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTestScore4.Location = new System.Drawing.Point(191, 245);
            this.lblTestScore4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTestScore4.Name = "lblTestScore4";
            this.lblTestScore4.Size = new System.Drawing.Size(223, 62);
            this.lblTestScore4.TabIndex = 11;
            this.lblTestScore4.Text = "Test Score 4:";
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAvgScore.Location = new System.Drawing.Point(191, 307);
            this.lblAvgScore.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(223, 62);
            this.lblAvgScore.TabIndex = 12;
            this.lblAvgScore.Text = "Avg Score:";
            // 
            // txtTestScore1
            // 
            this.txtTestScore1.Location = new System.Drawing.Point(457, 59);
            this.txtTestScore1.Name = "txtTestScore1";
            this.txtTestScore1.Size = new System.Drawing.Size(325, 42);
            this.txtTestScore1.TabIndex = 0;
            // 
            // txtTestScore2
            // 
            this.txtTestScore2.Location = new System.Drawing.Point(457, 121);
            this.txtTestScore2.Name = "txtTestScore2";
            this.txtTestScore2.Size = new System.Drawing.Size(325, 42);
            this.txtTestScore2.TabIndex = 1;
            // 
            // txtTestScore3
            // 
            this.txtTestScore3.Location = new System.Drawing.Point(457, 183);
            this.txtTestScore3.Name = "txtTestScore3";
            this.txtTestScore3.Size = new System.Drawing.Size(325, 42);
            this.txtTestScore3.TabIndex = 2;
            // 
            // txtTestScore4
            // 
            this.txtTestScore4.Location = new System.Drawing.Point(457, 242);
            this.txtTestScore4.Name = "txtTestScore4";
            this.txtTestScore4.Size = new System.Drawing.Size(325, 42);
            this.txtTestScore4.TabIndex = 3;
            // 
            // txtAvgScore
            // 
            this.txtAvgScore.Location = new System.Drawing.Point(457, 307);
            this.txtAvgScore.Name = "txtAvgScore";
            this.txtAvgScore.ReadOnly = true;
            this.txtAvgScore.Size = new System.Drawing.Size(325, 42);
            this.txtAvgScore.TabIndex = 7;
            // 
            // frm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1042, 541);
            this.Controls.Add(this.txtAvgScore);
            this.Controls.Add(this.txtTestScore4);
            this.Controls.Add(this.txtTestScore3);
            this.Controls.Add(this.txtTestScore2);
            this.Controls.Add(this.txtTestScore1);
            this.Controls.Add(this.lblAvgScore);
            this.Controls.Add(this.lblTestScore4);
            this.Controls.Add(this.lblTestScore3);
            this.Controls.Add(this.lblTestScore2);
            this.Controls.Add(this.lblTestScore1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTestScore1;
        private System.Windows.Forms.Label lblTestScore2;
        private System.Windows.Forms.Label lblTestScore3;
        private System.Windows.Forms.Label lblTestScore4;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.TextBox txtTestScore1;
        private System.Windows.Forms.TextBox txtTestScore2;
        private System.Windows.Forms.TextBox txtTestScore3;
        private System.Windows.Forms.TextBox txtTestScore4;
        private System.Windows.Forms.TextBox txtAvgScore;
    }
}

