using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svanTipuricProvjeraZnanja
{
    public partial class Form1 : Form
    {
        List<Osoba> lista = new List<Osoba>();
        Unos unos = new Unos();
        public Form1(List<Osoba> listaOsoba)
        {
            InitializeComponent();
            this.lista= listaOsoba;
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            unos.Show();
            this.Hide();
        }

        private void rtbOsobe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
