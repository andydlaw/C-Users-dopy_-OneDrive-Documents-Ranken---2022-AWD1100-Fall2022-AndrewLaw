using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * Extra 4-1 Calculate area and perimeter
In this exercise, you’ll create a form that accepts the length and width of a rectangle 
    from the user and then calculates the area and perimeter of the rectangle.
1. Start a new project named AreaAndPerimeter in the Extra Starts\Chapter 04 directory.
2. Add labels, text boxes, and buttons to the default form and set the properties of the 
    form and its controls so they appear as shown above. When the user presses the Enter 
    key, the Click event of the Calculate button should fire. When the user presses the Esc 
    key, the Click event of the Exit button should fire.
3. Create an event handler for the Click event of the Calculate button. This event handler 
    should get the values the user enters for the length and width, calculate and display 
    the area (length x width) and perimeter (2 x length + 2 x width), and move the focus to 
    the Length text box. It should provide for decimal entries, but you can assume that the 
    user will enter valid decimal values.
4. Create an event handler for the Click event of the Exit button that closes the form.
5. Test the application to be sure it works correctly.
*/

namespace Chapt4_5Homework
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void frmAreaAndPerimeter_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            txtLength.Text = "";
            txtWidth.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            //set curser to text box
            txtLength.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //area (length x width) and perimeter (2 x length + 2 x width)

            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal area = length * width;
            decimal perimeter = ((2 * length) + (width * 2));

            txtArea.Text = area.ToString("n2");
            txtPerimeter.Text = perimeter.ToString("n2");
        }
    }
}
