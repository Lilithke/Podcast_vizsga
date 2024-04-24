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

namespace Podcast_vizsga
{
    public partial class FormMain : Form
    {


        HttpClient client = new HttpClient();
        string endpoint = ReadSetting("endpoint");
        public string jsonString;

       public static string ReadSetting(string endpoint)
        {
            string result = null;
            try
            {
                var value = endpoint;
               // var value = ConfigurationManager.AppSettings;
                result = value;
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public FormMain()
        {
            InitializeComponent();
        }

       

      public void FormMain_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("4", "4|MdKgA82Hu4XfBkXXTV749dOzzczMS4nYkwgpumafac093d81");
           dateTimePicker_szul.MinDate = DateTime.Now.AddYears(-120);
           dateTimePicker_szul.MaxDate = DateTime.Now.AddYears(-18);
           dateTimePicker_szul.Value = DateTime.Now.AddYears(-30);
           dateTimePicker_szul.Checked = false;

           tabControl_Ossz.TabPages.Remove(tabPage_ceg);
            //tabControl_Ossz.TabPages.Insert(1,tabPage_ceg);

            Listafrissitese();
     
        }

       public void Listafrissitese()
        {
            Listbox_ugyfelek.Items.Clear();
            Listbox_ugyfelek.Items.AddRange(Program.db.GetAllUsers().ToArray());
            
          /*  try
            {
                
                HttpResponseMessage response = await client.GetAsync(Program.endpoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonstring = await response.Content.ReadAsStringAsync();
                    var users = Users.FromJson(jsonString);
                    //foreach (Users item in users)
                    //{
                    //    Listbox_ugyfelek.Items.Add(item);
                    //}
                        
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/
            
        }

        private void buttonÚj_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nincs megadva név!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nev.Select();
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
            }
            else
            {
                MessageBox.Show("Adatok beírása az adatbázisba!", "Sikeres adatbevitel!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

      public void buttonList_Click(object sender, EventArgs e)
        {
            Listafrissitese();
        }
    }
}
