using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast_vizsga
{
    internal class Adatbazis
    {
        
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "podcaststudio";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql= conn.CreateCommand();
            try
            {
             nyit();
            }
            catch(MySqlException ex)
            { MessageBox.Show(ex.Message);
              Environment.Exit(0);
            }finally
            {
             zar();
            }
            
        }

        private void nyit()
        {
         if(conn.State!=System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void zar()
        {
            if(conn.State!= System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public List<LocalUsers> GetAllUsers()
        {
            var users = new List<LocalUsers>();
            //
            sql.CommandText = "SELECT * FROM `users` WHERE 1";
            try
            {
                nyit();
                using(MySqlDataReader dr= sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        long felhasznaloid = dr.GetInt64("felhasznaloid");
                        string nev = dr.GetString("nev");
                        string email = dr.GetString("email");
                        string jelszo = dr.GetString("jelszo");
                        string telefonszam = dr.GetString("telefonszam");
                        string szemelyi_szam = dr.GetString("szemelyi_szam");
                        DateTime szuletesi_datum = (DateTime)dr.GetMySqlDateTime("szuletesi_datum");
                        bool ceg = dr.GetBoolean("ceg");
                        string cegnev = dr.GetString("cegnev");
                        string ceg_tipus = dr.GetString("ceg_tipus");
                        string ado_szam = dr.GetString("ado_szam");
                        string bankszamlaszam = dr.GetString("bankszamlaszam");
                        string orszag = dr.GetString("orszag");
                        string iranyitoszam = dr.GetString("iranyitoszam");
                        string varos = dr.GetString("varos");
                        string utca = dr.GetString("utca");
                        string utca_jellege = dr.GetString("utca_jellege");
                        string hazszam = dr.GetString("hazszam");
                        string epulet = dr.GetString("epulet");
                        string emelet = dr.GetString("emelet");
                        string ajto = dr.GetString("ajto");

                        users.Add(new LocalUser(felhasznaloid, nev, email, jelszo, telefonszam, szemelyi_szam,
                            szuletesi_datum, ceg, cegnev, ado_szam, bankszamlaszam, orszag, iranyitoszam, varos, utca,
                            utca_jellege, hazszam, epulet, emelet, ajto));

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                zar();
            }
            return users;
        }
    }


}
