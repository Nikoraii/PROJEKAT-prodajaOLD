using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new Administracija();
            admin.Show();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prodaja = new Prodaja();
            prodaja.Show();
        }
    }
}
