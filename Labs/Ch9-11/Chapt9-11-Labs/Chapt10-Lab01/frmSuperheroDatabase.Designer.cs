namespace Chapt10_Lab01
{
    partial class frmSuperheroDatabase
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBiography = new System.Windows.Forms.Label();
            this.lblAlterEgoOutput = new System.Windows.Forms.Label();
            this.lblWiki = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblAlterEgo = new System.Windows.Forms.Label();
            this.lblSuperHeroName = new System.Windows.Forms.Label();
            this.imgHeroImage = new System.Windows.Forms.PictureBox();
            this.cbxHero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(524, 563);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 34);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(326, 563);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBiography
            // 
            this.lblBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiography.Location = new System.Drawing.Point(54, 200);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(304, 307);
            this.lblBiography.TabIndex = 17;
            this.lblBiography.Text = "Bio";
            // 
            // lblAlterEgoOutput
            // 
            this.lblAlterEgoOutput.AutoSize = true;
            this.lblAlterEgoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterEgoOutput.Location = new System.Drawing.Point(142, 127);
            this.lblAlterEgoOutput.Name = "lblAlterEgoOutput";
            this.lblAlterEgoOutput.Size = new System.Drawing.Size(78, 20);
            this.lblAlterEgoOutput.TabIndex = 15;
            this.lblAlterEgoOutput.Text = "Alter Ego";
            // 
            // lblWiki
            // 
            this.lblWiki.AutoSize = true;
            this.lblWiki.Location = new System.Drawing.Point(12, 540);
            this.lblWiki.Name = "lblWiki";
            this.lblWiki.Size = new System.Drawing.Size(63, 16);
            this.lblWiki.TabIndex = 18;
            this.lblWiki.Text = "Wiki URL";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(53, 164);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(106, 22);
            this.lblBio.TabIndex = 16;
            this.lblBio.Text = "Biography:";
            // 
            // lblAlterEgo
            // 
            this.lblAlterEgo.AutoSize = true;
            this.lblAlterEgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterEgo.Location = new System.Drawing.Point(53, 127);
            this.lblAlterEgo.Name = "lblAlterEgo";
            this.lblAlterEgo.Size = new System.Drawing.Size(83, 20);
            this.lblAlterEgo.TabIndex = 14;
            this.lblAlterEgo.Text = "Alter Ego:";
            // 
            // lblSuperHeroName
            // 
            this.lblSuperHeroName.AutoSize = true;
            this.lblSuperHeroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperHeroName.Location = new System.Drawing.Point(52, 85);
            this.lblSuperHeroName.Name = "lblSuperHeroName";
            this.lblSuperHeroName.Size = new System.Drawing.Size(93, 32);
            this.lblSuperHeroName.TabIndex = 13;
            this.lblSuperHeroName.Text = "Name";
            // 
            // imgHeroImage
            // 
            this.imgHeroImage.Location = new System.Drawing.Point(381, 30);
            this.imgHeroImage.Name = "imgHeroImage";
            this.imgHeroImage.Size = new System.Drawing.Size(366, 513);
            this.imgHeroImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeroImage.TabIndex = 11;
            this.imgHeroImage.TabStop = false;
            // 
            // cbxHero
            // 
            this.cbxHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHero.FormattingEnabled = true;
            this.cbxHero.Location = new System.Drawing.Point(57, 30);
            this.cbxHero.Name = "cbxHero";
            this.cbxHero.Size = new System.Drawing.Size(226, 24);
            this.cbxHero.TabIndex = 9;
            this.cbxHero.SelectedIndexChanged += new System.EventHandler(this.cbxHero_SelectedIndexChanged);
            // 
            // frmSuperheroDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBiography);
            this.Controls.Add(this.lblAlterEgoOutput);
            this.Controls.Add(this.lblWiki);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblAlterEgo);
            this.Controls.Add(this.lblSuperHeroName);
            this.Controls.Add(this.imgHeroImage);
            this.Controls.Add(this.cbxHero);
            this.Name = "frmSuperheroDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 - Chapter 10-1 Lab Superhero Database";
            this.Load += new System.EventHandler(this.frmSuperheroDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.Label lblAlterEgoOutput;
        private System.Windows.Forms.Label lblWiki;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblAlterEgo;
        private System.Windows.Forms.Label lblSuperHeroName;
        private System.Windows.Forms.PictureBox imgHeroImage;
        private System.Windows.Forms.ComboBox cbxHero;
    }
}

