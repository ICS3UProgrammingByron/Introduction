using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolByron
{
    public partial class PerAreaVolFrm : Form
    {
        public PerAreaVolFrm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //calculate the perimeter of the rectangle 
            this.lblPerimeter.Text =Convert.ToString (2 * 7 + 2 * 5)+"cm";
        }

        private void LblArea_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //calculate the area of the circle 
            this.lblArea.Text = Convert.ToString(Math.PI * Math.Pow(9, 2)) + "cm";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //calculate te volume of a spehere
            this.lblVolume.Text = Convert.ToString( (double)4/ (double)3 * Math.PI * Math.Pow(10, 3)) + "cm";
        }

        private void PerAreaVolFrm_Load(object sender, EventArgs e)
        {

        }

        private void HelloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
