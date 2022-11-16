
namespace PROJEKAT
{
    partial class Administracija
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
            this.tbKontrola = new System.Windows.Forms.TabControl();
            this.tbAzuriranje = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMera = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.lbProizvodi = new System.Windows.Forms.ListBox();
            this.tbAdminKat = new System.Windows.Forms.TabPage();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lbSveKategorije = new System.Windows.Forms.ListBox();
            this.tbPromeniNazivKat = new System.Windows.Forms.TextBox();
            this.btnDodajKat = new System.Windows.Forms.Button();
            this.btnIzmeniKat = new System.Windows.Forms.Button();
            this.btnObrisiKat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKontrola.SuspendLayout();
            this.tbAzuriranje.SuspendLayout();
            this.tbAdminKat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKontrola
            // 
            this.tbKontrola.Controls.Add(this.tbAzuriranje);
            this.tbKontrola.Controls.Add(this.tbAdminKat);
            this.tbKontrola.Location = new System.Drawing.Point(-1, 0);
            this.tbKontrola.Name = "tbKontrola";
            this.tbKontrola.SelectedIndex = 0;
            this.tbKontrola.Size = new System.Drawing.Size(800, 451);
            this.tbKontrola.TabIndex = 0;
            // 
            // tbAzuriranje
            // 
            this.tbAzuriranje.Controls.Add(this.btnObrisi);
            this.tbAzuriranje.Controls.Add(this.btnIzmeni);
            this.tbAzuriranje.Controls.Add(this.btnDodaj);
            this.tbAzuriranje.Controls.Add(this.label4);
            this.tbAzuriranje.Controls.Add(this.label3);
            this.tbAzuriranje.Controls.Add(this.label2);
            this.tbAzuriranje.Controls.Add(this.label1);
            this.tbAzuriranje.Controls.Add(this.tbMera);
            this.tbAzuriranje.Controls.Add(this.tbCena);
            this.tbAzuriranje.Controls.Add(this.tbNaziv);
            this.tbAzuriranje.Controls.Add(this.cbKategorije);
            this.tbAzuriranje.Controls.Add(this.lbProizvodi);
            this.tbAzuriranje.Location = new System.Drawing.Point(4, 22);
            this.tbAzuriranje.Name = "tbAzuriranje";
            this.tbAzuriranje.Padding = new System.Windows.Forms.Padding(3);
            this.tbAzuriranje.Size = new System.Drawing.Size(792, 425);
            this.tbAzuriranje.TabIndex = 0;
            this.tbAzuriranje.Text = "Azuriranje artikala";
            this.tbAzuriranje.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jedinica mere artikla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv artikla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategorija";
            // 
            // tbMera
            // 
            this.tbMera.Location = new System.Drawing.Point(89, 213);
            this.tbMera.Name = "tbMera";
            this.tbMera.Size = new System.Drawing.Size(177, 20);
            this.tbMera.TabIndex = 4;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(89, 165);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(177, 20);
            this.tbCena.TabIndex = 3;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(89, 107);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(177, 20);
            this.tbNaziv.TabIndex = 2;
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(89, 42);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(177, 21);
            this.cbKategorije.TabIndex = 1;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            // 
            // lbProizvodi
            // 
            this.lbProizvodi.FormattingEnabled = true;
            this.lbProizvodi.Location = new System.Drawing.Point(387, 17);
            this.lbProizvodi.Name = "lbProizvodi";
            this.lbProizvodi.Size = new System.Drawing.Size(398, 368);
            this.lbProizvodi.TabIndex = 0;
            this.lbProizvodi.Click += new System.EventHandler(this.lbProizvodi_Click);
            this.lbProizvodi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbAdminKat
            // 
            this.tbAdminKat.Controls.Add(this.label5);
            this.tbAdminKat.Controls.Add(this.btnObrisiKat);
            this.tbAdminKat.Controls.Add(this.btnIzmeniKat);
            this.tbAdminKat.Controls.Add(this.btnDodajKat);
            this.tbAdminKat.Controls.Add(this.tbPromeniNazivKat);
            this.tbAdminKat.Controls.Add(this.lbSveKategorije);
            this.tbAdminKat.Location = new System.Drawing.Point(4, 22);
            this.tbAdminKat.Name = "tbAdminKat";
            this.tbAdminKat.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdminKat.Size = new System.Drawing.Size(792, 425);
            this.tbAdminKat.TabIndex = 1;
            this.tbAdminKat.Text = "Azuriranje Kategorija";
            this.tbAdminKat.UseVisualStyleBackColor = true;
            this.tbAdminKat.Click += new System.EventHandler(this.tbAdminKat_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(92, 256);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(174, 34);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj artikal";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(92, 296);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(174, 36);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni artikal";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(92, 338);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(174, 34);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi artikal";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lbSveKategorije
            // 
            this.lbSveKategorije.FormattingEnabled = true;
            this.lbSveKategorije.Location = new System.Drawing.Point(501, 12);
            this.lbSveKategorije.Name = "lbSveKategorije";
            this.lbSveKategorije.Size = new System.Drawing.Size(284, 407);
            this.lbSveKategorije.TabIndex = 0;
            this.lbSveKategorije.SelectedIndexChanged += new System.EventHandler(this.lbSveKategorije_SelectedIndexChanged);
            // 
            // tbPromeniNazivKat
            // 
            this.tbPromeniNazivKat.Location = new System.Drawing.Point(115, 180);
            this.tbPromeniNazivKat.Name = "tbPromeniNazivKat";
            this.tbPromeniNazivKat.Size = new System.Drawing.Size(264, 20);
            this.tbPromeniNazivKat.TabIndex = 1;
            // 
            // btnDodajKat
            // 
            this.btnDodajKat.Location = new System.Drawing.Point(115, 224);
            this.btnDodajKat.Name = "btnDodajKat";
            this.btnDodajKat.Size = new System.Drawing.Size(264, 38);
            this.btnDodajKat.TabIndex = 2;
            this.btnDodajKat.Text = "Dodaj Kategoriju";
            this.btnDodajKat.UseVisualStyleBackColor = true;
            this.btnDodajKat.Click += new System.EventHandler(this.btnDodajKat_Click);
            // 
            // btnIzmeniKat
            // 
            this.btnIzmeniKat.Enabled = false;
            this.btnIzmeniKat.Location = new System.Drawing.Point(115, 286);
            this.btnIzmeniKat.Name = "btnIzmeniKat";
            this.btnIzmeniKat.Size = new System.Drawing.Size(264, 38);
            this.btnIzmeniKat.TabIndex = 3;
            this.btnIzmeniKat.Text = "Izmeni Kategoriju";
            this.btnIzmeniKat.UseVisualStyleBackColor = true;
            this.btnIzmeniKat.Click += new System.EventHandler(this.btnIzmeniKat_Click);
            // 
            // btnObrisiKat
            // 
            this.btnObrisiKat.Enabled = false;
            this.btnObrisiKat.Location = new System.Drawing.Point(115, 343);
            this.btnObrisiKat.Name = "btnObrisiKat";
            this.btnObrisiKat.Size = new System.Drawing.Size(264, 38);
            this.btnObrisiKat.TabIndex = 4;
            this.btnObrisiKat.Text = "Obrisi Kategoriju";
            this.btnObrisiKat.UseVisualStyleBackColor = true;
            this.btnObrisiKat.Click += new System.EventHandler(this.btnObrisiKat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Naziv kategorije";
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKontrola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Administracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administracija_FormClosing);
            this.Load += new System.EventHandler(this.Administracija_Load);
            this.tbKontrola.ResumeLayout(false);
            this.tbAzuriranje.ResumeLayout(false);
            this.tbAzuriranje.PerformLayout();
            this.tbAdminKat.ResumeLayout(false);
            this.tbAdminKat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbKontrola;
        private System.Windows.Forms.TabPage tbAzuriranje;
        private System.Windows.Forms.ListBox lbProizvodi;
        private System.Windows.Forms.TabPage tbAdminKat;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMera;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnObrisiKat;
        private System.Windows.Forms.Button btnIzmeniKat;
        private System.Windows.Forms.Button btnDodajKat;
        private System.Windows.Forms.TextBox tbPromeniNazivKat;
        private System.Windows.Forms.ListBox lbSveKategorije;
    }
}