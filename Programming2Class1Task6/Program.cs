/*    
 *    Program name: 	    Sum Averages are fractional
 *    Project file name:    Programming2Class1Task6.csproj
 *    Author:		        Steffen Geving
 *    Date:	                19/07/2021
 *    Language:		        C#
 *    Platform:		        Microsoft Visual Studio Enterprise 2019
 *    Purpose:		        Take 5 user-input numbers and calculate sum or average depending on button-click events.
 *    Description:		    The program creates a form with five text boxes that the user must fill with numbers. Then upon pressing the \
 *                          Sum or the Average button the result will be calculated and displayed in the adjacent text box.
 *    Known Bugs:		    
 *    Additional Features:  Check if user forgot to input any numbers or input non-numbers and default to 0.
 */


using System;
using System.Windows.Forms;

namespace Programming2Class1Task6
{
    // Main program class
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
