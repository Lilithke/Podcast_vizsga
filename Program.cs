using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast_vizsga
{
    internal static class Program
    {
        public static FormMain formMain = null;
        public static FormCeg formCeg = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            formCeg = new FormCeg();
            Application.Run(new FormLogin());
        }
    }
}
