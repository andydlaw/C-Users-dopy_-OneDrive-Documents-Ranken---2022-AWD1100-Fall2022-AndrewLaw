namespace Pretest02_01
{
    partial class frmTempConvertor
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
            this.lblFahr = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtFahr = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.btnConvertFtoC = new System.Windows.Forms.Button();
            this.btnConvertCtoF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFahr
            // 
            this.lblFahr.AutoSize = true;
            this.lblFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahr.Location = new System.Drawing.Point(124, 19);
            this.lblFahr.Name = "lblFahr";
            this.lblFahr.Size = new System.Drawing.Size(158, 36);
            this.lblFahr.TabIndex = 6;
            this.lblFahr.Text = "Fahr Temp";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(578, 19);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(141, 36);
            this.lblCel.TabIndex = 7;
            this.lblCel.Text = "Cel Temp";
            // 
            // txtFahr
            // 
            this.txtFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahr.Location = new System.Drawing.Point(103, 64);
            this.txtFahr.Name = "txtFahr";
            this.txtFahr.Size = new System.Drawing.Size(193, 41);
            this.txtFahr.TabIndex = 0;
            this.txtFahr.Tag = "Fahrenheit";
            this.txtFahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(550, 64);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(193, 41);
            this.txtCel.TabIndex = 2;
            this.txtCel.Tag = "Celsius";
            // 
            // btnConvertFtoC
            // 
            this.btnConvertFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFtoC.Location = new System.Drawing.Point(48, 125);
            this.btnConvertFtoC.Name = "btnConvertFtoC";
            this.btnConvertFtoC.Size = new System.Drawing.Size(311, 61);
            this.btnConvertFtoC.TabIndex = 1;
            this.btnConvertFtoC.Text = "Convert F to C";
            this.btnConvertFtoC.UseVisualStyleBackColor = true;
            this.btnConvertFtoC.Click += new System.EventHandler(this.btnConvertMtoK_Click);
            // 
            // btnConvertCtoF
            // 
            this.btnConvertCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertCtoF.Location = new System.Drawing.Point(503, 125);
            this.btnConvertCtoF.Name = "btnConvertCtoF";
            this.btnConvertCtoF.Size = new System.Drawing.Size(285, 61);
            this.btnConvertCtoF.TabIndex = 3;
            this.btnConvertCtoF.Text = "Convert C to F";
            this.btnConvertCtoF.UseVisualStyleBackColor = true;
            this.btnConvertCtoF.Click += new System.EventHandler(this.btnConvertKtoM_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(114, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 61);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(575, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 61);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTempConvertor
            // 
            this.AcceptButton = this.btnConvertFtoC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(831, 401);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvertCtoF);
            this.Controls.Add(this.btnConvertFtoC);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtFahr);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblFahr);
            this.Name = "frmTempConvertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 - Pretest #3 - Problem 1 - Temperture Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahr;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtFahr;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Button btnConvertFtoC;
        private System.Windows.Forms.Button btnConvertCtoF;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

