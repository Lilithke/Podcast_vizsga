using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Podcast_vizsga
{
    internal static class Program
    {
        public static FormMain formMain = null;
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(new FormLogin());
            string endpoint = "http://localhost:8000/api/user";
        }
    }
}
