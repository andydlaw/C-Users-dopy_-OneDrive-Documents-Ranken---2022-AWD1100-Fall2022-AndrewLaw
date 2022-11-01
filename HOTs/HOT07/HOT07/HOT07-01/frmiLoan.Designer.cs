namespace HOT07_01
{
    partial class frmiLoan
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
            this.gbxCreateLoan = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoLongTermLoan = new System.Windows.Forms.RadioButton();
            this.rdoShortTermLoan = new System.Windows.Forms.RadioButton();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxManageLoan = new System.Windows.Forms.GroupBox();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblAccruedInterest = new System.Windows.Forms.Label();
            this.lblBalanceOutput = new System.Windows.Forms.Label();
            this.lblLoanTypeAmountOutput = new System.Windows.Forms.Label();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.gbxCreateLoan.SuspendLayout();
            this.gbxManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCreateLoan
            // 
            this.gbxCreateLoan.Controls.Add(this.txtAmount);
            this.gbxCreateLoan.Controls.Add(this.txtName);
            this.gbxCreateLoan.Controls.Add(this.rdoLongTermLoan);
            this.gbxCreateLoan.Controls.Add(this.rdoShortTermLoan);
            this.gbxCreateLoan.Controls.Add(this.btnCreateLoan);
            this.gbxCreateLoan.Controls.Add(this.lblLoanType);
            this.gbxCreateLoan.Controls.Add(this.lblAmount);
            this.gbxCreateLoan.Controls.Add(this.lblName);
            this.gbxCreateLoan.Location = new System.Drawing.Point(40, 30);
            this.gbxCreateLoan.Name = "gbxCreateLoan";
            this.gbxCreateLoan.Size = new System.Drawing.Size(437, 235);
            this.gbxCreateLoan.TabIndex = 1;
            this.gbxCreateLoan.TabStop = false;
            this.gbxCreateLoan.Text = "Create Loan";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(84, 69);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(276, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 22);
            this.txtName.TabIndex = 0;
            // 
            // rdoLongTermLoan
            // 
            this.rdoLongTermLoan.AutoSize = true;
            this.rdoLongTermLoan.Location = new System.Drawing.Point(84, 136);
            this.rdoLongTermLoan.Name = "rdoLongTermLoan";
            this.rdoLongTermLoan.Size = new System.Drawing.Size(127, 20);
            this.rdoLongTermLoan.TabIndex = 3;
            this.rdoLongTermLoan.TabStop = true;
            this.rdoLongTermLoan.Text = "Long-Term Loan";
            this.rdoLongTermLoan.UseVisualStyleBackColor = true;
            // 
            // rdoShortTermLoan
            // 
            this.rdoShortTermLoan.AutoSize = true;
            this.rdoShortTermLoan.Location = new System.Drawing.Point(84, 110);
            this.rdoShortTermLoan.Name = "rdoShortTermLoan";
            this.rdoShortTermLoan.Size = new System.Drawing.Size(128, 20);
            this.rdoShortTermLoan.TabIndex = 2;
            this.rdoShortTermLoan.TabStop = true;
            this.rdoShortTermLoan.Text = "Short-Term Loan";
            this.rdoShortTermLoan.UseVisualStyleBackColor = true;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(22, 175);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(112, 28);
            this.btnCreateLoan.TabIndex = 4;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Location = new System.Drawing.Point(19, 110);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(39, 16);
            this.lblLoanType.TabIndex = 7;
            this.lblLoanType.Text = "Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(19, 72);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // gbxManageLoan
            // 
            this.gbxManageLoan.Controls.Add(this.btnMakePayment);
            this.gbxManageLoan.Controls.Add(this.lblAccruedInterest);
            this.gbxManageLoan.Controls.Add(this.lblBalanceOutput);
            this.gbxManageLoan.Controls.Add(this.lblLoanTypeAmountOutput);
            this.gbxManageLoan.Controls.Add(this.lblNameOutput);
            this.gbxManageLoan.Location = new System.Drawing.Point(40, 313);
            this.gbxManageLoan.Name = "gbxManageLoan";
            this.gbxManageLoan.Size = new System.Drawing.Size(437, 257);
            this.gbxManageLoan.TabIndex = 0;
            this.gbxManageLoan.TabStop = false;
            this.gbxManageLoan.Text = "Manage Loan";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(22, 129);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(128, 28);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblAccruedInterest
            // 
            this.lblAccruedInterest.AutoSize = true;
            this.lblAccruedInterest.Location = new System.Drawing.Point(19, 218);
            this.lblAccruedInterest.Name = "lblAccruedInterest";
            this.lblAccruedInterest.Size = new System.Drawing.Size(0, 16);
            this.lblAccruedInterest.TabIndex = 4;
            // 
            // lblBalanceOutput
            // 
            this.lblBalanceOutput.AutoSize = true;
            this.lblBalanceOutput.Location = new System.Drawing.Point(19, 182);
            this.lblBalanceOutput.Name = "lblBalanceOutput";
            this.lblBalanceOutput.Size = new System.Drawing.Size(0, 16);
            this.lblBalanceOutput.TabIndex = 3;
            // 
            // lblLoanTypeAmountOutput
            // 
            this.lblLoanTypeAmountOutput.AutoSize = true;
            this.lblLoanTypeAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTypeAmountOutput.Location = new System.Drawing.Point(19, 93);
            this.lblLoanTypeAmountOutput.Name = "lblLoanTypeAmountOutput";
            this.lblLoanTypeAmountOutput.Size = new System.Drawing.Size(0, 18);
            this.lblLoanTypeAmountOutput.TabIndex = 2;
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.AutoSize = true;
            this.lblNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOutput.Location = new System.Drawing.Point(19, 51);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(0, 20);
            this.lblNameOutput.TabIndex = 1;
            // 
            // frmiLoan
            // 
            this.AcceptButton = this.btnCreateLoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 599);
            this.Controls.Add(this.gbxManageLoan);
            this.Controls.Add(this.gbxCreateLoan);
            this.Name = "frmiLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Loan";
            this.gbxCreateLoan.ResumeLayout(false);
            this.gbxCreateLoan.PerformLayout();
            this.gbxManageLoan.ResumeLayout(false);
            this.gbxManageLoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateLoan;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoLongTermLoan;
        private System.Windows.Forms.RadioButton rdoShortTermLoan;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxManageLoan;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblAccruedInterest;
        private System.Windows.Forms.Label lblBalanceOutput;
        private System.Windows.Forms.Label lblLoanTypeAmountOutput;
        private System.Windows.Forms.Label lblNameOutput;
    }
}

