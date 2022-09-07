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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCellTemp = new System.Windows.Forms.Label();
            this.txtFarhTemp = new System.Windows.Forms.TextBox();
            this.txtCellTemp = new System.Windows.Forms.TextBox();
            this.btnConvertFtoC = new System.Windows.Forms.Button();
            this.btnConvertCtoF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fahr Temp";
            // 
            // lblCellTemp
            // 
            this.lblCellTemp.AutoSize = true;
            this.lblCellTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellTemp.Location = new System.Drawing.Point(580, 75);
            this.lblCellTemp.Name = "lblCellTemp";
            this.lblCellTemp.Size = new System.Drawing.Size(141, 36);
            this.lblCellTemp.TabIndex = 7;
            this.lblCellTemp.Text = "Cel Temp";
            // 
            // txtFarhTemp
            // 
            this.txtFarhTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarhTemp.Location = new System.Drawing.Point(103, 120);
            this.txtFarhTemp.Name = "txtFarhTemp";
            this.txtFarhTemp.Size = new System.Drawing.Size(193, 41);
            this.txtFarhTemp.TabIndex = 0;
            // 
            // txtCellTemp
            // 
            this.txtCellTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellTemp.Location = new System.Drawing.Point(550, 120);
            this.txtCellTemp.Name = "txtCellTemp";
            this.txtCellTemp.Size = new System.Drawing.Size(193, 41);
            this.txtCellTemp.TabIndex = 1;
            // 
            // btnConvertFtoC
            // 
            this.btnConvertFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFtoC.Location = new System.Drawing.Point(48, 181);
            this.btnConvertFtoC.Name = "btnConvertFtoC";
            this.btnConvertFtoC.Size = new System.Drawing.Size(311, 61);
            this.btnConvertFtoC.TabIndex = 2;
            this.btnConvertFtoC.Text = "Convert F to C";
            this.btnConvertFtoC.UseVisualStyleBackColor = true;
            this.btnConvertFtoC.Click += new System.EventHandler(this.btnConvertFtoC_Click);
            // 
            // btnConvertCtoF
            // 
            this.btnConvertCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertCtoF.Location = new System.Drawing.Point(503, 181);
            this.btnConvertCtoF.Name = "btnConvertCtoF";
            this.btnConvertCtoF.Size = new System.Drawing.Size(285, 61);
            this.btnConvertCtoF.TabIndex = 3;
            this.btnConvertCtoF.Text = "Covert C to F";
            this.btnConvertCtoF.UseVisualStyleBackColor = true;
            this.btnConvertCtoF.Click += new System.EventHandler(this.btnConvertCtoF_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(221, 291);
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
            this.btnExit.Location = new System.Drawing.Point(457, 291);
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
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvertCtoF);
            this.Controls.Add(this.btnConvertFtoC);
            this.Controls.Add(this.txtCellTemp);
            this.Controls.Add(this.txtFarhTemp);
            this.Controls.Add(this.lblCellTemp);
            this.Controls.Add(this.label1);
            this.Name = "frmTempConvertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCellTemp;
        private System.Windows.Forms.TextBox txtFarhTemp;
        private System.Windows.Forms.TextBox txtCellTemp;
        private System.Windows.Forms.Button btnConvertFtoC;
        private System.Windows.Forms.Button btnConvertCtoF;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

