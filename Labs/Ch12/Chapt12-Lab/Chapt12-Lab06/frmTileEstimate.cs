using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt12_Lab06
{
    public partial class frmTileEstimate : Form
    {
        public frmTileEstimate()
        {
            InitializeComponent();
        }
        List<Room> rooms = new List<Room>()
        { };
        private int totalBoxes()
        {
            int totalBoxes=0;
            for (int p = 0; p < rooms.Count; ++p)
            {
                //if true show definition
                totalBoxes += rooms[p].GetBoxes();
            }
            return totalBoxes;
        }
        private void Display()
        {

            string outputString = "";
            for (int p = 0; p < rooms.Count; ++p)
            {

                
                outputString += rooms[p].GetName() + " (" + rooms[p].GetLength() + "x" + rooms[p].GetWidth() + ") needs " + rooms[p].GetBoxes()+ " boxes\r\n";

                txtRoomsOutput.Text = outputString;
            }
            
        }
        private void handleNewRoom()
        {
            if (rooms.Count < 20)
            {
                rooms.Add(new Room(txtName.Text, Convert.ToInt32(txtLength.Text), Convert.ToInt32(txtWidth.Text)));
                

                

                txtName.Text = "";
                txtLength.Text = "";
                txtWidth.Text = "";
                txtName.Focus();
                lblTotalBoxesOutput.Text = Convert.ToString( totalBoxes());
                lblRoomOutput.Text =  Convert.ToString(rooms.Count)+"/20";
                Display();
            }
            else if (rooms.Count >= 20)
            {
                MessageBox.Show("Max quanity of rooms reached", "MAX INVENTORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        private bool validateWidth()
        {
            bool retval = true;
            bool result;
            int width;

            if (txtWidth.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty width", "EMPTY WIDTH", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtWidth.Focus();
                retval = false;
            }
            else
            {
                result = int.TryParse(txtWidth.Text, out width);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric width", "NON-NUMERIC WIDTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWidth.Text = "";
                    txtWidth.Focus();
                    retval = false;
                }
                else
                {
                    if (width <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero width", "OUT-OF-RANGE WIDTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtWidth.Text = "";
                        txtWidth.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }

        private bool validateName()
        {

            bool retval = true;

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty name", "EMPTY NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtName.Focus();
                retval = false;
                return retval;
        
            }
            retval = true; 
            return retval;
        }
        private bool validateLength()
        {
            bool retval = true;
            bool result;
            int length;

            if (txtLength.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty length", "EMPTY LENGTH", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtLength.Focus();
                retval = false;
            }
            else
            {
                result = int.TryParse(txtLength.Text, out length);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric length", "NON-NUMERIC LENGTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLength.Text = "";
                    txtLength.Focus();
                    retval = false;
                }
                else
                {
                    if (length <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero length", "OUT-OF-RANGE LENGTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLength.Text = "";
                        txtLength.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateName())
            {
                if (validateWidth())
                {
                    if (validateLength())
                    {                        
                        handleNewRoom();
                    }
                }


            }
        }
    }
}
