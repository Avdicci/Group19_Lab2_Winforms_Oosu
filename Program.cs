using System;
using System.Windows.Forms;
using Group19_Lab2_Winforms_Oosu.Services;

namespace Group19_Lab2_Winforms_Oosu
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Skapa instansen av in-memory databas (Servicelagret)
            SystemController controller = new SystemController();

            
            Application.Run(new Meny(controller));
        }
    }
}