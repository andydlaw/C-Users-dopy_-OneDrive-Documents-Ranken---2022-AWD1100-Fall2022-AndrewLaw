namespace Chapt07_Lab08
{
    partial class frmCustomDesk
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
            this.lblTypeOfWood = new System.Windows.Forms.Label();
            this.lblNumOfDrawers = new System.Windows.Forms.Label();
            this.lblWood = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCostOfDrawers = new System.Windows.Forms.Label();
            this.lblCostOfWood = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.txtTypeOfWood = new System.Windows.Forms.TextBox();
            this.txtNumOfDrawers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTypeOfWood
            // 
            this.lblTypeOfWood.AutoSize = true;
            this.lblTypeOfWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfWood.Location = new System.Drawing.Point(32, 26);
            this.lblTypeOfWood.Name = "lblTypeOfWood";
            this.lblTypeOfWood.Size = new System.Drawing.Size(148, 25);
            this.lblTypeOfWood.TabIndex = 3;
            this.lblTypeOfWood.Text = "Type of Wood";
            // 
            // lblNumOfDrawers
            // 
            this.lblNumOfDrawers.AutoSize = true;
            this.lblNumOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfDrawers.Location = new System.Drawing.Point(391, 26);
            this.lblNumOfDrawers.Name = "lblNumOfDrawers";
            this.lblNumOfDrawers.Size = new System.Drawing.Size(196, 25);
            this.lblNumOfDrawers.TabIndex = 4;
            this.lblNumOfDrawers.Text = "Number of Drawers";
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWood.Location = new System.Drawing.Point(32, 205);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(144, 25);
            this.lblWood.TabIndex = 5;
            this.lblWood.Text = "Cost of Wood";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawers.Location = new System.Drawing.Point(253, 205);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(166, 25);
            this.lblDrawers.TabIndex = 6;
            this.lblDrawers.Text = "Cost of Drawers";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(490, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(490, 237);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 25);
            this.lblTotalCost.TabIndex = 10;
            // 
            // lblCostOfDrawers
            // 
            this.lblCostOfDrawers.AutoSize = true;
            this.lblCostOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostOfDrawers.Location = new System.Drawing.Point(253, 237);
            this.lblCostOfDrawers.Name = "lblCostOfDrawers";
            this.lblCostOfDrawers.Size = new System.Drawing.Size(0, 25);
            this.lblCostOfDrawers.TabIndex = 9;
            // 
            // lblCostOfWood
            // 
            this.lblCostOfWood.AutoSize = true;
            this.lblCostOfWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostOfWood.Location = new System.Drawing.Point(32, 237);
            this.lblCostOfWood.Name = "lblCostOfWood";
            this.lblCostOfWood.Size = new System.Drawing.Size(0, 25);
            this.lblCostOfWood.TabIndex = 8;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.Location = new System.Drawing.Point(37, 127);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(143, 47);
            this.btnEstimate.TabIndex = 2;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // txtTypeOfWood
            // 
            this.txtTypeOfWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeOfWood.Location = new System.Drawing.Point(37, 69);
            this.txtTypeOfWood.Name = "txtTypeOfWood";
            this.txtTypeOfWood.Size = new System.Drawing.Size(139, 30);
            this.txtTypeOfWood.TabIndex = 0;
            this.txtTypeOfWood.Tag = "Type of wood";
            // 
            // txtNumOfDrawers
            // 
            this.txtNumOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfDrawers.Location = new System.Drawing.Point(396, 69);
            this.txtNumOfDrawers.Name = "txtNumOfDrawers";
            this.txtNumOfDrawers.Size = new System.Drawing.Size(191, 30);
            this.txtNumOfDrawers.TabIndex = 1;
            this.txtNumOfDrawers.Tag = "Drawers";
            // 
            // frmCustomDesk
            // 
            this.AcceptButton = this.btnEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 317);
            this.Controls.Add(this.txtNumOfDrawers);
            this.Controls.Add(this.txtTypeOfWood);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.lblCostOfWood);
            this.Controls.Add(this.lblCostOfDrawers);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.lblWood);
            this.Controls.Add(this.lblNumOfDrawers);
            this.Controls.Add(this.lblTypeOfWood);
            this.Name = "frmCustomDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Custom Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeOfWood;
        private System.Windows.Forms.Label lblNumOfDrawers;
        private System.Windows.Forms.Label lblWood;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCostOfDrawers;
        private System.Windows.Forms.Label lblCostOfWood;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.TextBox txtTypeOfWood;
        private System.Windows.Forms.TextBox txtNumOfDrawers;
    }
}

