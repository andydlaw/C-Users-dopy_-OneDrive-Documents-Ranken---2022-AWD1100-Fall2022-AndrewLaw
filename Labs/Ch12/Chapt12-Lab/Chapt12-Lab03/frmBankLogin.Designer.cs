namespace Chapt12_Lab03
{
    partial class frmBankLogin
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
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdrawl = new System.Windows.Forms.Label();
            this.txtWithdrawl = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtWelcomeInfo = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrawl = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNum.Location = new System.Drawing.Point(26, 15);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(109, 25);
            this.lblAcctNum.TabIndex = 8;
            this.lblAcctNum.Text = "Account #";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(26, 60);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(47, 25);
            this.lblPin.TabIndex = 9;
            this.lblPin.Text = "PIN";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(26, 282);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(342, 25);
            this.lblDeposit.TabIndex = 10;
            this.lblDeposit.Text = "Would you like to make a deposit?";
            // 
            // lblWithdrawl
            // 
            this.lblWithdrawl.AutoSize = true;
            this.lblWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawl.Location = new System.Drawing.Point(26, 366);
            this.lblWithdrawl.Name = "lblWithdrawl";
            this.lblWithdrawl.Size = new System.Drawing.Size(373, 25);
            this.lblWithdrawl.TabIndex = 11;
            this.lblWithdrawl.Text = "Would you like to make a withdrawal?";
            // 
            // txtWithdrawl
            // 
            this.txtWithdrawl.Enabled = false;
            this.txtWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawl.Location = new System.Drawing.Point(31, 402);
            this.txtWithdrawl.Name = "txtWithdrawl";
            this.txtWithdrawl.Size = new System.Drawing.Size(201, 30);
            this.txtWithdrawl.TabIndex = 5;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Enabled = false;
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(31, 318);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(201, 30);
            this.txtDeposit.TabIndex = 3;
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNum.Location = new System.Drawing.Point(169, 12);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(168, 30);
            this.txtAcctNum.TabIndex = 0;
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(169, 57);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(168, 30);
            this.txtPin.TabIndex = 1;
            // 
            // txtWelcomeInfo
            // 
            this.txtWelcomeInfo.AcceptsReturn = true;
            this.txtWelcomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcomeInfo.Location = new System.Drawing.Point(31, 108);
            this.txtWelcomeInfo.Multiline = true;
            this.txtWelcomeInfo.Name = "txtWelcomeInfo";
            this.txtWelcomeInfo.ReadOnly = true;
            this.txtWelcomeInfo.Size = new System.Drawing.Size(483, 162);
            this.txtWelcomeInfo.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(407, 28);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(268, 314);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(143, 38);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawl
            // 
            this.btnWithdrawl.Enabled = false;
            this.btnWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawl.Location = new System.Drawing.Point(268, 398);
            this.btnWithdrawl.Name = "btnWithdrawl";
            this.btnWithdrawl.Size = new System.Drawing.Size(143, 38);
            this.btnWithdrawl.TabIndex = 6;
            this.btnWithdrawl.Text = "Withdrawal";
            this.btnWithdrawl.UseVisualStyleBackColor = true;
            this.btnWithdrawl.Click += new System.EventHandler(this.btnWithdrawl_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Enabled = false;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(169, 466);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 38);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmBankLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(579, 526);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnWithdrawl);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWelcomeInfo);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtAcctNum);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtWithdrawl);
            this.Controls.Add(this.lblWithdrawl);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblAcctNum);
            this.Name = "frmBankLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weyland Bank";
            this.Load += new System.EventHandler(this.frmBankLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcctNum;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdrawl;
        private System.Windows.Forms.TextBox txtWithdrawl;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtWelcomeInfo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrawl;
        private System.Windows.Forms.Button btnLogout;
    }
}

