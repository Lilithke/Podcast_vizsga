using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_vizsga
{
    internal class LocalUser
    {
        long felhasznaloid;
        string nev;
        string email;
        string jelszo;
        string telefonszam;
        string szemelyi_szam;
        DateTime szuletesi_datum;

        bool ceg;
        string cegnev;
        string ceg_tipus;
        string ado_szam;
        string bankszamlaszam;

        string orszag;
        string iranyitoszam;
        string varos;
        string utca;
        string utca_jellege;
        string hazszam;
        string epulet;
        string emelet;
        string ajto;

        

        public long Felhasznaloid { get => felhasznaloid; set => felhasznaloid = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Email { get => email; set => email = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }
        public string Szemelyi_szam { get => szemelyi_szam; set => szemelyi_szam = value; }
        public DateTime Szuletesi_datum { get => szuletesi_datum; set => szuletesi_datum = value; }
        public bool Ceg { get => ceg; set => ceg = value; }
        public string Cegnev { get => cegnev; set => cegnev = value; }
        public string Ceg_tipus { get => ceg_tipus; set => ceg_tipus = value; }
        public string Ado_szam { get => ado_szam; set => ado_szam = value; }
        public string Bankszamlaszam { get => bankszamlaszam; set => bankszamlaszam = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public string Iranyitoszam { get => iranyitoszam; set => iranyitoszam = value; }
        public string Varos { get => varos; set => varos = value; }
        public string Utca { get => utca; set => utca = value; }
        public string Utca_jellege { get => utca_jellege; set => utca_jellege = value; }
        public string Hazszam { get => hazszam; set => hazszam = value; }
        public string Epulet { get => epulet; set => epulet = value; }
        public string Emelet { get => emelet; set => emelet = value; }
        public string Ajto { get => ajto; set => ajto = value; }

        public LocalUser(long felhasznaloid, string nev, string email, string jelszo, string telefonszam, string szemelyi_szam, DateTime szuletesi_datum, bool ceg, string cegnev, string ceg_tipus, string ado_szam, string bankszamlaszam, string orszag, string iranyitoszam, string varos, string utca, string utca_jellege, string hazszam, string epulet, string emelet, string ajto)
        {
            Felhasznaloid = felhasznaloid;
            Nev = nev;
            Email = email;
            Jelszo = jelszo;
            Telefonszam = telefonszam;
            Szemelyi_szam = szemelyi_szam;
            Szuletesi_datum = szuletesi_datum;
            Ceg = ceg;
            Cegnev = cegnev;
            Ceg_tipus = ceg_tipus;
            Ado_szam = ado_szam;
            Bankszamlaszam = bankszamlaszam;
            Orszag = orszag;
            Iranyitoszam = iranyitoszam;
            Varos = varos;
            Utca = utca;
            Utca_jellege = utca_jellege;
            Hazszam = hazszam;
            Epulet = epulet;
            Emelet = emelet;
            Ajto = ajto;
        }

        public LocalUser()
        {

        }

      

        public override string ToString()
        {
            return $"{this.nev} {this.email} {this.jelszo}";
        }
    }



       
    
}
