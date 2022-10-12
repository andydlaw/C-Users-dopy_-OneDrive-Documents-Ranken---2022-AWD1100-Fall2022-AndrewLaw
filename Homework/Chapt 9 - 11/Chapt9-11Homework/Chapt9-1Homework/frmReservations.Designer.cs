namespace Chapt9_1Homework
{
    partial class frmReservations
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
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblNumNights = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.txtArriveDate = new System.Windows.Forms.TextBox();
            this.txtDepartDate = new System.Windows.Forms.TextBox();
            this.txtNumOfNights = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(84, 27);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(80, 16);
            this.lblArrival.TabIndex = 7;
            this.lblArrival.Text = "Arrival Date:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(62, 79);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(102, 16);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Departure Date:";
            // 
            // lblNumNights
            // 
            this.lblNumNights.AutoSize = true;
            this.lblNumNights.Location = new System.Drawing.Point(51, 127);
            this.lblNumNights.Name = "lblNumNights";
            this.lblNumNights.Size = new System.Drawing.Size(113, 16);
            this.lblNumNights.TabIndex = 9;
            this.lblNumNights.Text = "Number of Nights:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(89, 172);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(75, 16);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Location = new System.Drawing.Point(35, 219);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(129, 16);
            this.lblAvgPrice.TabIndex = 11;
            this.lblAvgPrice.Text = "Avg. Price Per Night:";
            // 
            // txtArriveDate
            // 
            this.txtArriveDate.Location = new System.Drawing.Point(179, 24);
            this.txtArriveDate.Name = "txtArriveDate";
            this.txtArriveDate.Size = new System.Drawing.Size(100, 22);
            this.txtArriveDate.TabIndex = 0;
            // 
            // txtDepartDate
            // 
            this.txtDepartDate.Location = new System.Drawing.Point(179, 76);
            this.txtDepartDate.Name = "txtDepartDate";
            this.txtDepartDate.Size = new System.Drawing.Size(100, 22);
            this.txtDepartDate.TabIndex = 1;
            // 
            // txtNumOfNights
            // 
            this.txtNumOfNights.Location = new System.Drawing.Point(179, 124);
            this.txtNumOfNights.Name = "txtNumOfNights";
            this.txtNumOfNights.ReadOnly = true;
            this.txtNumOfNights.Size = new System.Drawing.Size(100, 22);
            this.txtNumOfNights.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(179, 169);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPrice.TabIndex = 3;
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(179, 216);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.ReadOnly = true;
            this.txtAvgPrice.Size = new System.Drawing.Size(100, 22);
            this.txtAvgPrice.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 272);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(192, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReservations
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(326, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAvgPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNumOfNights);
            this.Controls.Add(this.txtDepartDate);
            this.Controls.Add(this.txtArriveDate);
            this.Controls.Add(this.lblAvgPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblNumNights);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblArrival);
            this.Name = "frmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblNumNights;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.TextBox txtArriveDate;
        private System.Windows.Forms.TextBox txtDepartDate;
        private System.Windows.Forms.TextBox txtNumOfNights;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

