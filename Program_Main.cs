// Simple Web Browser 
// Authur: Haoran Hong

using System;
using System.Windows.Forms;

namespace F21SC_CW1
{
    static class Program_Main
    {
        
        [STAThread]
        //Main
        static void Main()
        {
            //Start browser form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
