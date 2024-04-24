using MySql.Data.MySqlClient;
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
        public static string endpoint = "http://localhost:8000/api/user";
        public static Adatbazis db = new Adatbazis();
        public static List<LocalUser> users = new List<LocalUser>();
        //static List<LocalUser>Userlist = localUsers;
       


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            users = db.GetAllUsers();
            formMain = new FormMain();
            Application.Run(new FormLogin());
           

        }
    }
}
