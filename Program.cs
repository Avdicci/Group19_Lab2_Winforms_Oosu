using System;
using System.Windows.Forms;
using Group19_Lab2_Winforms_Oosu.Services; // Lägg till detta om SystemController ligger i en egen mapp/projekt

namespace Group19_Lab2_Winforms_Oosu
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Skapa instansen av din in-memory databas (Servicelagret)
            SystemController controller = new SystemController();

            // 2. Skicka med controllern in i det första fönstret
            Application.Run(new Meny(controller));
        }
    }
}