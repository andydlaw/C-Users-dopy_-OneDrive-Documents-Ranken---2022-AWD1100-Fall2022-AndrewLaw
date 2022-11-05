namespace Chapt12_Lab03
{
    partial class frmStatement
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
            this.txtWelcomeInfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWelcomeInfo
            // 
            this.txtWelcomeInfo.AcceptsReturn = true;
            this.txtWelcomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcomeInfo.Location = new System.Drawing.Point(24, 26);
            this.txtWelcomeInfo.Multiline = true;
            this.txtWelcomeInfo.Name = "txtWelcomeInfo";
            this.txtWelcomeInfo.ReadOnly = true;
            this.txtWelcomeInfo.Size = new System.Drawing.Size(483, 308);
            this.txtWelcomeInfo.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWelcomeInfo);
            this.Name = "frmStatement";
            this.Text = "Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWelcomeInfo;
        private System.Windows.Forms.Button button1;
    }
}