using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCFrog
{
    public partial class FrogView : Form
    {
        //VIEW part of MVC
        //This part is what the user is able see and actually interact with

        //controller object
        FrogController frogController = new FrogController();

        public FrogView()
        {
            InitializeComponent();
        }

        //method triggered by a button click, calls the growFrog CONTROLLER method
        //additional calls the local method updateFrogSizeTextView()
        private void btnGrowFrog_Click(object sender, EventArgs e)
        {
            frogController.growFrog();
            updateFrogSizeTextView();
        }

        //method triggered by a button click, calls the shrinkFrog CONTROLLER method
        //additional calls the local method updateFrogSizeTextView()
        private void btnShrinkFrog_Click(object sender, EventArgs e)
        {
            frogController.shrinkFrog();
            updateFrogSizeTextView();
        }

        //local VIEW method, which gets the frog size via the CONTROLLER methods, and updates the text view
        //additonally calls the local method updateFrogSizeGraphicalView() to update the graphic view
        private void updateFrogSizeTextView()
        {
            txtFrogSize.Text = frogController.getFrogSize().ToString();
            updateFrogSizeGraphicalView();
            if (frogController.getFrogSize() > 50)
            {
                txtFrogSize.Text = "Splat!";
            }
   
        }

        private void updateFrogSizeGraphicalView()
        {

            if (frogController.getFrogSize() < 50)
            {
                picFrog.Image = Image.FromFile("C:\\Users\\MC03286\\OneDrive - Middlesbrough College\\Pictures\\frog.jfif");

                Size size = picFrog.Size;
                size.Height = frogController.getFrogSize();
                size.Width = frogController.getFrogSize();
                picFrog.Size = size;
            }
        
        else
            {
                //frog explodes
                picFrog.Image = Image.FromFile("C:\\Users\\MC03286\\OneDrive - Middlesbrough College\\Pictures\\splat.jfif");
            }
            
        }
    }
}
