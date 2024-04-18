using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Podcast_vizsga
{
    public partial class FormMain : Form
    {

        HttpClient client = new HttpClient();
        public FormMain()
        {
            InitializeComponent();
        }

       

        private void FormMain_Load(object sender, EventArgs e)
        {
           dateTimePicker_szul.MinDate = DateTime.Now.AddYears(-120);
           dateTimePicker_szul.MaxDate = DateTime.Now.AddYears(-18);
           dateTimePicker_szul.Value = DateTime.Now.AddYears(-30);
        }

        private void tabPage_cim_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nincs megadva név!","Hiányzó adat!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Adatok beírása az adatbázisba!", "Sikeres adatbevitel!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
