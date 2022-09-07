namespace HOT02_01
{
    partial class frmDistanceConverter
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
            this.txtYards = new System.Windows.Forms.TextBox();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.lblYards = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(81, 311);
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(313, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 57);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(546, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtYards
            // 
            this.txtYards.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYards.Location = new System.Drawing.Point(349, 83);
            this.txtYards.Name = "txtYards";
            this.txtYards.Size = new System.Drawing.Size(310, 34);
            this.txtYards.TabIndex = 0;
            this.txtYards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMeters
            // 
            this.txtMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeters.Location = new System.Drawing.Point(349, 171);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.ReadOnly = true;
            this.txtMeters.Size = new System.Drawing.Size(310, 34);
            this.txtMeters.TabIndex = 4;
            this.txtMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYards
            // 
            this.lblYards.AutoSize = true;
            this.lblYards.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYards.Location = new System.Drawing.Point(50, 86);
            this.lblYards.Name = "lblYards";
            this.lblYards.Size = new System.Drawing.Size(277, 29);
            this.lblYards.TabIndex = 5;
            this.lblYards.Text = "Enter Value For Yards:";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeters.Location = new System.Drawing.Point(46, 174);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(281, 29);
            this.lblMeters.TabIndex = 6;
            this.lblMeters.Text = "Value Above In Meters:";
            // 
            // frmDistanceConverter
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMeters);
            this.Controls.Add(this.lblYards);
            this.Controls.Add(this.txtMeters);
            this.Controls.Add(this.txtYards);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmDistanceConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andrew Law AWD1100 Chapter 2 Hands-on Test - Problem #1 Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtYards;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.Label lblYards;
        private System.Windows.Forms.Label lblMeters;
    }
}

