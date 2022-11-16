using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;
using System.Linq;

namespace PROJEKAT
{
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();
        }

        private void Prodaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Prodaja_Load(object sender, EventArgs e)
        {
            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\PROJEKAT\fajlovi\kategorije.txt";
            var lista_file = File.ReadAllLines(putanja);
            var pozicijaX = 50;
            foreach (var kat in lista_file)
            {
                var btn1 = new System.Windows.Forms.Button();
                pnKategorije.Controls.Add(btn1);
                btn1.BackColor = System.Drawing.Color.White;
                btn1.Location = new System.Drawing.Point(pozicijaX, 0);
                btn1.Name = "btnKAT" + kat.ToString();
                btn1.Size = new System.Drawing.Size(100, 80);
                btn1.TabIndex = 0;
                btn1.Text = kat.ToString();
                btn1.UseVisualStyleBackColor = false;
                pozicijaX += 110;
                btn1.Click += new System.EventHandler(btn1_Click);
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            pnProizvodi.Controls.Clear();
            var kategorija = ((Button)sender).Text;
            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("@kategorija", kategorija);
            var data = Database.select("SELECT naziv_artikla, id, cena_artikla FROM proizvodi WHERE kategorijaID = @kategorija", dct);
            var dt = new DataTable();
            dt.Load(data);
            var pozicijaX = 50;
            List<DataRow> lista = dt.AsEnumerable().ToList();
            foreach (var item in lista)
            {
                var btn2 = new System.Windows.Forms.Button();
                //var cena = item.ItemArray[2];
                pnProizvodi.Controls.Add(btn2);
                btn2.BackColor = System.Drawing.Color.White;
                btn2.Location = new System.Drawing.Point(pozicijaX, 0);
                btn2.Name = /**"btnITEM" + **/item.ItemArray[2].ToString();
                btn2.Size = new System.Drawing.Size(100, 80);
                btn2.TabIndex = 0;
                btn2.Text = item.ItemArray[0].ToString();
                btn2.UseVisualStyleBackColor = false;
                pozicijaX += 110;
                btn2.Click += new System.EventHandler(btn2_Click);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            tbCal.Text = "";
            //MessageBox.Show(((Button)sender).Name);
            tbCal.Text = ((Button)sender).Text;
            //MessageBox.Show(((Button)sender).Name);
            pnCal.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            tbCal.Text += " " + btnX.Text + " ";
        }

        private void btnCal7_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal7.Text;
        }

        private void btnCal8_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal8.Text;
        }

        private void btnCal6_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal6.Text;
        }

        private void btnCal5_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal5.Text;
        }

        private void btnCal4_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal4.Text;
        }

        private void btnCal3_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal3.Text;
        }

        private void btnCal2_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal2.Text;
        }

        private void btnCal1_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal1.Text;
        }

        private void btnCal0_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal0.Text;
        }

        private void btnCal9_Click(object sender, EventArgs e)
        {
            tbCal.Text += btnCal9.Text;
        }

        private void btnCalPonisti_Click(object sender, EventArgs e)
        {
            tbCal.Text = "";
            pnCal.Hide();
        }

        private void btnCalUnesi_Click(object sender, EventArgs e)
        {
            var rezultat = tbCal.Text.ToString();
            string[] rrezultat = rezultat.Split('X');
            lbUnos.Items.Add(tbCal.Text);
            //MessageBox.Show(rrezultat[0].ToString());
            tbCal.Text = rrezultat[0];
        }

        private void btnObrisiRacun_Click(object sender, EventArgs e)
        {
            lbUnos.Items.Clear();
            tbRacun.Text = "";
            lbRacun.Items.Clear();
            tpKontrola.SelectTab(tpUnos);
        }

        private void btnNovaTran_Click(object sender, EventArgs e)
        {
            pnProizvodi.Controls.Clear();
            lbUnos.Items.Clear();
            tbRacun.Text = "";
            lbRacun.Items.Clear();
            tpKontrola.SelectTab(tpUnos);
            pnCal.Hide();
        }

        private void tbRacun_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            //tbRacun.Text = imestr[1];
            double cena = 0;
            foreach (var item in lbUnos.Items)
            {
                var ime = item.ToString();
                string[] imestr = ime.Split('X');
                var artikal_ime = imestr[0];
                var artikal_kolicina = 1;
                try { 
                    artikal_kolicina = Convert.ToInt32(imestr[1]); 
                } catch (Exception) { 
                }
                var artikal_kolicinaint = Convert.ToInt32(artikal_kolicina);
                Dictionary<string, string> dct = new Dictionary<string, string>();
                dct.Add("@naziv", artikal_ime);
                var data = Database.select("SELECT naziv_artikla, id, cena_artikla FROM proizvodi WHERE naziv_artikla = @naziv", dct);
                var dt = new DataTable();
                dt.Load(data);
                List<DataRow> lista = dt.AsEnumerable().ToList();
                foreach (var item2 in lista)
                {
                    var cenastr = item2.ItemArray[2].ToString();
                    cena += (Convert.ToDouble(cenastr)) * artikal_kolicinaint;
                }
            }
            //MessageBox.Show(cena.ToString());
            tbRacun.Text = cena.ToString();
            btnPlati.Enabled = true;
            
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            tpKontrola.SelectTab(tpRacun);
            foreach (var item in lbUnos.Items)
            {
                lbRacun.Items.Add(item);
            }

            lbRacun.Items.Add("\n--------------\n");
            lbRacun.Items.Add("UKUPNA CENA: ");

            lbRacun.Items.Add(tbRacun.Text);
        }
    }
}
