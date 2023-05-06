using System;
using System.IO;
using System.Windows.Forms;

namespace WaterAlert
{
    public  class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }

        public static Boolean ValidaLogin(string login, string senha)
        {
            string arquivo = "E:/Projects/WaterAlert/db/baselogins.txt";
            string conteudo = File.ReadAllText(arquivo);

            string[] dados      = conteudo.Split(',');
            string   loginDb    = dados[0];
            string   passwordDb = dados[1];

            if (login == loginDb && senha == passwordDb)
            {
                return true;
            }
            return false;
        }
    }
}