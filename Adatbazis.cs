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
            builder.Database = "podcast";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql= conn.CreateCommand();
            try
            {
             Nyit();
            }
            catch(MySqlException ex)
            { MessageBox.Show(ex.Message);
              Environment.Exit(0);
            }finally
            {
             Zar();
            }
            
        }

        private void Nyit()
        {
         if(conn.State!=System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Zar()
        {
            if(conn.State!= System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public List<LocalUser> GetAllUsers()
        {
            List<LocalUser> users = new List<LocalUser>();

            sql.CommandText = "SELECT * FROM `users` WHERE 1";
            try
            {
                Nyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        long felhasznaloid = dr.GetInt64("felhasznaloid");
                        string nev = dr.GetString("nev");
                        string email = dr.GetString("email");
                        string jelszo = dr.GetString("jelszo");
                        string telefonszam = dr.GetString("telefonszam");
                        string szemelyi_szam = dr.GetString("szemelyi_szam");
                        DateTime szuletesi_datum = dr.GetDateTime("szuletesi_datum");
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
                        string lepcsohaz = dr.GetString("lepcsohaz");
                        string emelet = dr.GetString("emelet");
                        string ajto = dr.GetString("ajto");

                        users.Add(new LocalUser(felhasznaloid,nev,email,jelszo,telefonszam,szemelyi_szam,szuletesi_datum,ceg,cegnev,ceg_tipus,
                            ado_szam,bankszamlaszam,orszag,iranyitoszam,varos,utca,utca_jellege,hazszam,epulet,lepcsohaz,emelet,ajto));

                     



                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Zar();
            }
            return users;

            

        }

        internal void UpdateUsers(LocalUser localUser)
        {
           

            try
            {
                Nyit();
                

                sql.CommandText = "UPDATE `users` SET `felhasznaloid`= @felhasznaloid,`nev`= @nev,`email`= @email,`jelszo`= @jelszo,`telefonszam`= @telefonszam,`szemelyi_szam`= @szemelyi_szam,`szuletesi_datum`= @szuletesi_datum,`ceg`= @ceg,`cegnev`= @cegnev,`ceg_tipus`= @ceg_tipus,`ado_szam`= @ado_szam,`bankszamlaszam`= @bankszamlaszam,`orszag`= @orszag,`iranyitoszam`= @iranyitoszam,`varos`= @varos,`utca`= @utca,`utca_jellege`= @utca_jellege,`hazszam`= @hazszam,`epulet`= @epulet,`lepcsohaz`= @lepcsohaz,`emelet`= @emelet,`ajto`= @ajto WHERE `felhasznaloid`= @felhasznaloid";
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@felhasznaloid",localUser.Felhasznaloid);
                sql.Parameters.AddWithValue("@nev",localUser.Nev);
                sql.Parameters.AddWithValue("@email",localUser.Email);
                sql.Parameters.AddWithValue("@jelszo",localUser.Jelszo);
                sql.Parameters.AddWithValue("@telefonszam",localUser.Telefonszam);
                sql.Parameters.AddWithValue("szemelyi_szam",localUser.Szemelyi_szam);
                sql.Parameters.AddWithValue("@szuletesi_datum",localUser.Szuletesi_datum);
                sql.Parameters.AddWithValue("@ceg",localUser.Ceg);
                sql.Parameters.AddWithValue("@cegnev",localUser.Cegnev);
                sql.Parameters.AddWithValue("@ceg_tipus",localUser.Ceg_tipus);
                sql.Parameters.AddWithValue("@ado_szam",localUser.Ado_szam);
                sql.Parameters.AddWithValue("@bankszamlaszam",localUser.Bankszamlaszam);
                sql.Parameters.AddWithValue("@orszag",localUser.Orszag);
                sql.Parameters.AddWithValue("@iranyitoszam",localUser.Iranyitoszam);
                sql.Parameters.AddWithValue("@varos",localUser.Varos);
                sql.Parameters.AddWithValue("@utca",localUser.Utca);
                sql.Parameters.AddWithValue("@utca_jellege",localUser.Utca_jellege);
                sql.Parameters.AddWithValue("@hazszam",localUser.Hazszam);
                sql.Parameters.AddWithValue("@epulet",localUser.Epulet);
                sql.Parameters.AddWithValue("@lepcsohaz",localUser.Lepcsohaz);
                sql.Parameters.AddWithValue("@emelet",localUser.Emelet);
                sql.Parameters.AddWithValue("@ajto",localUser.Ajto);

                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { Zar(); }


        }

       
        internal void NewUsers(LocalUser localUser)
        {
            try
            {
                Nyit();

                sql.CommandText = "INSERT INTO `users`(`felhasznaloid`, `nev`, `email`, `jelszo`, `telefonszam`, `szemelyi_szam`, `szuletesi_datum`, `ceg`, `cegnev`, `ceg_tipus`, `ado_szam`, `bankszamlaszam`, `orszag`, `iranyitoszam`, `varos`, `utca`, `utca_jellege`, `hazszam`, `epulet`, `lepcsohaz`, `emelet`, `ajto`) " +
                "VALUES (@felhasznaloid, @nev, @email, @jelszo, @telefonszam , szemelyi_szam , @szuletesi_datum, @ceg, @cegnev, @ceg_tipus , @ado_szam , @bankszamlaszam , @orszag , @iranyitoszam, @varos, @utca, @utca_jellege, @hazszam, @epulet, @lepcsohaz, @emelet, @ajto )";
                
                
                sql.Parameters.Clear();
                sql.Parameters.AddWithValue("@felhasznaloid", localUser.Felhasznaloid);
                sql.Parameters.AddWithValue("@nev", localUser.Nev);
                sql.Parameters.AddWithValue("@email", localUser.Email);
                sql.Parameters.AddWithValue("@jelszo", localUser.Jelszo);
                sql.Parameters.AddWithValue("@telefonszam", localUser.Telefonszam);
                sql.Parameters.AddWithValue("szemelyi_szam", localUser.Szemelyi_szam);
                sql.Parameters.AddWithValue("@szuletesi_datum", localUser.Szuletesi_datum);
                sql.Parameters.AddWithValue("@ceg", localUser.Ceg);
                sql.Parameters.AddWithValue("@cegnev", localUser.Cegnev);
                sql.Parameters.AddWithValue("@ceg_tipus", localUser.Ceg_tipus);
                sql.Parameters.AddWithValue("@ado_szam", localUser.Ado_szam);
                sql.Parameters.AddWithValue("@bankszamlaszam", localUser.Bankszamlaszam);
                sql.Parameters.AddWithValue("@orszag", localUser.Orszag);
                sql.Parameters.AddWithValue("@iranyitoszam", localUser.Iranyitoszam);
                sql.Parameters.AddWithValue("@varos", localUser.Varos);
                sql.Parameters.AddWithValue("@utca", localUser.Utca);
                sql.Parameters.AddWithValue("@utca_jellege", localUser.Utca_jellege);
                sql.Parameters.AddWithValue("@hazszam", localUser.Hazszam);
                sql.Parameters.AddWithValue("@epulet", localUser.Epulet);
                sql.Parameters.AddWithValue("@lepcsohaz", localUser.Lepcsohaz);
                sql.Parameters.AddWithValue("@emelet", localUser.Emelet);
                sql.Parameters.AddWithValue("@ajto", localUser.Ajto);


                sql.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { Zar(); }
        }


        internal void DeleteUsers(LocalUser localUser)
        {
            try
            {
                Nyit();

                sql.CommandText = "DELETE FROM `users` WHERE 0";

                
                sql.Parameters.AddWithValue("@felhasznaloid", localUser.Felhasznaloid);
                sql.Parameters.AddWithValue("@nev", localUser.Nev);
                sql.Parameters.AddWithValue("@email", localUser.Email);
                sql.Parameters.AddWithValue("@jelszo", localUser.Jelszo);
                sql.Parameters.AddWithValue("@telefonszam", localUser.Telefonszam);
                sql.Parameters.AddWithValue("szemelyi_szam", localUser.Szemelyi_szam);
                sql.Parameters.AddWithValue("@szuletesi_datum", localUser.Szuletesi_datum);
                sql.Parameters.AddWithValue("@ceg", localUser.Ceg);
                sql.Parameters.AddWithValue("@cegnev", localUser.Cegnev);
                sql.Parameters.AddWithValue("@ceg_tipus", localUser.Ceg_tipus);
                sql.Parameters.AddWithValue("@ado_szam", localUser.Ado_szam);
                sql.Parameters.AddWithValue("@bankszamlaszam", localUser.Bankszamlaszam);
                sql.Parameters.AddWithValue("@orszag", localUser.Orszag);
                sql.Parameters.AddWithValue("@iranyitoszam", localUser.Iranyitoszam);
                sql.Parameters.AddWithValue("@varos", localUser.Varos);
                sql.Parameters.AddWithValue("@utca", localUser.Utca);
                sql.Parameters.AddWithValue("@utca_jellege", localUser.Utca_jellege);
                sql.Parameters.AddWithValue("@hazszam", localUser.Hazszam);
                sql.Parameters.AddWithValue("@epulet", localUser.Epulet);
                sql.Parameters.AddWithValue("@lepcsohaz", localUser.Lepcsohaz);
                sql.Parameters.AddWithValue("@emelet", localUser.Emelet);
                sql.Parameters.AddWithValue("@ajto", localUser.Ajto);
                sql.Parameters.Clear();

                sql.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { Zar(); }
        }

    }


}
