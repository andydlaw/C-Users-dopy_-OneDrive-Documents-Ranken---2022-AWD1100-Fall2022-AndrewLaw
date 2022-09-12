namespace Chapt5_Pt2Lab05
{
    partial class frmTestScores
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtTestScore = new System.Windows.Forms.TextBox();
            this.lblTestScore = new System.Windows.Forms.Label();
            this.lblNumOfScores = new System.Windows.Forms.Label();
            this.lblSumOfScores = new System.Windows.Forms.Label();
            this.lblAvgOfScores = new System.Windows.Forms.Label();
            this.lblLowestScore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(42, 118);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(146, 53);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtTestScore
            // 
            this.txtTestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestScore.Location = new System.Drawing.Point(42, 73);
            this.txtTestScore.Name = "txtTestScore";
            this.txtTestScore.Size = new System.Drawing.Size(133, 34);
            this.txtTestScore.TabIndex = 1;
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestScore.Location = new System.Drawing.Point(39, 33);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(319, 29);
            this.lblTestScore.TabIndex = 2;
            this.lblTestScore.Text = "Please Enter a Test Score";
            // 
            // lblNumOfScores
            // 
            this.lblNumOfScores.AutoSize = true;
            this.lblNumOfScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfScores.Location = new System.Drawing.Point(48, 209);
            this.lblNumOfScores.Name = "lblNumOfScores";
            this.lblNumOfScores.Size = new System.Drawing.Size(227, 29);
            this.lblNumOfScores.TabIndex = 3;
            this.lblNumOfScores.Text = "Number of scores:";
            // 
            // lblSumOfScores
            // 
            this.lblSumOfScores.AutoSize = true;
            this.lblSumOfScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOfScores.Location = new System.Drawing.Point(48, 238);
            this.lblSumOfScores.Name = "lblSumOfScores";
            this.lblSumOfScores.Size = new System.Drawing.Size(235, 29);
            this.lblSumOfScores.TabIndex = 4;
            this.lblSumOfScores.Text = "Sum of test scores:";
            // 
            // lblAvgOfScores
            // 
            this.lblAvgOfScores.AutoSize = true;
            this.lblAvgOfScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgOfScores.Location = new System.Drawing.Point(48, 267);
            this.lblAvgOfScores.Name = "lblAvgOfScores";
            this.lblAvgOfScores.Size = new System.Drawing.Size(237, 29);
            this.lblAvgOfScores.TabIndex = 5;
            this.lblAvgOfScores.Text = "Average test score:";
            // 
            // lblLowestScore
            // 
            this.lblLowestScore.AutoSize = true;
            this.lblLowestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestScore.Location = new System.Drawing.Point(48, 296);
            this.lblLowestScore.Name = "lblLowestScore";
            this.lblLowestScore.Size = new System.Drawing.Size(238, 29);
            this.lblLowestScore.TabIndex = 6;
            this.lblLowestScore.Text = "Lowest Test Score:";
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestScore.Location = new System.Drawing.Point(48, 325);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(244, 29);
            this.lblHighestScore.TabIndex = 7;
            this.lblHighestScore.Text = "Highest Test Score:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(281, 209);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 29);
            this.lblNumber.TabIndex = 8;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(289, 238);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 29);
            this.lblSum.TabIndex = 9;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(292, 267);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(0, 29);
            this.lblAvg.TabIndex = 10;
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowest.Location = new System.Drawing.Point(292, 296);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(0, 29);
            this.lblLowest.TabIndex = 11;
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighest.Location = new System.Drawing.Point(298, 325);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(0, 29);
            this.lblHighest.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(627, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 84);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTestScores
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.lblLowestScore);
            this.Controls.Add(this.lblAvgOfScores);
            this.Controls.Add(this.lblSumOfScores);
            this.Controls.Add(this.lblNumOfScores);
            this.Controls.Add(this.lblTestScore);
            this.Controls.Add(this.txtTestScore);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmTestScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtTestScore;
        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.Label lblNumOfScores;
        private System.Windows.Forms.Label lblSumOfScores;
        private System.Windows.Forms.Label lblAvgOfScores;
        private System.Windows.Forms.Label lblLowestScore;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Button btnExit;
    }
}

