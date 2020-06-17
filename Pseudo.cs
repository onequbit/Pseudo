using Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace App
{
    
    public class Program
    {
        [STAThread] // required for Windows Forms
        public static void Main(string[] args)
        {
            if (args.Length == 0) return;
            try
            {                
                string output = new AdminProcess(args.Join(" ")).GetOutput();                                
                Console.WriteLine(output);                           
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");                
            }                        
        }
    }
}