using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarthProject
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        //Global Constant
        const int NUMELEMENTS = 16;

        string[] images =
        {
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth00.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth01.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth02.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth03.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth04.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth05.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth06.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth07.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth08.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth09.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth10.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth11.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth12.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth13.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth14.jpg",
            "C:\\Users\\dopy_\\OneDrive\\Documents\\Ranken - 2022\\AWD1100-Fall2022-AndrewLaw\\Database\\Garth\\GarthSolution\\GarthProject\\images\\garth15.jpg"
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
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

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            gotoMainPage();
        }
        private void gotoMainPage()
        {
            Form mainForm = new frmMainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            pb00.Image = Image.FromFile(images[0]);             
            pb01.Image = Image.FromFile(images[1]);
            pb02.Image = Image.FromFile(images[2]);
            pb03.Image = Image.FromFile(images[3]);
            pb04.Image = Image.FromFile(images[4]);
            pb05.Image = Image.FromFile(images[5]);
            pb06.Image = Image.FromFile(images[6]);
            pb07.Image = Image.FromFile(images[7]);
            pb08.Image = Image.FromFile(images[8]);
            pb09.Image = Image.FromFile(images[9]);
            pb10.Image = Image.FromFile(images[10]);
            pb11.Image = Image.FromFile(images[11]);
            pb12.Image = Image.FromFile(images[12]);
            pb13.Image = Image.FromFile(images[13]);
            pb14.Image = Image.FromFile(images[14]);
            pb15.Image = Image.FromFile(images[15]);
            
        }

        private void mainPageMenuItem_Click(object sender, EventArgs e)
        {
            gotoMainPage();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the help buttonn for more information.",
            "HELP",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            0,
            "https://www.google.com/search?q=garth+brooks");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
    }
}
