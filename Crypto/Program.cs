using System;
using System.Windows.Forms;

namespace Crypto
{
    internal static class Program
    {
        /// <summary> Главная точка входа для приложения. </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // авторизация
            // открываем форму с реализацией алгоритма
            Application.Run(new Work());
        }
    }
}
