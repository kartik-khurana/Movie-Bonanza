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
 * This is a splash form that will display the logo of the movie
 */

namespace MovieBonanza_OnlineStream
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
       
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
           
            SplashFormTimer.Enabled = false;
            
            SelectionForm startform = new SelectionForm();
            startform.Show();
            // this will hide the form
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
