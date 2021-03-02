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
    public partial class Unos : Form
    {
        List<Osoba> listaOsoba = new List<Osoba>();
        
        
        public Unos()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(txtBoxIme.Text, txtBoxPrezime.Text, txtBoxOib.Text, txtBoxDatum.Text);
            listaOsoba.Add(osoba);
            Form1 form = new Form1(listaOsoba);
            this.Hide();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
