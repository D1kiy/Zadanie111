using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieNaProvrku_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new QustionForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.No)
            {
                MessageBox.Show("Приложение закрыто");
                Application.Exit();
            }
            else
            {
                Application.Run(new StartForm());
            }
        }
    }
}
