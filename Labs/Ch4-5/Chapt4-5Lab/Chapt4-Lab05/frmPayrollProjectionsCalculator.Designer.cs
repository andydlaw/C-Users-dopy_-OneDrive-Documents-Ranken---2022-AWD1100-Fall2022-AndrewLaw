namespace Chapt4_Lab05
{
    partial class frmPayrollProjectionsCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpEmployeeOne = new System.Windows.Forms.GroupBox();
            this.lblNameOne = new System.Windows.Forms.Label();
            this.lblSalaryOne = new System.Windows.Forms.Label();
            this.txtSalaryOne = new System.Windows.Forms.TextBox();
            this.txtNameOne = new System.Windows.Forms.TextBox();
            this.grpEmployeeTwo = new System.Windows.Forms.GroupBox();
            this.txtNameTwo = new System.Windows.Forms.TextBox();
            this.txtSalaryTwo = new System.Windows.Forms.TextBox();
            this.lblSalaryTwo = new System.Windows.Forms.Label();
            this.lblNameTwo = new System.Windows.Forms.Label();
            this.grpEmployeeThree = new System.Windows.Forms.GroupBox();
            this.txtNameThree = new System.Windows.Forms.TextBox();
            this.txtSalaryThree = new System.Windows.Forms.TextBox();
            this.lblSalaryThree = new System.Windows.Forms.Label();
            this.lblNameThree = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEmployeeOne = new System.Windows.Forms.Label();
            this.lblEmployeeTwo = new System.Windows.Forms.Label();
            this.lblEmployeeThree = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEmployeeOne.SuspendLayout();
            this.grpEmployeeTwo.SuspendLayout();
            this.grpEmployeeThree.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(61, 241);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(175, 40);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpEmployeeOne
            // 
            this.grpEmployeeOne.Controls.Add(this.txtNameOne);
            this.grpEmployeeOne.Controls.Add(this.txtSalaryOne);
            this.grpEmployeeOne.Controls.Add(this.lblSalaryOne);
            this.grpEmployeeOne.Controls.Add(this.lblNameOne);
            this.grpEmployeeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployeeOne.Location = new System.Drawing.Point(61, 30);
            this.grpEmployeeOne.Name = "grpEmployeeOne";
            this.grpEmployeeOne.Size = new System.Drawing.Size(207, 192);
            this.grpEmployeeOne.TabIndex = 0;
            this.grpEmployeeOne.TabStop = false;
            this.grpEmployeeOne.Text = "Employee 1";
            // 
            // lblNameOne
            // 
            this.lblNameOne.AutoSize = true;
            this.lblNameOne.Location = new System.Drawing.Point(6, 31);
            this.lblNameOne.Name = "lblNameOne";
            this.lblNameOne.Size = new System.Drawing.Size(68, 25);
            this.lblNameOne.TabIndex = 2;
            this.lblNameOne.Text = "Name";
            // 
            // lblSalaryOne
            // 
            this.lblSalaryOne.AutoSize = true;
            this.lblSalaryOne.Location = new System.Drawing.Point(6, 104);
            this.lblSalaryOne.Name = "lblSalaryOne";
            this.lblSalaryOne.Size = new System.Drawing.Size(74, 25);
            this.lblSalaryOne.TabIndex = 3;
            this.lblSalaryOne.Text = "Salary";
            // 
            // txtSalaryOne
            // 
            this.txtSalaryOne.Location = new System.Drawing.Point(11, 132);
            this.txtSalaryOne.Name = "txtSalaryOne";
            this.txtSalaryOne.Size = new System.Drawing.Size(164, 30);
            this.txtSalaryOne.TabIndex = 1;
            // 
            // txtNameOne
            // 
            this.txtNameOne.Location = new System.Drawing.Point(11, 59);
            this.txtNameOne.Name = "txtNameOne";
            this.txtNameOne.Size = new System.Drawing.Size(164, 30);
            this.txtNameOne.TabIndex = 0;
            // 
            // grpEmployeeTwo
            // 
            this.grpEmployeeTwo.Controls.Add(this.txtNameTwo);
            this.grpEmployeeTwo.Controls.Add(this.txtSalaryTwo);
            this.grpEmployeeTwo.Controls.Add(this.lblSalaryTwo);
            this.grpEmployeeTwo.Controls.Add(this.lblNameTwo);
            this.grpEmployeeTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployeeTwo.Location = new System.Drawing.Point(298, 30);
            this.grpEmployeeTwo.Name = "grpEmployeeTwo";
            this.grpEmployeeTwo.Size = new System.Drawing.Size(207, 192);
            this.grpEmployeeTwo.TabIndex = 1;
            this.grpEmployeeTwo.TabStop = false;
            this.grpEmployeeTwo.Text = "Employee 2";
            // 
            // txtNameTwo
            // 
            this.txtNameTwo.Location = new System.Drawing.Point(11, 59);
            this.txtNameTwo.Name = "txtNameTwo";
            this.txtNameTwo.Size = new System.Drawing.Size(164, 30);
            this.txtNameTwo.TabIndex = 0;
            // 
            // txtSalaryTwo
            // 
            this.txtSalaryTwo.Location = new System.Drawing.Point(11, 132);
            this.txtSalaryTwo.Name = "txtSalaryTwo";
            this.txtSalaryTwo.Size = new System.Drawing.Size(164, 30);
            this.txtSalaryTwo.TabIndex = 1;
            // 
            // lblSalaryTwo
            // 
            this.lblSalaryTwo.AutoSize = true;
            this.lblSalaryTwo.Location = new System.Drawing.Point(6, 104);
            this.lblSalaryTwo.Name = "lblSalaryTwo";
            this.lblSalaryTwo.Size = new System.Drawing.Size(74, 25);
            this.lblSalaryTwo.TabIndex = 3;
            this.lblSalaryTwo.Text = "Salary";
            // 
            // lblNameTwo
            // 
            this.lblNameTwo.AutoSize = true;
            this.lblNameTwo.Location = new System.Drawing.Point(6, 31);
            this.lblNameTwo.Name = "lblNameTwo";
            this.lblNameTwo.Size = new System.Drawing.Size(68, 25);
            this.lblNameTwo.TabIndex = 2;
            this.lblNameTwo.Text = "Name";
            // 
            // grpEmployeeThree
            // 
            this.grpEmployeeThree.Controls.Add(this.txtNameThree);
            this.grpEmployeeThree.Controls.Add(this.txtSalaryThree);
            this.grpEmployeeThree.Controls.Add(this.lblSalaryThree);
            this.grpEmployeeThree.Controls.Add(this.lblNameThree);
            this.grpEmployeeThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployeeThree.Location = new System.Drawing.Point(540, 30);
            this.grpEmployeeThree.Name = "grpEmployeeThree";
            this.grpEmployeeThree.Size = new System.Drawing.Size(207, 192);
            this.grpEmployeeThree.TabIndex = 2;
            this.grpEmployeeThree.TabStop = false;
            this.grpEmployeeThree.Text = "Employee 3";
            // 
            // txtNameThree
            // 
            this.txtNameThree.Location = new System.Drawing.Point(11, 59);
            this.txtNameThree.Name = "txtNameThree";
            this.txtNameThree.Size = new System.Drawing.Size(164, 30);
            this.txtNameThree.TabIndex = 0;
            // 
            // txtSalaryThree
            // 
            this.txtSalaryThree.Location = new System.Drawing.Point(11, 132);
            this.txtSalaryThree.Name = "txtSalaryThree";
            this.txtSalaryThree.Size = new System.Drawing.Size(164, 30);
            this.txtSalaryThree.TabIndex = 1;
            // 
            // lblSalaryThree
            // 
            this.lblSalaryThree.AutoSize = true;
            this.lblSalaryThree.Location = new System.Drawing.Point(6, 104);
            this.lblSalaryThree.Name = "lblSalaryThree";
            this.lblSalaryThree.Size = new System.Drawing.Size(74, 25);
            this.lblSalaryThree.TabIndex = 3;
            this.lblSalaryThree.Text = "Salary";
            // 
            // lblNameThree
            // 
            this.lblNameThree.AutoSize = true;
            this.lblNameThree.Location = new System.Drawing.Point(6, 31);
            this.lblNameThree.Name = "lblNameThree";
            this.lblNameThree.Size = new System.Drawing.Size(68, 25);
            this.lblNameThree.TabIndex = 2;
            this.lblNameThree.Text = "Name";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(58, 315);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(91, 152);
            this.lblYear.TabIndex = 6;
            // 
            // lblEmployeeOne
            // 
            this.lblEmployeeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeOne.Location = new System.Drawing.Point(164, 315);
            this.lblEmployeeOne.Name = "lblEmployeeOne";
            this.lblEmployeeOne.Size = new System.Drawing.Size(185, 152);
            this.lblEmployeeOne.TabIndex = 7;
            // 
            // lblEmployeeTwo
            // 
            this.lblEmployeeTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeTwo.Location = new System.Drawing.Point(376, 315);
            this.lblEmployeeTwo.Name = "lblEmployeeTwo";
            this.lblEmployeeTwo.Size = new System.Drawing.Size(185, 152);
            this.lblEmployeeTwo.TabIndex = 8;
            // 
            // lblEmployeeThree
            // 
            this.lblEmployeeThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeThree.Location = new System.Drawing.Point(593, 315);
            this.lblEmployeeThree.Name = "lblEmployeeThree";
            this.lblEmployeeThree.Size = new System.Drawing.Size(185, 152);
            this.lblEmployeeThree.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(309, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(540, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPayrollProjectionsCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEmployeeThree);
            this.Controls.Add(this.lblEmployeeTwo);
            this.Controls.Add(this.lblEmployeeOne);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.grpEmployeeThree);
            this.Controls.Add(this.grpEmployeeTwo);
            this.Controls.Add(this.grpEmployeeOne);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmPayrollProjectionsCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Projections";
            this.Load += new System.EventHandler(this.frmPayrollProjectionsCalculator_Load);
            this.grpEmployeeOne.ResumeLayout(false);
            this.grpEmployeeOne.PerformLayout();
            this.grpEmployeeTwo.ResumeLayout(false);
            this.grpEmployeeTwo.PerformLayout();
            this.grpEmployeeThree.ResumeLayout(false);
            this.grpEmployeeThree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpEmployeeOne;
        private System.Windows.Forms.TextBox txtNameOne;
        private System.Windows.Forms.TextBox txtSalaryOne;
        private System.Windows.Forms.Label lblSalaryOne;
        private System.Windows.Forms.Label lblNameOne;
        private System.Windows.Forms.GroupBox grpEmployeeTwo;
        private System.Windows.Forms.TextBox txtNameTwo;
        private System.Windows.Forms.TextBox txtSalaryTwo;
        private System.Windows.Forms.Label lblSalaryTwo;
        private System.Windows.Forms.Label lblNameTwo;
        private System.Windows.Forms.GroupBox grpEmployeeThree;
        private System.Windows.Forms.TextBox txtNameThree;
        private System.Windows.Forms.TextBox txtSalaryThree;
        private System.Windows.Forms.Label lblSalaryThree;
        private System.Windows.Forms.Label lblNameThree;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEmployeeOne;
        private System.Windows.Forms.Label lblEmployeeTwo;
        private System.Windows.Forms.Label lblEmployeeThree;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

