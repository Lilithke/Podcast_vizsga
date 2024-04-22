namespace Podcast_vizsga
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Felhasználónév = new System.Windows.Forms.Label();
            this.textBox_FelhasznaloNev = new System.Windows.Forms.TextBox();
            this.Jelszó = new System.Windows.Forms.Label();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.Belépés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Felhasználónév
            // 
            this.Felhasználónév.AutoSize = true;
            this.Felhasználónév.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Felhasználónév.Font = new System.Drawing.Font("Oswald", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Felhasználónév.ForeColor = System.Drawing.Color.SteelBlue;
            this.Felhasználónév.Location = new System.Drawing.Point(388, 202);
            this.Felhasználónév.Name = "Felhasználónév";
            this.Felhasználónév.Size = new System.Drawing.Size(191, 48);
            this.Felhasználónév.TabIndex = 0;
            this.Felhasználónév.Text = "Felhasználónév";
            // 
            // textBox_FelhasznaloNev
            // 
            this.textBox_FelhasznaloNev.Location = new System.Drawing.Point(399, 267);
            this.textBox_FelhasznaloNev.Name = "textBox_FelhasznaloNev";
            this.textBox_FelhasznaloNev.Size = new System.Drawing.Size(168, 22);
            this.textBox_FelhasznaloNev.TabIndex = 1;
            // 
            // Jelszó
            // 
            this.Jelszó.AutoSize = true;
            this.Jelszó.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jelszó.ForeColor = System.Drawing.Color.SteelBlue;
            this.Jelszó.Location = new System.Drawing.Point(448, 304);
            this.Jelszó.Name = "Jelszó";
            this.Jelszó.Size = new System.Drawing.Size(70, 39);
            this.Jelszó.TabIndex = 0;
            this.Jelszó.Text = "jelszó";
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Location = new System.Drawing.Point(399, 356);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(168, 22);
            this.textBox_Jelszo.TabIndex = 2;
            // 
            // Belépés
            // 
            this.Belépés.BackColor = System.Drawing.Color.SteelBlue;
            this.Belépés.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Belépés.Font = new System.Drawing.Font("Oswald", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Belépés.ForeColor = System.Drawing.Color.GhostWhite;
            this.Belépés.Location = new System.Drawing.Point(399, 422);
            this.Belépés.Name = "Belépés";
            this.Belépés.Size = new System.Drawing.Size(168, 32);
            this.Belépés.TabIndex = 3;
            this.Belépés.Text = "Belépés";
            this.Belépés.UseVisualStyleBackColor = false;
            this.Belépés.Click += new System.EventHandler(this.Belépés_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Podcast_vizsga.Properties.Resources.background_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.Belépés);
            this.Controls.Add(this.textBox_Jelszo);
            this.Controls.Add(this.Jelszó);
            this.Controls.Add(this.textBox_FelhasznaloNev);
            this.Controls.Add(this.Felhasználónév);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Felhasználónév;
        private System.Windows.Forms.TextBox textBox_FelhasznaloNev;
        private System.Windows.Forms.Label Jelszó;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.Button Belépés;
    }
}

