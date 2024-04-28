using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Podcast_vizsga;
using System.Configuration;
using System.Management.Instrumentation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace Podcast_vizsga
{
    public partial class FormMain : Form
    {
     
       

        public FormMain()
        {
            InitializeComponent();
        }

       

        public void FormMain_Load(object sender, EventArgs e)
        {
            
           dateTimePicker_szul.MinDate = DateTime.Now.AddYears(-120);
           dateTimePicker_szul.MaxDate = DateTime.Now.AddYears(-18);
           dateTimePicker_szul.Value = DateTime.Now.AddYears(-30);
           dateTimePicker_szul.Checked = false;

           tabControl_Ossz.TabPages.Remove(tabPage_ceg);
            

            Listafrissitese();
         
     
        }

        private void Szovegmezo()
        {
            numericUpDown_id.Value = numericUpDown_id.Minimum;
            textBox_Nev.Text = string.Empty;
            textBox_Email.Text = string.Empty;
            textBox_Jelszo.Text = string.Empty;
            textBox_Telefonsz.Text = string.Empty;
            textBox_szemSzam.Text = string.Empty;
            dateTimePicker_szul.Checked = false;
            checkBox_Ceg.Checked = false;
            textBox_CegNev.Text = string.Empty;
            textBox_cegtipus.Text = string.Empty;
            textBox_adoszam.Text = string.Empty;
            textBox_bankszamlaszam.Text = string.Empty;
            textBox_Orszag.Text = string.Empty;
            textBox_Varos.Text = string.Empty;
            textBox_iranyitoSzam.Text = string.Empty;
            textBox_utca.Text = string.Empty;
            textBox_utcaJellege.Text = string.Empty;
            textBox_hazszam.Text = string.Empty;
            textBox_epulet.Text = string.Empty;
            textBox_lepcsohaz.Text = string.Empty;
            textBox_Emelet.Text = string.Empty;
            textBox_ajto.Text = string.Empty;
        }



        public void Listafrissitese()
        {
            Listbox_ugyfelek.Items.Clear();

            var sor =  Program.db.GetAllUsers();
            foreach ( var user in sor )
            {
                Listbox_ugyfelek.Items.Add(user);
            }

        }

        

        private void buttonÚj_Click(object sender, EventArgs e)

        {
            LocalUser localUser = new LocalUser();

            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nincs megadva név!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nev.Select();
                return;
            }
            if (textBox_Nev.Text.Length<3)
            {
                MessageBox.Show("Névmegadása kötelező!");
                textBox_Nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                MessageBox.Show("Nincs megadva Email cím!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Jelszo.Text))
            {
                MessageBox.Show("Nincs megadva Jelszó!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Jelszo.Select();
                return;
            }
            if (textBox_Jelszo.Text.Length < 8)
            {
                MessageBox.Show("A jelszó legalább 8 karakterű legyen!");
                textBox_Nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Telefonsz.Text))
            {
                MessageBox.Show("Nincs megadva Telefonszám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Telefonsz.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_szemSzam.Text))
            {
                MessageBox.Show("Nincs megadva Személyi szám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_szemSzam.Select();
                return;
            }
            

            if (checkBox_Ceg.Checked == true)
            {
                if (string.IsNullOrEmpty(textBox_CegNev.Text))
                {
                    MessageBox.Show("Nincs megadva Cégnév!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_CegNev.Select();
                    return;
                }

                if (string.IsNullOrEmpty(textBox_cegtipus.Text))
                {
                    MessageBox.Show("Nincs megadva Cég tipus!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_cegtipus.Select();
                    return;
                }
                if (string.IsNullOrEmpty(textBox_adoszam.Text))
                {
                    MessageBox.Show("Nincs megadva Adószám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_adoszam.Select();
                    return;
                }
                if (string.IsNullOrEmpty(textBox_bankszamlaszam.Text))
                {
                    MessageBox.Show("Nincs megadva Bankszámlaszám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_bankszamlaszam.Select();
                    return;
                }
            }

            if (string.IsNullOrEmpty(textBox_Orszag.Text))
            {
                MessageBox.Show("Nincs megadva Ország!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Orszag.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_iranyitoSzam.Text))
            {
                MessageBox.Show("Nincs megadva Irányítószám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_iranyitoSzam.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_Varos.Text))
            {
                MessageBox.Show("Nincs megadva Város!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Varos.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_utca.Text))
            {
                MessageBox.Show("Nincs megadva utca!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_utca.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_utcaJellege.Text))
            {
                MessageBox.Show("Nincs megadva utca jellege!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_utcaJellege.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_hazszam.Text))
            {
                MessageBox.Show("Nincs megadva házszám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_hazszam.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_epulet.Text))
            {
                MessageBox.Show("Nincs megadva Épület!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_epulet.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_lepcsohaz.Text))
            {
                MessageBox.Show("Nincs megadva Lépcsőház!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_lepcsohaz.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Emelet.Text))
            {
                MessageBox.Show("Nincs megadva emelet!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Emelet.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_ajto.Text))
            {
                MessageBox.Show("Nincs megadva ajtó!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ajto.Select();
                return;
            }


            if (dateTimePicker_szul.Checked == false)
            {
                MessageBox.Show("Születési idő megadása kötelező!", "Hiányzó adat!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_szul.Select();
                return;
            }


            
                localUser.Felhasznaloid = (long)numericUpDown_id.Value;
                localUser.Nev = textBox_Nev.Text;
                localUser.Email = textBox_Email.Text;
                localUser.Jelszo = textBox_Jelszo.Text;
                localUser.Telefonszam = textBox_Telefonsz.Text;
                localUser.Szemelyi_szam = textBox_szemSzam.Text;
                localUser.Szuletesi_datum = dateTimePicker_szul.Value;
                localUser.Ceg = checkBox_Ceg.Checked;
                localUser.Cegnev = textBox_CegNev.Text;
                localUser.Ceg_tipus = textBox_cegtipus.Text;
                localUser.Ado_szam = textBox_adoszam.Text;
                localUser.Bankszamlaszam = textBox_bankszamlaszam.Text;
                localUser.Orszag = textBox_Orszag.Text;
                localUser.Varos = textBox_Varos.Text;
                localUser.Iranyitoszam = textBox_iranyitoSzam.Text;
                localUser.Utca = textBox_utca.Text;
                localUser.Utca_jellege = textBox_utcaJellege.Text;
                localUser.Hazszam = textBox_hazszam.Text;
                localUser.Epulet = textBox_epulet.Text;
                localUser.Lepcsohaz = textBox_lepcsohaz.Text;
                localUser.Emelet = textBox_Emelet.Text;
                localUser.Ajto = textBox_ajto.Text;
            

            


            //Register

            Program.db.NewUsers(localUser);

            Listafrissitese();

            if (numericUpDown_id.Value != 0)
            {
                MessageBox.Show("Az új ügyfél felvétele sikertelen!");
            }
            else
            {
                MessageBox.Show("Az új ügyfél felvétele sikeres!");
            }


            Szovegmezo();
            

        }

        private void checkBox_Ceg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Ceg.Checked == true)
            {
                tabControl_Ossz.TabPages.Insert(1, tabPage_ceg);
            }
            else
            {
                tabControl_Ossz.TabPages.Remove(tabPage_ceg);
            }
        }

        //list
        public void buttonList_Click(object sender, EventArgs e)
        {
            Listafrissitese();
        }

        private void Listbox_ugyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalUser localUser = (LocalUser) Listbox_ugyfelek.SelectedItem;


            numericUpDown_id.Value = (ulong) localUser.Felhasznaloid;
            textBox_Nev.Text = localUser.Nev.ToString();
            textBox_Email.Text = localUser.Email.ToString();
            textBox_Jelszo.Text = localUser.Jelszo.ToString();
            textBox_Telefonsz.Text = localUser.Telefonszam.ToString();
            textBox_szemSzam.Text = localUser.Szemelyi_szam.ToString();
            dateTimePicker_szul.Value = DateTime.Parse(localUser.Szuletesi_datum.ToString());
            checkBox_Ceg.Checked = localUser.Ceg;
            textBox_CegNev.Text = localUser.Cegnev.ToString();
            textBox_cegtipus.Text=localUser.Ceg_tipus.ToString();
            textBox_adoszam.Text = localUser.Ado_szam.ToString();
            textBox_bankszamlaszam.Text = localUser.Bankszamlaszam.ToString();
            textBox_Orszag.Text = localUser.Orszag.ToString();
            textBox_Varos.Text = localUser.Varos.ToString();
            textBox_iranyitoSzam.Text = localUser.Iranyitoszam.ToString();
            textBox_utca.Text = localUser.Utca.ToString();
            textBox_utcaJellege.Text = localUser.Utca_jellege.ToString();
            textBox_hazszam.Text=localUser.Hazszam.ToString();
            textBox_epulet.Text = localUser.Epulet.ToString();
            textBox_lepcsohaz.Text = localUser.Lepcsohaz.ToString();
            textBox_Emelet.Text = localUser.Emelet.ToString();
            textBox_ajto.Text = localUser.Ajto.ToString();
            
    
        }

        public void button_modosit_Click(object sender, EventArgs e)
        {
            LocalUser localUser = new LocalUser();

            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
            }

            if (textBox_Nev.Text.Length < 3)
            {
                MessageBox.Show("Névmegadása kötelező!","Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                MessageBox.Show("Nincs megadva Email cím!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Jelszo.Text))
            {
                MessageBox.Show("Nincs megadva Jelszó!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Jelszo.Select();
                return;
            }
            if (textBox_Jelszo.Text.Length < 8)
            {
                MessageBox.Show("A jelszó legalább 8 karakterű legyen!");
                textBox_Nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Telefonsz.Text))
            {
                MessageBox.Show("Nincs megadva Telefonszám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Telefonsz.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_szemSzam.Text))
            {
                MessageBox.Show("Nincs megadva Személyi szám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_szemSzam.Select();
                return;
            }


            if (checkBox_Ceg.Checked == true)
            {
                if (string.IsNullOrEmpty(textBox_CegNev.Text))
                {
                    MessageBox.Show("Nincs megadva Cégnév!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_CegNev.Select();
                    return;
                }

                if (string.IsNullOrEmpty(textBox_cegtipus.Text))
                {
                    MessageBox.Show("Nincs megadva Cég tipus!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_cegtipus.Select();
                    return;
                }
                if (string.IsNullOrEmpty(textBox_adoszam.Text))
                {
                    MessageBox.Show("Nincs megadva Adószám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_adoszam.Select();
                    return;
                }
                if (string.IsNullOrEmpty(textBox_bankszamlaszam.Text))
                {
                    MessageBox.Show("Nincs megadva Bankszámlaszám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_bankszamlaszam.Select();
                    return;
                }
            }

            if (string.IsNullOrEmpty(textBox_Orszag.Text))
            {
                MessageBox.Show("Nincs megadva Ország!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Orszag.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_iranyitoSzam.Text))
            {
                MessageBox.Show("Nincs megadva Irányítószám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_iranyitoSzam.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_Varos.Text))
            {
                MessageBox.Show("Nincs megadva Város!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Varos.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_utca.Text))
            {
                MessageBox.Show("Nincs megadva utca!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_utca.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_utcaJellege.Text))
            {
                MessageBox.Show("Nincs megadva utca jellege!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_utcaJellege.Select();
                return;
            }

            if (string.IsNullOrEmpty(textBox_hazszam.Text))
            {
                MessageBox.Show("Nincs megadva házszám!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_hazszam.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_epulet.Text))
            {
                MessageBox.Show("Nincs megadva Épület!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_epulet.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_lepcsohaz.Text))
            {
                MessageBox.Show("Nincs megadva Lépcsőház!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_lepcsohaz.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Emelet.Text))
            {
                MessageBox.Show("Nincs megadva emelet!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Emelet.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox_ajto.Text))
            {
                MessageBox.Show("Nincs megadva ajtó!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ajto.Select();
                return;
            }


            if (dateTimePicker_szul.Checked == false)
            {
                MessageBox.Show("Születési idő megadása kötelező!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_szul.Select();
                return;
            }

            
            localUser.Felhasznaloid = (long)numericUpDown_id.Value;
            localUser.Nev = textBox_Nev.Text;
            localUser.Email = textBox_Email.Text;
            localUser.Jelszo = textBox_Jelszo.Text;
            localUser.Telefonszam = textBox_Telefonsz.Text;
            localUser.Szemelyi_szam = textBox_szemSzam.Text;
            localUser.Szuletesi_datum = dateTimePicker_szul.Value; 
            localUser.Ceg = checkBox_Ceg.Checked;
            localUser.Cegnev = textBox_CegNev.Text;
            localUser.Ceg_tipus = textBox_cegtipus.Text;
            localUser.Ado_szam = textBox_adoszam.Text;
            localUser.Bankszamlaszam = textBox_bankszamlaszam.Text;
            localUser.Orszag = textBox_Orszag.Text;
            localUser.Varos = textBox_Varos.Text;
            localUser.Iranyitoszam = textBox_iranyitoSzam.Text;
            localUser.Utca = textBox_utca.Text;
            localUser.Utca_jellege = textBox_utcaJellege.Text;
            localUser.Hazszam = textBox_hazszam.Text;
            localUser.Epulet = textBox_epulet.Text;
            localUser.Lepcsohaz = textBox_lepcsohaz.Text;
            localUser.Emelet = textBox_Emelet.Text;
            localUser.Ajto = textBox_ajto.Text;
            

            //Change
            

            Program.db.UpdateUsers(localUser);

            Listafrissitese();

            //Message

            if (localUser.Nev.GetType() == typeof(string))
            {
                MessageBox.Show("Módosítás sikeres!");
            }
            else { MessageBox.Show("Módosítás sikertelen!"); }

           

        }



        private void buttonTorles_Click(object sender, EventArgs e)
        {


            if ((long)numericUpDown_id.Value == 0)
            {
                MessageBox.Show("Nincs kiválasztott Ügyfél!");

            }
            else
            {
                bool dialog = MessageBox.Show("Valóban törölni szeretné?") == DialogResult.Yes;
                
           

                if(dialog == true) {

                    // Delete

                    Program.db.DeleteUsers((long)numericUpDown_id.Value);

                    Listafrissitese();
    
                    Szovegmezo();

                    if (numericUpDown_id.Value != 0)
                    {
                        MessageBox.Show("Az ügyfél törlése sikertelen!");
                    }
                    else
                    {
                    MessageBox.Show("Az ügyfél törlése sikeres!");
                    }


                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

       
    }
}
