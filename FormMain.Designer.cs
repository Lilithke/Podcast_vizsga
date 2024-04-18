namespace Podcast_vizsga
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl_Semely = new System.Windows.Forms.TabControl();
            this.tabPage_szemely = new System.Windows.Forms.TabPage();
            this.Ügyfelek = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonÚj = new System.Windows.Forms.Button();
            this.dateTimePicker_szul = new System.Windows.Forms.DateTimePicker();
            this.label_szulDate = new System.Windows.Forms.Label();
            this.textBox_szemSzam = new System.Windows.Forms.TextBox();
            this.label_szemSzam = new System.Windows.Forms.Label();
            this.textBox_Telefonsz = new System.Windows.Forms.TextBox();
            this.label_Telefon = new System.Windows.Forms.Label();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.label_Jelszo = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label_Nev = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage_cim = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl_Semely.SuspendLayout();
            this.tabPage_szemely.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Semely
            // 
            this.tabControl_Semely.Controls.Add(this.tabPage_szemely);
            this.tabControl_Semely.Controls.Add(this.tabPage2);
            this.tabControl_Semely.Controls.Add(this.tabPage_cim);
            this.tabControl_Semely.Font = new System.Drawing.Font("Oswald", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl_Semely.Location = new System.Drawing.Point(-1, 0);
            this.tabControl_Semely.Name = "tabControl_Semely";
            this.tabControl_Semely.SelectedIndex = 0;
            this.tabControl_Semely.Size = new System.Drawing.Size(968, 537);
            this.tabControl_Semely.TabIndex = 0;
            // 
            // tabPage_szemely
            // 
            this.tabPage_szemely.BackColor = System.Drawing.Color.Black;
            this.tabPage_szemely.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_szemely.BackgroundImage")));
            this.tabPage_szemely.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_szemely.Controls.Add(this.Ügyfelek);
            this.tabPage_szemely.Controls.Add(this.groupBox1);
            this.tabPage_szemely.Font = new System.Drawing.Font("Oswald", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage_szemely.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabPage_szemely.Location = new System.Drawing.Point(4, 35);
            this.tabPage_szemely.Name = "tabPage_szemely";
            this.tabPage_szemely.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_szemely.Size = new System.Drawing.Size(960, 498);
            this.tabPage_szemely.TabIndex = 0;
            this.tabPage_szemely.Text = "Személy";
            // 
            // Ügyfelek
            // 
            this.Ügyfelek.BackColor = System.Drawing.Color.SteelBlue;
            this.Ügyfelek.ForeColor = System.Drawing.Color.White;
            this.Ügyfelek.FormattingEnabled = true;
            this.Ügyfelek.ItemHeight = 26;
            this.Ügyfelek.Location = new System.Drawing.Point(632, 33);
            this.Ügyfelek.Name = "Ügyfelek";
            this.Ügyfelek.Size = new System.Drawing.Size(263, 420);
            this.Ügyfelek.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.buttonTorles);
            this.groupBox1.Controls.Add(this.button_modosit);
            this.groupBox1.Controls.Add(this.buttonList);
            this.groupBox1.Controls.Add(this.buttonÚj);
            this.groupBox1.Controls.Add(this.dateTimePicker_szul);
            this.groupBox1.Controls.Add(this.label_szulDate);
            this.groupBox1.Controls.Add(this.textBox_szemSzam);
            this.groupBox1.Controls.Add(this.label_szemSzam);
            this.groupBox1.Controls.Add(this.textBox_Telefonsz);
            this.groupBox1.Controls.Add(this.label_Telefon);
            this.groupBox1.Controls.Add(this.textBox_Jelszo);
            this.groupBox1.Controls.Add(this.label_Jelszo);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label_Email);
            this.groupBox1.Controls.Add(this.textBox_Nev);
            this.groupBox1.Controls.Add(this.label_Nev);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott Ügyfél";
            // 
            // buttonTorles
            // 
            this.buttonTorles.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTorles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorles.ForeColor = System.Drawing.Color.White;
            this.buttonTorles.Location = new System.Drawing.Point(441, 381);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(105, 32);
            this.buttonTorles.TabIndex = 15;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = false;
            // 
            // button_modosit
            // 
            this.button_modosit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_modosit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_modosit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modosit.ForeColor = System.Drawing.Color.White;
            this.button_modosit.Location = new System.Drawing.Point(306, 381);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(105, 32);
            this.button_modosit.TabIndex = 14;
            this.button_modosit.Text = "Módosít";
            this.button_modosit.UseVisualStyleBackColor = false;
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonList.ForeColor = System.Drawing.Color.White;
            this.buttonList.Location = new System.Drawing.Point(171, 381);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(105, 32);
            this.buttonList.TabIndex = 13;
            this.buttonList.Text = "Listáz";
            this.buttonList.UseVisualStyleBackColor = false;
            // 
            // buttonÚj
            // 
            this.buttonÚj.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonÚj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonÚj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonÚj.ForeColor = System.Drawing.Color.White;
            this.buttonÚj.Location = new System.Drawing.Point(36, 381);
            this.buttonÚj.Name = "buttonÚj";
            this.buttonÚj.Size = new System.Drawing.Size(105, 32);
            this.buttonÚj.TabIndex = 12;
            this.buttonÚj.Text = "Új";
            this.buttonÚj.UseVisualStyleBackColor = false;
            this.buttonÚj.Click += new System.EventHandler(this.buttonÚj_Click);
            // 
            // dateTimePicker_szul
            // 
            this.dateTimePicker_szul.Checked = false;
            this.dateTimePicker_szul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_szul.Location = new System.Drawing.Point(331, 231);
            this.dateTimePicker_szul.Name = "dateTimePicker_szul";
            this.dateTimePicker_szul.ShowCheckBox = true;
            this.dateTimePicker_szul.Size = new System.Drawing.Size(204, 30);
            this.dateTimePicker_szul.TabIndex = 11;
            // 
            // label_szulDate
            // 
            this.label_szulDate.AutoSize = true;
            this.label_szulDate.Font = new System.Drawing.Font("Oswald", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_szulDate.ForeColor = System.Drawing.Color.White;
            this.label_szulDate.Location = new System.Drawing.Point(325, 170);
            this.label_szulDate.Name = "label_szulDate";
            this.label_szulDate.Size = new System.Drawing.Size(125, 31);
            this.label_szulDate.TabIndex = 10;
            this.label_szulDate.Text = "Szüleési dátum";
            // 
            // textBox_szemSzam
            // 
            this.textBox_szemSzam.Location = new System.Drawing.Point(328, 99);
            this.textBox_szemSzam.Name = "textBox_szemSzam";
            this.textBox_szemSzam.Size = new System.Drawing.Size(207, 30);
            this.textBox_szemSzam.TabIndex = 9;
            // 
            // label_szemSzam
            // 
            this.label_szemSzam.AutoSize = true;
            this.label_szemSzam.Font = new System.Drawing.Font("Oswald", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_szemSzam.ForeColor = System.Drawing.Color.White;
            this.label_szemSzam.Location = new System.Drawing.Point(314, 39);
            this.label_szemSzam.Name = "label_szemSzam";
            this.label_szemSzam.Size = new System.Drawing.Size(121, 31);
            this.label_szemSzam.TabIndex = 8;
            this.label_szemSzam.Text = "Személyi szám";
            // 
            // textBox_Telefonsz
            // 
            this.textBox_Telefonsz.Location = new System.Drawing.Point(82, 278);
            this.textBox_Telefonsz.Name = "textBox_Telefonsz";
            this.textBox_Telefonsz.Size = new System.Drawing.Size(207, 30);
            this.textBox_Telefonsz.TabIndex = 7;
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.Font = new System.Drawing.Font("Oswald", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Telefon.ForeColor = System.Drawing.Color.White;
            this.label_Telefon.Location = new System.Drawing.Point(17, 231);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(105, 31);
            this.label_Telefon.TabIndex = 6;
            this.label_Telefon.Text = "Telefonszám";
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Location = new System.Drawing.Point(82, 173);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(207, 30);
            this.textBox_Jelszo.TabIndex = 5;
            // 
            // label_Jelszo
            // 
            this.label_Jelszo.AutoSize = true;
            this.label_Jelszo.Font = new System.Drawing.Font("Oswald", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Jelszo.ForeColor = System.Drawing.Color.White;
            this.label_Jelszo.Location = new System.Drawing.Point(17, 167);
            this.label_Jelszo.Name = "label_Jelszo";
            this.label_Jelszo.Size = new System.Drawing.Size(57, 31);
            this.label_Jelszo.TabIndex = 4;
            this.label_Jelszo.Text = "Jelszó";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(82, 100);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(207, 30);
            this.textBox_Email.TabIndex = 3;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Oswald", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Email.ForeColor = System.Drawing.Color.White;
            this.label_Email.Location = new System.Drawing.Point(14, 103);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(55, 31);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(82, 39);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(207, 30);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Font = new System.Drawing.Font("Oswald", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Nev.ForeColor = System.Drawing.Color.White;
            this.label_Nev.Location = new System.Drawing.Point(17, 39);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(40, 31);
            this.label_Nev.TabIndex = 0;
            this.label_Nev.Text = "Név";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cég";
            // 
            // tabPage_cim
            // 
            this.tabPage_cim.BackColor = System.Drawing.Color.Black;
            this.tabPage_cim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_cim.BackgroundImage")));
            this.tabPage_cim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_cim.Location = new System.Drawing.Point(4, 35);
            this.tabPage_cim.Name = "tabPage_cim";
            this.tabPage_cim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cim.Size = new System.Drawing.Size(960, 498);
            this.tabPage_cim.TabIndex = 2;
            this.tabPage_cim.Text = "Cím";
            this.tabPage_cim.Click += new System.EventHandler(this.tabPage_cim_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(723, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 394);
            this.listBox1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.tabControl_Semely);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl_Semely.ResumeLayout(false);
            this.tabPage_szemely.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Semely;
        private System.Windows.Forms.TabPage tabPage_szemely;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage_cim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker_szul;
        private System.Windows.Forms.Label label_szulDate;
        private System.Windows.Forms.TextBox textBox_szemSzam;
        private System.Windows.Forms.Label label_szemSzam;
        private System.Windows.Forms.TextBox textBox_Telefonsz;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.Label label_Jelszo;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.ListBox Ügyfelek;
        private System.Windows.Forms.Button buttonÚj;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.ListBox listBox1;
    }
}