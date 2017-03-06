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
 * This form takes the user input and stores the user's selection using an array
 */

namespace MovieBonanza_OnlineStream
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }
        
        /// CurrentMoviesListBox_SelectedIndexChanged Event Handler
        /// This will update all information in the window based on the user selection. This includes the movie title, category, cost, and image
       
        private void CurrentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // It displays the user input in a title text box 1 by converting item to a string
           
            TitleTextBox1.Text = (string)CurrentMoviesListBox.SelectedItem;

            //If user selects any movie from the drop down list the next button is enabled which will 
            // to the order form.
            NextButton.Enabled = true;

            //The following if statements set the images for the movies.
            // and order the movies by the category with the prices included
            if ((string)CurrentMoviesListBox.SelectedItem == "The Green Hornet" || (string)CurrentMoviesListBox.SelectedItem == "Death Race 2" || (string)CurrentMoviesListBox.SelectedItem == "The Mechanic" || (string)CurrentMoviesListBox.SelectedItem == "Sanctum" || (string)CurrentMoviesListBox.SelectedItem == "The Other Woman" || (string)CurrentMoviesListBox.SelectedItem == "The Eagle")
            {
                CategoryTextBox2.Text = "Action";
                CostTextBox3.Text = "$2.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.action;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((string)CurrentMoviesListBox.SelectedItem == "Season of the Witch" || (string)CurrentMoviesListBox.SelectedItem == "I am Number Four")
            {
                CategoryTextBox2.Text = "Sci-Fi";
                CostTextBox3.Text = "$2.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.scifi;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((string)CurrentMoviesListBox.SelectedItem == "The Dilemma" || (string)CurrentMoviesListBox.SelectedItem == "No Strings Attached" || (string)CurrentMoviesListBox.SelectedItem == "Cedar Rapids" || (string)CurrentMoviesListBox.SelectedItem == "Just Go With It")
            {
                CategoryTextBox2.Text = "Comedy";
                CostTextBox3.Text = "$1.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.comedy;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((string)CurrentMoviesListBox.SelectedItem == "Company Men" || (string)CurrentMoviesListBox.SelectedItem == "The Way Back" || (string)CurrentMoviesListBox.SelectedItem == "Waiting for Forever")
            {
                CategoryTextBox2.Text = "Drama";
                CostTextBox3.Text = "$1.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.drama;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((string)CurrentMoviesListBox.SelectedItem == "The Rite")
            {
                CategoryTextBox2.Text = "Horror";
                CostTextBox3.Text = "$2.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.horror;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((string)CurrentMoviesListBox.SelectedItem == "The Roommate")
            {
                CategoryTextBox2.Text = "Thriller";
                CostTextBox3.Text = "$1.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.thriller;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((string)CurrentMoviesListBox.SelectedItem == "Gnomeo and Juliet")
            {
                CategoryTextBox2.Text = "Family";
                CostTextBox3.Text = "$0.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.family;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                CategoryTextBox2.Text = "New Release";
                CostTextBox3.Text = "$4.99";
                PictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.newrelease;
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        /// <summary>
        /// NextButton_Click event handler
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.selection[0] = TitleTextBox1.Text;
            Program.selection[1] = CategoryTextBox2.Text;
            Program.selection[2] = CostTextBox3.Text;
            OrderForm orderForm = new MovieBonanza_OnlineStream.OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
