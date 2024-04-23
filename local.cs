using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_vizsga
{
    internal class local
    {
        public int felhasznaloid;
        public string nev;
        public string email;
        public string jelszo;
        public string telefonszam;
        public string szemelyi_szam;
        public DateTime szuletesi_datum;

        public bool ceg;
        public string cegnev;
        public string ceg_tipus;
        public string ado_szam;
        public string bankszamlaszam;

        public string orszag;
        public string iranyitoszam;
        public string varos;
        public string utca;
        public string utca_jellege;
        public string hazszam;
        public string epulet;
        public string emelet;
        public string ajto;

        public TimestampInformation created_at;
        public TimestampInformation updated_at;

        public local(int felhasznaloid, string nev, string email, string jelszo, string telefonszam, string szemelyi_szam, DateTime szuletesi_datum, bool ceg, string cegnev, string ceg_tipus, string ado_szam, string bankszamlaszam, string orszag, string iranyitoszam, string varos, string utca, string utca_jellege, string hazszam, string epulet, string emelet, string ajto, TimestampInformation created_at, TimestampInformation updated_at)
        {
            this.felhasznaloid = felhasznaloid;
            this.nev = nev;
            this.email = email;
            this.jelszo = jelszo;
            this.telefonszam = telefonszam;
            this.szemelyi_szam = szemelyi_szam;
            this.szuletesi_datum = szuletesi_datum;
            this.ceg = ceg;
            this.cegnev = cegnev;
            this.ceg_tipus = ceg_tipus;
            this.ado_szam = ado_szam;
            this.bankszamlaszam = bankszamlaszam;
            this.orszag = orszag;
            this.iranyitoszam = iranyitoszam;
            this.varos = varos;
            this.utca = utca;
            this.utca_jellege = utca_jellege;
            this.hazszam = hazszam;
            this.epulet = epulet;
            this.emelet = emelet;
            this.ajto = ajto;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }
    }
}
