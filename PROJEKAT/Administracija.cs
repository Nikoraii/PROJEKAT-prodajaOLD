using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace PROJEKAT
{
    public partial class Administracija : Form
    {
        public Administracija()
        {
            InitializeComponent();
        }

        private void Administracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Administracija_Load(object sender, EventArgs e)
        {
            cbKategorije.Items.Clear();

            Dictionary<string, string> dct = new Dictionary<string, string>();
            var data = Database.select("SELECT kategorijaID FROM proizvodi", dct);
            var dt = new DataTable();
            dt.Load(data);
            List<DataRow> lista = dt.AsEnumerable().ToList();
            List<string> kategorije = new List<string>();

            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\PROJEKAT\fajlovi\kategorije.txt";
            foreach (var linija in lista)
            {
                if (!(kategorije.Contains(linija.ItemArray[0].ToString())))
                {
                    kategorije.Add(linija.ItemArray[0].ToString());
                }
            }

            List<string> kategorije_fajl = new List<string>();
            string contents = File.ReadAllText(putanja);
            foreach (var pisikateg in kategorije)
            {
                if (!(contents.Contains(pisikateg)))
                {
                    kategorije_fajl.Add(pisikateg);
                }
            }

            File.AppendAllLines(putanja, kategorije_fajl);

            var lista_file = File.ReadAllLines(putanja);
            foreach (var kat in lista_file)
            {
                cbKategorije.Items.Add(kat);
            }

            cbKategorije.SelectedIndex = 0;

            foreach (var kat2 in lista_file)
            {
                lbSveKategorije.Items.Add(kat2);
            }
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            var izabrano = cbKategorije.SelectedItem.ToString();
            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\PROJEKAT\fajlovi\kategorije.txt";
            var lista_file = File.ReadAllLines(putanja);

            var kategorija = "";
            
            kategorija = izabrano;
            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("@kategorija", kategorija);
            var data = Database.select("SELECT naziv_artikla, id FROM proizvodi WHERE kategorijaID = @kategorija", dct);
            var dt = new DataTable();
            dt.Load(data);
            if(dt.Rows.Count > 0)
            {
                lbProizvodi.DataSource = dt;
                lbProizvodi.DisplayMember = "naziv_artikla";
                lbProizvodi.ValueMember = "id";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbProizvodi.Items.Clear();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var kategorija = cbKategorije.SelectedItem.ToString();
            var naziv = tbNaziv.Text;
            var cena = tbCena.Text;
            var mera = tbMera.Text;

            if (naziv == "" || cena == "" || mera == "")
            {
                MessageBox.Show("Niste popunili svako polje");
            }
            else
            {
                Dictionary<string, string> dct = new Dictionary<string, string>();
                dct.Add("@naziv", naziv);
                dct.Add("@cena", cena);
                dct.Add("@mera", mera);
                dct.Add("@kategorija", kategorija);

                Database.insert("INSERT INTO proizvodi (naziv_artikla, cena_artikla, mera_artikla, kategorijaID) VALUES (@naziv, @cena, @mera, @kategorija)", dct);
                MessageBox.Show("Uspesno ste uneli artikal!");

                Dictionary<string, string> dctN = new Dictionary<string, string>();
                dctN.Add("@kategorija", kategorija);
                var data = Database.select("SELECT naziv_artikla, id FROM proizvodi WHERE kategorijaID = @kategorija", dctN);

                var dt = new DataTable();
                dt.Load(data);
                if (dt.Rows.Count > 0)
                {
                    lbProizvodi.DataSource = dt;
                    lbProizvodi.DisplayMember = "naziv_artikla";
                    lbProizvodi.ValueMember = "id";
                }
            }
        }

        private void lbProizvodi_Click(object sender, EventArgs e)
        {
            tbNaziv.Text = lbProizvodi.Text;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var kategorija = cbKategorije.SelectedItem.ToString();
            //var izmeni_id = lbProizvodi.SelectedValue;
            //MessageBox.Show(izmeni_id);
            var naziv = tbNaziv.Text;
            var cena = tbCena.Text;
            var mera = tbMera.Text;
            if (naziv == "" || cena == "" || mera == "")
            {
                MessageBox.Show("Niste popunili svako polje");
            }
            else
            {
                var izmeni_id = lbProizvodi.SelectedValue.ToString();
                //MessageBox.Show(izmeni_id);
                Dictionary<string, string> dct = new Dictionary<string, string>();
                dct.Add("@id", izmeni_id);
                dct.Add("@naziv", naziv);
                dct.Add("@cena", cena);
                dct.Add("@mera", mera);
                Database.update("UPDATE proizvodi SET naziv_artikla = @naziv, cena_artikla = @cena, mera_artikla = @mera WHERE id = @id", dct);

                Dictionary<string, string> dctN = new Dictionary<string, string>();
                dctN.Add("@kategorija", kategorija);
                var data = Database.select("SELECT naziv_artikla, id FROM proizvodi WHERE kategorijaID = @kategorija", dctN);

                var dt = new DataTable();
                dt.Load(data);
                if (dt.Rows.Count > 0)
                {
                    lbProizvodi.DataSource = dt;
                    lbProizvodi.DisplayMember = "naziv_artikla";
                    lbProizvodi.ValueMember = "id";
                }

                MessageBox.Show("Uspesno ste izmenili artikal!");

                tbNaziv.Text = "";
                tbCena.Text = "";
                tbMera.Text = "";
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var naziv = tbNaziv.Text;
            if(naziv == "")
            {
                MessageBox.Show("Izaberite sta zelite obrisati.");
            }
            else
            {
                var kategorija = cbKategorije.SelectedItem.ToString();
                var obrisi_id = lbProizvodi.SelectedValue.ToString();
                Dictionary<string, string> dct = new Dictionary<string, string>();
                dct.Add("@id", obrisi_id);
                Database.delete("DELETE FROM proizvodi WHERE id = @id", dct);

                MessageBox.Show("Uspesno ste obrisali artikal!");
                tbNaziv.Text = "";

                Dictionary<string, string> dctN = new Dictionary<string, string>();
                dctN.Add("@kategorija", kategorija);
                var data = Database.select("SELECT naziv_artikla, id FROM proizvodi WHERE kategorijaID = @kategorija", dctN);

                var dt = new DataTable();
                dt.Load(data);
                if (dt.Rows.Count > 0)
                {
                    lbProizvodi.DataSource = dt;
                    lbProizvodi.DisplayMember = "naziv_artikla";
                    lbProizvodi.ValueMember = "id";
                }
            }
        }

        private void tbAdminKat_Click(object sender, EventArgs e)
        {
            //
        }

        private void lbSveKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzmeniKat.Enabled = true;
            btnObrisiKat.Enabled = true;
            tbPromeniNazivKat.Text = lbSveKategorije.SelectedItem.ToString();
        }

        private void btnDodajKat_Click(object sender, EventArgs e)
        {
            var nova_kat = tbPromeniNazivKat.Text;
            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\PROJEKAT\fajlovi\kategorije.txt";
            File.AppendAllText(putanja, nova_kat);
            MessageBox.Show("Uspesno ste uneli kategoriju!");
        }

        private void btnIzmeniKat_Click(object sender, EventArgs e)
        {
            var izmeni_kat = tbPromeniNazivKat.Text;
            var stara_kat = lbSveKategorije.SelectedItem.ToString();

            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("@kategorija", izmeni_kat);
            dct.Add("@kategorija_stara", stara_kat);
            Database.update("UPDATE proizvodi SET kategorijaID = @kategorija WHERE kategorijaID = @kategorija_stara", dct);

            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\PROJEKAT\fajlovi\kategorije.txt";
            string strFile = File.ReadAllText(putanja);
            strFile = Regex.Replace(strFile, stara_kat, izmeni_kat);
            File.WriteAllText(putanja, strFile);

            MessageBox.Show("Uspesno ste promenili ime kategorije!");
        }

        private void btnObrisiKat_Click(object sender, EventArgs e)
        {
            var obrisi_kat = tbPromeniNazivKat.Text;

            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("@kategorija_del", obrisi_kat);
            Database.delete("DELETE FROM proizvodi WHERE kategorijaID = @kategorija_del", dct);
            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\PROJEKAT\fajlovi\kategorije.txt";
            string strFile = File.ReadAllText(putanja);
            strFile = Regex.Replace(strFile, obrisi_kat, string.Empty);
            File.WriteAllText(putanja, strFile);

            MessageBox.Show("Uspesno ste obrisali kategoriju!");
        }
    }
}
