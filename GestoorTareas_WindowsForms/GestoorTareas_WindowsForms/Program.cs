using System;
using System.Windows.Forms;

namespace GestorTareas_WindowsForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("Login implementado");
        }
    }
}
