using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * LB2 StoreInventory (Group)
Create a GUI application for a warehouse.
●	The program has a pre-populated list of items
●	Each item must have a different UPC code
●	The program can track up to 20 UPC codes
●	The user can search for items
●	The user can add new items
●	The user can update the price of items
●	The user can delete items

 * 
 */

namespace Chapt12_Lab02
{
    public partial class frmStoreInventory : Form
    {
        public frmStoreInventory()
        {
            InitializeComponent();
        }

        const string ACCESSKEY = "4567";

        int inventoryPosition;
        string UPC;

        List<Inventory> inventories = new List<Inventory>()
        {
            new Inventory("ACOG","111111",300m,25000m,100,"Trijicon"),
            new Inventory("Helmet","222222",150m,15000m,100,"Avon"),
            new Inventory("Plate Carrier","333333",100m,1000m,10,"First Spear"),
            new Inventory("AR-15","444444",850m,8500m,10,"Rock River"),
            new Inventory("Pistol","555555",500m,4000m,10,"Glock"),
        };

        private void button1_Click(object sender, EventArgs e)
        {

            for (int p = 0; p < inventories.Count; ++p)
            {
                //if true show definition
                if (inventories[p].GetName().ToLower().Contains(txtSearchName.Text.ToLower()))
                {
                    txtSearchUPC.Text = "";
                    lblNameOutput.Text = inventories[p].GetName();
                    lblUPCOutput.Text = inventories[p].GetUPC();
                    lblStorePriceOutput.Text = inventories[p].GetStorePrice().ToString("c");
                    lblCostPerCaseOutput.Text = inventories[p].GetCostPerCase().ToString("c");
                    lblUnitPerCaseOutput.Text = inventories[p].GetUnitPerCase().ToString();
                    lblDistributorOutput.Text = inventories[p].GetDistributor();
                    inventoryPosition = p;
                    UPC = inventories[p].GetUPC();
                    return;
                }
            }
        }
        private void updatePrice()
        {
            decimal newPrice = 0m;
            if (txtNewPriceAccessKey.Text == ACCESSKEY)
            {
                try
                {
                    newPrice = Convert.ToDecimal(txtChangeNewPrice.Text);
                    inventories[inventoryPosition].UpdatePrice(newPrice);
                    lblStorePriceOutput.Text = inventories[inventoryPosition].GetStorePrice().ToString("c");
                    lblChangePriceError.Visible = false;
                    txtNewPriceAccessKey.Text = "";
                    txtChangeNewPrice.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown Error Occurred\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChangeNewPrice.Text = "";
                    txtChangeNewPrice.Focus();
                    return;
                }
            }
            else
            {
                txtNewPriceAccessKey.Text = "";
                lblChangePriceError.Visible = true;
                return;
            }

        }
        private void deleteItem()
        {

            if (txtDeleteItemAccessKey.Text == ACCESSKEY && txtDeleteItemVerifyUPC.Text == UPC)
            {

                string deletedName = inventories[inventoryPosition].GetName();
                inventories.RemoveAt(inventoryPosition);
                txtSearchUPC.Text = "";
                lblNameOutput.Text = "";
                lblUPCOutput.Text = "";
                lblStorePriceOutput.Text = "";
                lblCostPerCaseOutput.Text = "";
                lblUnitPerCaseOutput.Text = "";
                lblDistributorOutput.Text = "";
                lblChangePriceError.Visible = false;
                txtDeleteItemVerifyUPC.Text = "";
                txtDeleteItemAccessKey.Text = "";
                txtSearchName.Focus();
                
                MessageBox.Show(deletedName + " removed", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }
            else if (txtDeleteItemAccessKey.Text != ACCESSKEY)
            {
                txtDeleteItemVerifyUPC.Text = "";
                txtDeleteItemVerifyUPC.Focus();
                txtDeleteItemAccessKey.Text = "";
                lblDeleteItemError.Visible = true;
                return;
            }
            if (txtDeleteItemVerifyUPC.Text != UPC)
            {
                txtDeleteItemVerifyUPC.Text = "";
                txtDeleteItemVerifyUPC.Focus();
                txtDeleteItemAccessKey.Text = "";
                lblDeleteItemError.Visible = false;
                MessageBox.Show("UPC entered does not match.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

        }
        private void handleNewItem()
        {
            if (txtAddItemAccessKey.Text == ACCESSKEY && inventories.Count < 20)
            {
                inventories.Add(new Inventory(txtAddItemName.Text, txtAddItemUPC.Text, Convert.ToDecimal(txtAddItemStorePrice.Text), Convert.ToDecimal(txtAddItemCostPerCase.Text), Convert.ToInt32(txtAddItemUnitPerCase.Text), txtAddItemDistributor.Text));
                string addedItem = txtAddItemName.Text;

                MessageBox.Show(addedItem + " added to list", "SUCCESSFUL ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddItemName.Text = "";
                txtAddItemStorePrice.Text = "";
                txtAddItemUPC.Text = "";
                txtAddItemUnitPerCase.Text = "";
                txtAddItemDistributor.Text = "";
                txtAddItemCostPerCase.Text = "";
                txtAddItemAccessKey.Text = "";
                lblAddNewItemError.Visible = false;
            }
            else if (txtAddItemAccessKey.Text != ACCESSKEY)
            {
                lblAddNewItemError.Visible = true;
                txtAddItemAccessKey.Text = "";
            }
            else if (inventories.Count >= 20)
            {
                MessageBox.Show("Max quanity of inventory reached", "MAX INVENTORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < inventories.Count; ++p)
            {
                //if true show definition
                if (txtSearchUPC.Text.ToLower() == inventories[p].GetUPC().ToLower())
                {
                    inventoryPosition = p;
                    ExecuteSearch();
                }
            }
        }
        private void ExecuteSearch()
        {
            txtSearchName.Text = "";
            lblNameOutput.Text = inventories[inventoryPosition].GetName();
            lblUPCOutput.Text = inventories[inventoryPosition].GetUPC();
            lblStorePriceOutput.Text = inventories[inventoryPosition].GetStorePrice().ToString("c");
            lblCostPerCaseOutput.Text = inventories[inventoryPosition].GetCostPerCase().ToString("c");
            lblUnitPerCaseOutput.Text = inventories[inventoryPosition].GetUnitPerCase().ToString();
            lblDistributorOutput.Text = inventories[inventoryPosition].GetDistributor();
            
            UPC = inventories[inventoryPosition].GetUPC();
            return;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteItem();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            handleNewItem();
        }
    }
}
