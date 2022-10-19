using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Extra 12-1 Create and use a class
In this exercise, you’ll add a class to an Inventory Maintenance application and then add code to the two forms that use this class.
Open the project and add an InvItem class
1. Open the InventoryMaintenance project in the Extra Starts/Chapter 12 directory. Then, review the existing code for both of the forms so you get an idea of how this application should work.
2. Add a class named InvItem to this project, and add the properties, method, and constructors that are shown in the table below. Property Description ItemNo Gets or sets an int that contains the item’s number. Description Gets or sets a string that contains the item’s description. Price Gets or sets a decimal that contains the item’s price. Method Description GetDisplayText() Returns a string that contains the item’s number, description, and price formatted like this: 3245649 Agapanthus ($7.95). (The item number and description are separated by four spaces.) Constructor Description () Creates an InvItem object with default values. (itemNo, description, price) Creates an InvItem object with the specified values.
24 Extra exercises for Murach’s C# (7th Edition)
Add code to implement the New Item form
3. Display the code for the New Item form, and declare a class-level InvItem variable named invItem with an initial value of null.
4. Add a public method named GetNewItem() that displays the form as a dialog box and returns an InvItem object.
5. Add code to the btnSave_Click() event handler that creates a new InvItem object and closes the form if the data is valid.
Add code to implement the Inventory Maintenance form
6. Display the code for the Inventory Maintenance form, and declare a class-level List<InvItem> variable named invItems with an initial value of null.
7. Add a statement to the frmInvMaint_Load() event handler that uses the GetItems() method of the InvItemDB class to load the items list.
8. Add code to the FillItemListBox() method that adds the items in the list to the Items list box. Use the GetDisplayText() method of the InvItem class to format the item data.
9. Add code to the btnAdd_Click() event handler that creates a new instance of the New Item form and executes the GetNewItem() method of that form. If the InvItem object that’s returned by this method is not null, this event handler should add the new item to the list, call the SaveItems() method of the InvItemDB class to save the list, and then refresh the Items list box. Test the application to be sure this event handler works.
10. Add code to the btnDelete_Click() event handler that removes the selected item from the list, calls the SaveItems() method of the InvItemDB class to save the list, and refreshes the Items list box. Be sure to confirm the delete operation. Then, test the application to be sure this event handler works.
 */

namespace Chapt12_1Homework
{
    public partial class frmInventoryMaintenance : Form
    {
        frmNewInventory form2 = new frmNewInventory();
        public frmInventoryMaintenance()
        {
            InitializeComponent();
            GetDisplayText();
           
        }
        int itemsPosition;
        static List<InvItem> items = new List<InvItem>()
        {
            new InvItem(123456,"Daisy",4.0m),
            new InvItem(234567,"Roses",2.0m),
            new InvItem(345678,"Lily",3.0m),
            new InvItem(456789,"Carnation",5.0m),
            
        };
        private void GetDisplayText()
        {

            string outputString = "";
            lbxInventory.Items.Clear();
            for (int p = 0; p < items.Count; ++p)
            {


                outputString = items[p].GetItemNumber().ToString() + "    " + items[p].GetDescription() + "    " +  items[p].GetPrice().ToString("c");

                lbxInventory.Items.Add(outputString);
            }

        }
        private void exitProgramOrNot()
        {
            //Exit Button Code
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            itemsPosition = lbxInventory.SelectedIndex;
            //Exit Button Code
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Delete "+ items[lbxInventory.SelectedIndex].GetDescription() +"?",
                "DELETE SELECTED ITEM?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                DeleteSelectedItem();
                GetDisplayText();
                //MessageBox.Show(items.Count.ToString(),"item",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void DeleteSelectedItem()
        {
            
            items.RemoveAt(itemsPosition);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmNewInventory form2 = new frmNewInventory();
            
            form2.ShowDialog();
            
        }

        internal void receiveData()
        {
            throw new NotImplementedException();
        }

        internal void receiveData(int i, string d, decimal p)
        {
            items.Add(new InvItem( i, d, p));
            GetDisplayText();

        }

        private void frmInventoryMaintenance_Activated(object sender, EventArgs e)
        {
            GetDisplayText();
        }
    }
}
