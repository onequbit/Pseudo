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
            try
            {
                if (args.Length == 0) return;
                new ConsoleAttached();
                AdminProcess.EnsureElevatedContext();                
      
                (string cmd, string[] cmdArgs) = args.Pop();
                string cmdLine = cmdArgs.Join(" ");                
                
                string output = new AdminProcess(cmdLine).GetOutput();
                Console.WriteLine(output);                
                SendKeys.SendWait("{Enter}");           
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");                
            }                        
        }
    }
}