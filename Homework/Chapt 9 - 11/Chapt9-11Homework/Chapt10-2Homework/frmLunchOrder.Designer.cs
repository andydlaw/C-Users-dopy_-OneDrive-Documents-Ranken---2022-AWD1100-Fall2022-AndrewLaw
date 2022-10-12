namespace Chapt10_2Homework
{
    partial class frmLunchOrder
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
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.ckFF = new System.Windows.Forms.CheckBox();
            this.ckKMM = new System.Windows.Forms.CheckBox();
            this.ckLTO = new System.Windows.Forms.CheckBox();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePercentage = new System.Windows.Forms.Button();
            this.grpMainCourse.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            this.grpOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.radSalad);
            this.grpMainCourse.Controls.Add(this.radPizza);
            this.grpMainCourse.Controls.Add(this.radHamburger);
            this.grpMainCourse.Location = new System.Drawing.Point(32, 28);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Size = new System.Drawing.Size(255, 156);
            this.grpMainCourse.TabIndex = 4;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Course";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(37, 117);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(105, 20);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(37, 79);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(101, 20);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(37, 39);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(137, 20);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.ckFF);
            this.grpAddOn.Controls.Add(this.ckKMM);
            this.grpAddOn.Controls.Add(this.ckLTO);
            this.grpAddOn.Location = new System.Drawing.Point(373, 28);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(275, 156);
            this.grpAddOn.TabIndex = 3;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-on Item ($0.75/each)";
            // 
            // ckFF
            // 
            this.ckFF.AutoSize = true;
            this.ckFF.Location = new System.Drawing.Point(46, 118);
            this.ckFF.Name = "ckFF";
            this.ckFF.Size = new System.Drawing.Size(103, 20);
            this.ckFF.TabIndex = 2;
            this.ckFF.Text = "French Fries";
            this.ckFF.UseVisualStyleBackColor = true;
            this.ckFF.CheckedChanged += new System.EventHandler(this.ckFF_CheckedChanged);
            // 
            // ckKMM
            // 
            this.ckKMM.AutoSize = true;
            this.ckKMM.Location = new System.Drawing.Point(46, 80);
            this.ckKMM.Name = "ckKMM";
            this.ckKMM.Size = new System.Drawing.Size(197, 20);
            this.ckKMM.TabIndex = 1;
            this.ckKMM.Text = "Ketchup, mustard, and mayo";
            this.ckKMM.UseVisualStyleBackColor = true;
            this.ckKMM.CheckedChanged += new System.EventHandler(this.ckKMM_CheckedChanged);
            // 
            // ckLTO
            // 
            this.ckLTO.AutoSize = true;
            this.ckLTO.Location = new System.Drawing.Point(46, 40);
            this.ckLTO.Name = "ckLTO";
            this.ckLTO.Size = new System.Drawing.Size(191, 20);
            this.ckLTO.TabIndex = 0;
            this.ckLTO.Text = "Lettuce, tomato, and onions";
            this.ckLTO.UseVisualStyleBackColor = true;
            this.ckLTO.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpOrderTotal.Controls.Add(this.txtTax);
            this.grpOrderTotal.Controls.Add(this.txtSubtotal);
            this.grpOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpOrderTotal.Controls.Add(this.lblTax);
            this.grpOrderTotal.Controls.Add(this.lblSubtotal);
            this.grpOrderTotal.Location = new System.Drawing.Point(32, 238);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(350, 156);
            this.grpOrderTotal.TabIndex = 5;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(115, 97);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(116, 22);
            this.txtOrderTotal.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(115, 64);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(116, 22);
            this.txtTax.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(115, 30);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(116, 22);
            this.txtSubtotal.TabIndex = 0;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(34, 100);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(78, 16);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(34, 67);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(80, 16);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(34, 33);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(449, 268);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(161, 35);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(449, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangePercentage
            // 
            this.btnChangePercentage.Location = new System.Drawing.Point(449, 209);
            this.btnChangePercentage.Name = "btnChangePercentage";
            this.btnChangePercentage.Size = new System.Drawing.Size(161, 33);
            this.btnChangePercentage.TabIndex = 1;
            this.btnChangePercentage.Text = "Change Percentage";
            this.btnChangePercentage.UseVisualStyleBackColor = true;
            this.btnChangePercentage.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 419);
            this.Controls.Add(this.btnChangePercentage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.CheckBox ckFF;
        private System.Windows.Forms.CheckBox ckKMM;
        private System.Windows.Forms.CheckBox ckLTO;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnChangePercentage;
    }
}

