namespace HOT05_01
{
    partial class frmCardDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardDesigner));
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.ckbxEnvelope = new System.Windows.Forms.CheckBox();
            this.ckbxStamp = new System.Windows.Forms.CheckBox();
            this.ckbxCustomMessage = new System.Windows.Forms.CheckBox();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            this.cbxOccasion = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnSplashScreen = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.imgCardBackgroundDigital = new System.Windows.Forms.PictureBox();
            this.imgCardBackgroundOperator = new System.Windows.Forms.PictureBox();
            this.imgCardBackgroundEDC = new System.Windows.Forms.PictureBox();
            this.imgCongrats = new System.Windows.Forms.PictureBox();
            this.imgThankYou = new System.Windows.Forms.PictureBox();
            this.imgGetWell = new System.Windows.Forms.PictureBox();
            this.lblCustomMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardBackgroundDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardBackgroundOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardBackgroundEDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCongrats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThankYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGetWell)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOccasion
            // 
            this.lblOccasion.AutoSize = true;
            this.lblOccasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(45, 39);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(88, 20);
            this.lblOccasion.TabIndex = 8;
            this.lblOccasion.Text = "Occasion";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(45, 80);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(51, 20);
            this.lblStyle.TabIndex = 9;
            this.lblStyle.Text = "Style";
            // 
            // ckbxEnvelope
            // 
            this.ckbxEnvelope.AutoSize = true;
            this.ckbxEnvelope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxEnvelope.Location = new System.Drawing.Point(49, 132);
            this.ckbxEnvelope.Name = "ckbxEnvelope";
            this.ckbxEnvelope.Size = new System.Drawing.Size(172, 24);
            this.ckbxEnvelope.TabIndex = 2;
            this.ckbxEnvelope.Text = "Envelope ($0.25)";
            this.ckbxEnvelope.UseVisualStyleBackColor = true;
            // 
            // ckbxStamp
            // 
            this.ckbxStamp.AutoSize = true;
            this.ckbxStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxStamp.Location = new System.Drawing.Point(49, 167);
            this.ckbxStamp.Name = "ckbxStamp";
            this.ckbxStamp.Size = new System.Drawing.Size(149, 24);
            this.ckbxStamp.TabIndex = 3;
            this.ckbxStamp.Text = "Stamp ($0.50)";
            this.ckbxStamp.UseVisualStyleBackColor = true;
            // 
            // ckbxCustomMessage
            // 
            this.ckbxCustomMessage.AutoSize = true;
            this.ckbxCustomMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCustomMessage.Location = new System.Drawing.Point(49, 202);
            this.ckbxCustomMessage.Name = "ckbxCustomMessage";
            this.ckbxCustomMessage.Size = new System.Drawing.Size(241, 24);
            this.ckbxCustomMessage.TabIndex = 4;
            this.ckbxCustomMessage.Text = "Custom Message ($0.25)";
            this.ckbxCustomMessage.UseVisualStyleBackColor = true;
            this.ckbxCustomMessage.CheckedChanged += new System.EventHandler(this.ckbxCustomMessage_CheckedChanged);
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.AcceptsReturn = true;
            this.txtCustomMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomMessage.Location = new System.Drawing.Point(49, 245);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.ReadOnly = true;
            this.txtCustomMessage.Size = new System.Drawing.Size(306, 151);
            this.txtCustomMessage.TabIndex = 5;
            // 
            // cbxOccasion
            // 
            this.cbxOccasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOccasion.FormattingEnabled = true;
            this.cbxOccasion.Items.AddRange(new object[] {
            "",
            "Thank You",
            "Get Well",
            "Congrats"});
            this.cbxOccasion.Location = new System.Drawing.Point(159, 36);
            this.cbxOccasion.Name = "cbxOccasion";
            this.cbxOccasion.Size = new System.Drawing.Size(196, 28);
            this.cbxOccasion.TabIndex = 0;
            // 
            // cbxStyle
            // 
            this.cbxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Items.AddRange(new object[] {
            "",
            "Digital ($2.50)",
            "Operator ($1.50)",
            "EDC ($3.50)"});
            this.cbxStyle.Location = new System.Drawing.Point(159, 77);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(196, 28);
            this.cbxStyle.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(45, 414);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(60, 20);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost: ";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(104, 414);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCost.TabIndex = 11;
            // 
            // btnSplashScreen
            // 
            this.btnSplashScreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSplashScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashScreen.Location = new System.Drawing.Point(389, 388);
            this.btnSplashScreen.Name = "btnSplashScreen";
            this.btnSplashScreen.Size = new System.Drawing.Size(219, 46);
            this.btnSplashScreen.TabIndex = 6;
            this.btnSplashScreen.Text = "Splash Screen";
            this.btnSplashScreen.UseVisualStyleBackColor = true;
            this.btnSplashScreen.Click += new System.EventHandler(this.btnSplashScreen_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(637, 388);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 46);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgCardBackgroundDigital
            // 
            this.imgCardBackgroundDigital.Image = ((System.Drawing.Image)(resources.GetObject("imgCardBackgroundDigital.Image")));
            this.imgCardBackgroundDigital.Location = new System.Drawing.Point(389, 25);
            this.imgCardBackgroundDigital.Name = "imgCardBackgroundDigital";
            this.imgCardBackgroundDigital.Size = new System.Drawing.Size(377, 328);
            this.imgCardBackgroundDigital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCardBackgroundDigital.TabIndex = 12;
            this.imgCardBackgroundDigital.TabStop = false;
            this.imgCardBackgroundDigital.Visible = false;
            // 
            // imgCardBackgroundOperator
            // 
            this.imgCardBackgroundOperator.Image = ((System.Drawing.Image)(resources.GetObject("imgCardBackgroundOperator.Image")));
            this.imgCardBackgroundOperator.Location = new System.Drawing.Point(389, 25);
            this.imgCardBackgroundOperator.Name = "imgCardBackgroundOperator";
            this.imgCardBackgroundOperator.Size = new System.Drawing.Size(377, 328);
            this.imgCardBackgroundOperator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCardBackgroundOperator.TabIndex = 14;
            this.imgCardBackgroundOperator.TabStop = false;
            this.imgCardBackgroundOperator.Visible = false;
            // 
            // imgCardBackgroundEDC
            // 
            this.imgCardBackgroundEDC.Image = ((System.Drawing.Image)(resources.GetObject("imgCardBackgroundEDC.Image")));
            this.imgCardBackgroundEDC.Location = new System.Drawing.Point(389, 25);
            this.imgCardBackgroundEDC.Name = "imgCardBackgroundEDC";
            this.imgCardBackgroundEDC.Size = new System.Drawing.Size(377, 328);
            this.imgCardBackgroundEDC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCardBackgroundEDC.TabIndex = 15;
            this.imgCardBackgroundEDC.TabStop = false;
            this.imgCardBackgroundEDC.Visible = false;
            // 
            // imgCongrats
            // 
            this.imgCongrats.BackColor = System.Drawing.Color.Transparent;
            this.imgCongrats.Image = ((System.Drawing.Image)(resources.GetObject("imgCongrats.Image")));
            this.imgCongrats.Location = new System.Drawing.Point(406, 39);
            this.imgCongrats.Name = "imgCongrats";
            this.imgCongrats.Size = new System.Drawing.Size(160, 35);
            this.imgCongrats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCongrats.TabIndex = 16;
            this.imgCongrats.TabStop = false;
            this.imgCongrats.Visible = false;
            // 
            // imgThankYou
            // 
            this.imgThankYou.BackColor = System.Drawing.Color.Transparent;
            this.imgThankYou.Image = ((System.Drawing.Image)(resources.GetObject("imgThankYou.Image")));
            this.imgThankYou.Location = new System.Drawing.Point(406, 39);
            this.imgThankYou.Name = "imgThankYou";
            this.imgThankYou.Size = new System.Drawing.Size(160, 35);
            this.imgThankYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgThankYou.TabIndex = 17;
            this.imgThankYou.TabStop = false;
            this.imgThankYou.Visible = false;
            // 
            // imgGetWell
            // 
            this.imgGetWell.BackColor = System.Drawing.Color.Transparent;
            this.imgGetWell.Image = ((System.Drawing.Image)(resources.GetObject("imgGetWell.Image")));
            this.imgGetWell.Location = new System.Drawing.Point(406, 39);
            this.imgGetWell.Name = "imgGetWell";
            this.imgGetWell.Size = new System.Drawing.Size(175, 39);
            this.imgGetWell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGetWell.TabIndex = 18;
            this.imgGetWell.TabStop = false;
            this.imgGetWell.Visible = false;
            // 
            // lblCustomMessage
            // 
            this.lblCustomMessage.AutoSize = true;
            this.lblCustomMessage.BackColor = System.Drawing.Color.Black;
            this.lblCustomMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomMessage.ForeColor = System.Drawing.Color.White;
            this.lblCustomMessage.Location = new System.Drawing.Point(418, 215);
            this.lblCustomMessage.Name = "lblCustomMessage";
            this.lblCustomMessage.Size = new System.Drawing.Size(0, 16);
            this.lblCustomMessage.TabIndex = 19;
            this.lblCustomMessage.Visible = false;
            // 
            // frmCardDesigner
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSplashScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustomMessage);
            this.Controls.Add(this.imgGetWell);
            this.Controls.Add(this.imgThankYou);
            this.Controls.Add(this.imgCongrats);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSplashScreen);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.cbxOccasion);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.ckbxCustomMessage);
            this.Controls.Add(this.ckbxStamp);
            this.Controls.Add(this.ckbxEnvelope);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Controls.Add(this.imgCardBackgroundDigital);
            this.Controls.Add(this.imgCardBackgroundOperator);
            this.Controls.Add(this.imgCardBackgroundEDC);
            this.Name = "frmCardDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            ((System.ComponentModel.ISupportInitialize)(this.imgCardBackgroundDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardBackgroundOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardBackgroundEDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCongrats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThankYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGetWell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.CheckBox ckbxEnvelope;
        private System.Windows.Forms.CheckBox ckbxStamp;
        private System.Windows.Forms.CheckBox ckbxCustomMessage;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.ComboBox cbxOccasion;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox imgCardBackgroundDigital;
        private System.Windows.Forms.PictureBox imgCardBackgroundOperator;
        private System.Windows.Forms.PictureBox imgCardBackgroundEDC;
        private System.Windows.Forms.PictureBox imgCongrats;
        private System.Windows.Forms.PictureBox imgThankYou;
        private System.Windows.Forms.PictureBox imgGetWell;
        private System.Windows.Forms.Label lblCustomMessage;
    }
}

