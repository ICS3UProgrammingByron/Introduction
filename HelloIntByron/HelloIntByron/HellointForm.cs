/*
 * Created by: Byron Edmonds Decosse
 * Created on: 11/02/2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International 
 * This program this program displays 4 radio buttons and when the user will click
 * on the radio button it will change the language of the greeting according to the
 * language displayed as the name of the radio button
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntByron
{
    public partial class HellointFrm : Form
    {
        public HellointFrm()
        {
            InitializeComponent();
        }

        private void LblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            //change the greeting to spanish
            this.LblGreeting.Text = "Hola Mundo";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //change the greeting to english
            this.LblGreeting.Text = "Hello World";
        }

        private void RadFrancais_CheckedChanged(object sender, EventArgs e)
        {
            //change the greeting to francais
            this.LblGreeting.Text = "Bonjour Le Monde";
        }

        private void Radعربى_CheckedChanged(object sender, EventArgs e)
        {
            //change the greeting to swedish
            this.LblGreeting.Text = "Hej världen";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
    
           
            

        }
     
  

  


