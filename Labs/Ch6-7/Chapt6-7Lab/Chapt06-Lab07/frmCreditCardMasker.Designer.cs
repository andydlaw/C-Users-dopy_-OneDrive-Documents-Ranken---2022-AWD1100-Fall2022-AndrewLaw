namespace Chapt06_Lab07
{
    partial class frmCreditCardMasker
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
            this.btnMask = new System.Windows.Forms.Button();
            this.lblMasked = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMask
            // 
            this.btnMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMask.Location = new System.Drawing.Point(394, 16);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(107, 48);
            this.btnMask.TabIndex = 1;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // lblMasked
            // 
            this.lblMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasked.Location = new System.Drawing.Point(48, 85);
            this.lblMasked.Name = "lblMasked";
            this.lblMasked.Size = new System.Drawing.Size(314, 23);
            this.lblMasked.TabIndex = 2;
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCard.Location = new System.Drawing.Point(43, 25);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(265, 30);
            this.txtCreditCard.TabIndex = 0;
            this.txtCreditCard.TextChanged += new System.EventHandler(this.txtCreditCard_TextChanged);
            // 
            // frmCreditCardMasker
            // 
            this.AcceptButton = this.btnMask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 155);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.lblMasked);
            this.Controls.Add(this.btnMask);
            this.Name = "frmCreditCardMasker";
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMask;
        private System.Windows.Forms.Label lblMasked;
        private System.Windows.Forms.TextBox txtCreditCard;
    }
}

