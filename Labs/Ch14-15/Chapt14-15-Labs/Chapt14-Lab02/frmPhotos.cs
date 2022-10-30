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
 * LB2 Photos
Write a GUI application for a photography business.
●	8" by 10" photos are $3.99
●	10" by 12" photos are $5.99
●	All other sizes are $9.99
●	Customers can add either a Matte or a Frame.
●	Matted photos are an additional $10.
●	Framed photos are an additional $25.	
●	Override the ToString() methods on the Photo, MattedPhoto, and FramedPhoto classes so that they display all of the information in the fields.


 */

namespace Chapt14_Lab02
{
    public partial class frmPhotos : Form
    {
        const int MINWIDTH = 8;
        const int MINHEIGHT = 10;
        const int MAXWIDTH = 72;
        const int MAXHEIGHT = 72;

        const decimal EIGHTXTEN = 3.99m;
        const decimal TENXTWELVE = 5.99m;
        const decimal OTHER = 9.99m;
        const decimal MATTED = 10m;
        const decimal FRAMED = 25m;

        decimal width = 0m;
        decimal height = 0m;
        decimal totalCost = 0m;

        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonStyle;
        RadioButton radioButtonMaterial;
        string frameStr = "";
        string colorStr = "";
        string materialStr = "";
        string styleStr = "";

        public frmPhotos()
        {
            InitializeComponent();
        }

        private void frmPhotos_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = IsValidData();
        }
        private bool IsValidData()
        {
            bool success = true;
            string errMsg = "";
            return success;
        }
    }
}
