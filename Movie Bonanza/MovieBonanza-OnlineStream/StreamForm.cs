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
 * APP NAME - MOVIE BONANZA ASSIGNMENT 3
 * AUTHOR'S NAME - KARTIK KHURANA
 * STUDENT ID - 200331395
 * DATE - MARCH 4TH , 2017
 *This form displays the result in a textbox thanking the user to stream movie bonanza
 */

namespace MovieBonanza_OnlineStream
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
            CreditChargeLabel.Text = "Your Credit card will be charged " + Program.cost.ToString("C2");
            MovieLabel.Text = Program.selection[0] + " will begin streaming within a sec (y)";
        }
        // this will exit the program
        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreditChargeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
