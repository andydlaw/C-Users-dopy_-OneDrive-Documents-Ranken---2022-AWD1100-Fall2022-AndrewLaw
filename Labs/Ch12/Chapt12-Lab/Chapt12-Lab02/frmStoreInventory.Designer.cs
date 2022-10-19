namespace Chapt12_Lab02
{
    partial class frmStoreInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchUPC = new System.Windows.Forms.TextBox();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblStorePrice = new System.Windows.Forms.Label();
            this.lblCostPerCase = new System.Windows.Forms.Label();
            this.lblUnitPerCase = new System.Windows.Forms.Label();
            this.lblDistributor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChangePriceError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewPriceAccessKey = new System.Windows.Forms.TextBox();
            this.txtChangeNewPrice = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDeleteItemError = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDeleteItemAccessKey = new System.Windows.Forms.TextBox();
            this.txtDeleteItemVerifyUPC = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAddNewItemError = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddItemDistributor = new System.Windows.Forms.TextBox();
            this.txtAddItemUnitPerCase = new System.Windows.Forms.TextBox();
            this.txtAddItemCostPerCase = new System.Windows.Forms.TextBox();
            this.txtAddItemAccessKey = new System.Windows.Forms.TextBox();
            this.txtAddItemStorePrice = new System.Windows.Forms.TextBox();
            this.txtAddItemUPC = new System.Windows.Forms.TextBox();
            this.txtAddItemName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchUPC = new System.Windows.Forms.Button();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.lblUPCOutput = new System.Windows.Forms.Label();
            this.lblStorePriceOutput = new System.Windows.Forms.Label();
            this.lblDistributorOutput = new System.Windows.Forms.Label();
            this.lblCostPerCaseOutput = new System.Windows.Forms.Label();
            this.lblUnitPerCaseOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search by UPC";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(29, 61);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchName.TabIndex = 0;
            // 
            // txtSearchUPC
            // 
            this.txtSearchUPC.Location = new System.Drawing.Point(395, 61);
            this.txtSearchUPC.Name = "txtSearchUPC";
            this.txtSearchUPC.Size = new System.Drawing.Size(100, 22);
            this.txtSearchUPC.TabIndex = 2;
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(26, 129);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(38, 16);
            this.lblUPC.TabIndex = 8;
            this.lblUPC.Text = "UPC:";
            // 
            // lblStorePrice
            // 
            this.lblStorePrice.AutoSize = true;
            this.lblStorePrice.Location = new System.Drawing.Point(26, 155);
            this.lblStorePrice.Name = "lblStorePrice";
            this.lblStorePrice.Size = new System.Drawing.Size(76, 16);
            this.lblStorePrice.TabIndex = 10;
            this.lblStorePrice.Text = "Store Price:";
            // 
            // lblCostPerCase
            // 
            this.lblCostPerCase.AutoSize = true;
            this.lblCostPerCase.Location = new System.Drawing.Point(392, 102);
            this.lblCostPerCase.Name = "lblCostPerCase";
            this.lblCostPerCase.Size = new System.Drawing.Size(96, 16);
            this.lblCostPerCase.TabIndex = 12;
            this.lblCostPerCase.Text = "Cost Per Case:";
            // 
            // lblUnitPerCase
            // 
            this.lblUnitPerCase.AutoSize = true;
            this.lblUnitPerCase.Location = new System.Drawing.Point(392, 129);
            this.lblUnitPerCase.Name = "lblUnitPerCase";
            this.lblUnitPerCase.Size = new System.Drawing.Size(98, 16);
            this.lblUnitPerCase.TabIndex = 15;
            this.lblUnitPerCase.Text = "Units per Case:";
            // 
            // lblDistributor
            // 
            this.lblDistributor.AutoSize = true;
            this.lblDistributor.Location = new System.Drawing.Point(392, 155);
            this.lblDistributor.Name = "lblDistributor";
            this.lblDistributor.Size = new System.Drawing.Size(70, 16);
            this.lblDistributor.TabIndex = 16;
            this.lblDistributor.Text = "Distributor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChangePriceError);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNewPriceAccessKey);
            this.groupBox1.Controls.Add(this.txtChangeNewPrice);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(31, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 224);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Store Price";
            // 
            // lblChangePriceError
            // 
            this.lblChangePriceError.AutoSize = true;
            this.lblChangePriceError.ForeColor = System.Drawing.Color.Red;
            this.lblChangePriceError.Location = new System.Drawing.Point(62, 194);
            this.lblChangePriceError.Name = "lblChangePriceError";
            this.lblChangePriceError.Size = new System.Drawing.Size(132, 16);
            this.lblChangePriceError.TabIndex = 5;
            this.lblChangePriceError.Text = "Access Key Incorrect";
            this.lblChangePriceError.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Access Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "New Price:";
            // 
            // txtNewPriceAccessKey
            // 
            this.txtNewPriceAccessKey.Location = new System.Drawing.Point(103, 101);
            this.txtNewPriceAccessKey.Name = "txtNewPriceAccessKey";
            this.txtNewPriceAccessKey.Size = new System.Drawing.Size(100, 22);
            this.txtNewPriceAccessKey.TabIndex = 1;
            // 
            // txtChangeNewPrice
            // 
            this.txtChangeNewPrice.Location = new System.Drawing.Point(103, 56);
            this.txtChangeNewPrice.Name = "txtChangeNewPrice";
            this.txtChangeNewPrice.Size = new System.Drawing.Size(100, 22);
            this.txtChangeNewPrice.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update Price";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDeleteItemError);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDeleteItemAccessKey);
            this.groupBox2.Controls.Add(this.txtDeleteItemVerifyUPC);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(337, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 224);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Item";
            // 
            // lblDeleteItemError
            // 
            this.lblDeleteItemError.AutoSize = true;
            this.lblDeleteItemError.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteItemError.Location = new System.Drawing.Point(69, 194);
            this.lblDeleteItemError.Name = "lblDeleteItemError";
            this.lblDeleteItemError.Size = new System.Drawing.Size(132, 16);
            this.lblDeleteItemError.TabIndex = 5;
            this.lblDeleteItemError.Text = "Access Key Incorrect";
            this.lblDeleteItemError.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Access Key:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Verify UPC:";
            // 
            // txtDeleteItemAccessKey
            // 
            this.txtDeleteItemAccessKey.Location = new System.Drawing.Point(117, 101);
            this.txtDeleteItemAccessKey.Name = "txtDeleteItemAccessKey";
            this.txtDeleteItemAccessKey.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteItemAccessKey.TabIndex = 1;
            // 
            // txtDeleteItemVerifyUPC
            // 
            this.txtDeleteItemVerifyUPC.Location = new System.Drawing.Point(117, 56);
            this.txtDeleteItemVerifyUPC.Name = "txtDeleteItemVerifyUPC";
            this.txtDeleteItemVerifyUPC.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteItemVerifyUPC.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete Item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAddNewItemError);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtAddItemDistributor);
            this.groupBox3.Controls.Add(this.txtAddItemUnitPerCase);
            this.groupBox3.Controls.Add(this.txtAddItemCostPerCase);
            this.groupBox3.Controls.Add(this.txtAddItemAccessKey);
            this.groupBox3.Controls.Add(this.txtAddItemStorePrice);
            this.groupBox3.Controls.Add(this.txtAddItemUPC);
            this.groupBox3.Controls.Add(this.txtAddItemName);
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Location = new System.Drawing.Point(29, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 276);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Item";
            // 
            // lblAddNewItemError
            // 
            this.lblAddNewItemError.AutoSize = true;
            this.lblAddNewItemError.ForeColor = System.Drawing.Color.Red;
            this.lblAddNewItemError.Location = new System.Drawing.Point(64, 243);
            this.lblAddNewItemError.Name = "lblAddNewItemError";
            this.lblAddNewItemError.Size = new System.Drawing.Size(132, 16);
            this.lblAddNewItemError.TabIndex = 12;
            this.lblAddNewItemError.Text = "Access Key Incorrect";
            this.lblAddNewItemError.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Access Key:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Store Price:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "UPC:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Distributor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Units Per Case";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Cost Per Case";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Name:";
            // 
            // txtAddItemDistributor
            // 
            this.txtAddItemDistributor.Location = new System.Drawing.Point(361, 151);
            this.txtAddItemDistributor.Name = "txtAddItemDistributor";
            this.txtAddItemDistributor.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemDistributor.TabIndex = 5;
            // 
            // txtAddItemUnitPerCase
            // 
            this.txtAddItemUnitPerCase.Location = new System.Drawing.Point(361, 96);
            this.txtAddItemUnitPerCase.Name = "txtAddItemUnitPerCase";
            this.txtAddItemUnitPerCase.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemUnitPerCase.TabIndex = 4;
            // 
            // txtAddItemCostPerCase
            // 
            this.txtAddItemCostPerCase.Location = new System.Drawing.Point(362, 40);
            this.txtAddItemCostPerCase.Name = "txtAddItemCostPerCase";
            this.txtAddItemCostPerCase.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemCostPerCase.TabIndex = 3;
            // 
            // txtAddItemAccessKey
            // 
            this.txtAddItemAccessKey.Location = new System.Drawing.Point(118, 204);
            this.txtAddItemAccessKey.Name = "txtAddItemAccessKey";
            this.txtAddItemAccessKey.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemAccessKey.TabIndex = 6;
            // 
            // txtAddItemStorePrice
            // 
            this.txtAddItemStorePrice.Location = new System.Drawing.Point(118, 151);
            this.txtAddItemStorePrice.Name = "txtAddItemStorePrice";
            this.txtAddItemStorePrice.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemStorePrice.TabIndex = 2;
            // 
            // txtAddItemUPC
            // 
            this.txtAddItemUPC.Location = new System.Drawing.Point(118, 96);
            this.txtAddItemUPC.Name = "txtAddItemUPC";
            this.txtAddItemUPC.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemUPC.TabIndex = 1;
            // 
            // txtAddItemName
            // 
            this.txtAddItemName.Location = new System.Drawing.Point(118, 40);
            this.txtAddItemName.Name = "txtAddItemName";
            this.txtAddItemName.Size = new System.Drawing.Size(100, 22);
            this.txtAddItemName.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(384, 213);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(82, 31);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(172, 61);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 28);
            this.btnSearchName.TabIndex = 1;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchUPC
            // 
            this.btnSearchUPC.Location = new System.Drawing.Point(537, 61);
            this.btnSearchUPC.Name = "btnSearchUPC";
            this.btnSearchUPC.Size = new System.Drawing.Size(75, 28);
            this.btnSearchUPC.TabIndex = 3;
            this.btnSearchUPC.Text = "Search";
            this.btnSearchUPC.UseVisualStyleBackColor = true;
            this.btnSearchUPC.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.AutoSize = true;
            this.lblNameOutput.Location = new System.Drawing.Point(79, 102);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(0, 16);
            this.lblNameOutput.TabIndex = 7;
            // 
            // lblUPCOutput
            // 
            this.lblUPCOutput.AutoSize = true;
            this.lblUPCOutput.Location = new System.Drawing.Point(70, 129);
            this.lblUPCOutput.Name = "lblUPCOutput";
            this.lblUPCOutput.Size = new System.Drawing.Size(0, 16);
            this.lblUPCOutput.TabIndex = 9;
            // 
            // lblStorePriceOutput
            // 
            this.lblStorePriceOutput.AutoSize = true;
            this.lblStorePriceOutput.Location = new System.Drawing.Point(108, 155);
            this.lblStorePriceOutput.Name = "lblStorePriceOutput";
            this.lblStorePriceOutput.Size = new System.Drawing.Size(0, 16);
            this.lblStorePriceOutput.TabIndex = 11;
            // 
            // lblDistributorOutput
            // 
            this.lblDistributorOutput.AutoSize = true;
            this.lblDistributorOutput.Location = new System.Drawing.Point(468, 155);
            this.lblDistributorOutput.Name = "lblDistributorOutput";
            this.lblDistributorOutput.Size = new System.Drawing.Size(0, 16);
            this.lblDistributorOutput.TabIndex = 17;
            // 
            // lblCostPerCaseOutput
            // 
            this.lblCostPerCaseOutput.AutoSize = true;
            this.lblCostPerCaseOutput.Location = new System.Drawing.Point(494, 102);
            this.lblCostPerCaseOutput.Name = "lblCostPerCaseOutput";
            this.lblCostPerCaseOutput.Size = new System.Drawing.Size(0, 16);
            this.lblCostPerCaseOutput.TabIndex = 13;
            // 
            // lblUnitPerCaseOutput
            // 
            this.lblUnitPerCaseOutput.AutoSize = true;
            this.lblUnitPerCaseOutput.Location = new System.Drawing.Point(496, 129);
            this.lblUnitPerCaseOutput.Name = "lblUnitPerCaseOutput";
            this.lblUnitPerCaseOutput.Size = new System.Drawing.Size(0, 16);
            this.lblUnitPerCaseOutput.TabIndex = 14;
            // 
            // frmStoreInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.lblUnitPerCaseOutput);
            this.Controls.Add(this.lblCostPerCaseOutput);
            this.Controls.Add(this.lblDistributorOutput);
            this.Controls.Add(this.lblStorePriceOutput);
            this.Controls.Add(this.lblUPCOutput);
            this.Controls.Add(this.lblNameOutput);
            this.Controls.Add(this.btnSearchUPC);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDistributor);
            this.Controls.Add(this.lblUnitPerCase);
            this.Controls.Add(this.lblCostPerCase);
            this.Controls.Add(this.lblStorePrice);
            this.Controls.Add(this.lblUPC);
            this.Controls.Add(this.txtSearchUPC);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStoreInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Inventory and Price Inquiry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchUPC;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.Label lblStorePrice;
        private System.Windows.Forms.Label lblCostPerCase;
        private System.Windows.Forms.Label lblUnitPerCase;
        private System.Windows.Forms.Label lblDistributor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchUPC;
        private System.Windows.Forms.TextBox txtNewPriceAccessKey;
        private System.Windows.Forms.TextBox txtChangeNewPrice;
        private System.Windows.Forms.TextBox txtDeleteItemAccessKey;
        private System.Windows.Forms.TextBox txtDeleteItemVerifyUPC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddItemDistributor;
        private System.Windows.Forms.TextBox txtAddItemUnitPerCase;
        private System.Windows.Forms.TextBox txtAddItemCostPerCase;
        private System.Windows.Forms.TextBox txtAddItemAccessKey;
        private System.Windows.Forms.TextBox txtAddItemStorePrice;
        private System.Windows.Forms.TextBox txtAddItemUPC;
        private System.Windows.Forms.TextBox txtAddItemName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblChangePriceError;
        private System.Windows.Forms.Label lblDeleteItemError;
        private System.Windows.Forms.Label lblAddNewItemError;
        private System.Windows.Forms.Label lblNameOutput;
        private System.Windows.Forms.Label lblUPCOutput;
        private System.Windows.Forms.Label lblStorePriceOutput;
        private System.Windows.Forms.Label lblDistributorOutput;
        private System.Windows.Forms.Label lblCostPerCaseOutput;
        private System.Windows.Forms.Label lblUnitPerCaseOutput;
    }
}

