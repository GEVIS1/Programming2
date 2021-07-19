/* 
 * Program name: 	    Calculator
 * Project file name:   Programming2Class1Task7
 * Author:		        Steffen Geving
 * Date:	            2021/07/20
 * Language:		    C#
 * Platform:		    Microsoft Visual Studio 2019
 * Purpose:		        A simple calculator program.
 * Description:		    A .NET framework Windows Form program with basic calculator functionality (add, mul, sub, div, mod).
 * Known Bugs:		    
 * Additional Features: 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming2Class1Task7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
