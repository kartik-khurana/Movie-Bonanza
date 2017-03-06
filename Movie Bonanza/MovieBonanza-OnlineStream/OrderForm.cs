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
 * This form will calculate the total of all the movies selected by a user.
 */

namespace MovieBonanza_OnlineStream
{
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;
        public OrderForm()
        {
            InitializeComponent();
            this.OrderForm_Load();
        }
        /// 
        /// this will display the result in the text boxes using the order form load event handler
        private void OrderForm_Load()
        {
            TitleTextBox4.Text = Program.selection[0];
            CategoryTextBox5.Text = Program.selection[1];
            CostTextBox6.Text = Program.selection[2];
            CalculateTotal();
            PictureBox();           
        }
        
        /// 
        /// this will make sure that the dvd checkbox is checked or not if it is then the
        /// additonal dvd label and text box will appear with an additional amt of 10.00$
        
        private void OptionalDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            if (OptionalDVDCheckBox.Checked)
            {
                DVDChargeTextBox10.Text = "$10.00";
                DVDChargeLabel.Show();
                DVDChargeTextBox10.Show();
            }
            else
            {
                DVDChargeLabel.Hide();
                DVDChargeTextBox10.Hide();
            }
        }
        /// <summary>
        /// this will exit the program 
        
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this will display a print version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing a movie..it is being sent to printer :)");
        }
        /// <summary>
        ///this will move to the stream form window
       
        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new MovieBonanza_OnlineStream.StreamForm();
            streamForm.Show();
            this.Hide();
        }
        /// <summary>
      
        /// This will show the about information
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox1 = new AboutBox();
            aboutBox1.ShowDialog();
        }
        /// <summary>
        /// this will move the current window to back or the previous window
        /// 
        
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        
        /// This will calculate the total
        
        private void CalculateTotal()
        { 
            //instance variables with appropriate data types

            double _Cost;
            double _SubTotal;
            double _SalesTax;
            double _GrandTotal;
            double _DVD = 10;
             
           //this will parse the cost in the respetive text boxes
            _Cost = double.Parse(CostTextBox6.Text, System.Globalization.NumberStyles.Currency);
           
            //if statements to ensure whether additional amount has to be added or not
            if (OptionalDVDCheckBox.Checked)
            {
                _SubTotal = _Cost + _DVD;
            }
            
            else if (!OptionalDVDCheckBox.Checked)
            {
                _SubTotal = _Cost;
            }
            else
            {
                _SubTotal = _Cost;
            }
           
            //multiplying by .13 for the sales taxt method

            _SalesTax = _SubTotal * 0.13;
            _GrandTotal = _SubTotal + _SalesTax;
            SubTotalTextBox7.Text = _SubTotal.ToString("C2");
            SalesTaxTextBox8.Text = _SalesTax.ToString("C2");
            GrandTotalTextBox9.Text = _GrandTotal.ToString("C2");
           // displaying the result
            Program.cost = _GrandTotal;

        }
        
        private void PictureBox()
        {
            // this shows the specific images with the assigned cost
            if (CategoryTextBox5.Text == "Action")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.action;
            }
            else if (CategoryTextBox5.Text == "Sci-Fi")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.scifi;
            }
            else if (CategoryTextBox5.Text == "Comedy")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.comedy;
            }
            else if (CategoryTextBox5.Text == "Drama")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.drama;
            }
            else if (CategoryTextBox5.Text == "Horror")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.horror;
            }
            else if (CategoryTextBox5.Text == "Thriller")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.thriller;
            }
            else if (CategoryTextBox5.Text == "Family")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.family;
            }
            else
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.newrelease;
            }
           
            MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void MovieSelectedGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
