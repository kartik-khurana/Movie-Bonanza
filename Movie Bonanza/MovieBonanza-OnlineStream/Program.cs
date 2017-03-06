using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
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
    static class Program
    {
        // array that stores the users information
        public static string[] selection = new string[3];
       
        public static double cost;
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
