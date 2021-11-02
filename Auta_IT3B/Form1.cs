using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auta_IT3B
{
    public partial class Form1 : Form
    {
        Auto nakladak;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nakladak = new Auto("2BB 10-25", 7500);
            ZobrazAuto(nakladak);
        }

        private void ZobrazAuto(Auto auto)
        {
            lblZnacka.Text = auto.Znacka;
            lblNosnost.Text = $"{auto.Nosnost} kg";
            lblNaklad.Text = $"{auto.Naklad} kg";
        }

        private void btnNalozit1000_Click(object sender, EventArgs e)
        {
            var nalozeno = nakladak.Nalozit(1000);
            ZobrazAuto(nakladak);
            MessageBox.Show($"Naloženo {nalozeno} kg");
        }

        private void btnNalozit2000_Click(object sender, EventArgs e)
        {
            var nalozeno = nakladak.Nalozit(2000);
            ZobrazAuto(nakladak);
            MessageBox.Show($"Naloženo {nalozeno} kg");
        }

        private void btnNalozit3000_Click(object sender, EventArgs e)
        {
            var nalozeno = nakladak.Nalozit(3000);
            ZobrazAuto(nakladak);
            MessageBox.Show($"Naloženo {nalozeno} kg");
        }

        private void Nalozit_Click(object sender, EventArgs e)
        {
            var nalozeno = nakladak.Nalozit(Convert.ToInt32(numNalozitNaklad.Value));
            ZobrazAuto(nakladak);
            MessageBox.Show($"Naloženo {nalozeno} kg");
        }

        private void btnVylozit_Click(object sender, EventArgs e)
        {
            var nalozeno = nakladak.Vylozit(Convert.ToInt32(numNalozitNaklad.Value));
            ZobrazAuto(nakladak);
            MessageBox.Show($"Vyloženo {nalozeno} kg");
        }

        private void btnParkovat_Click(object sender, EventArgs e)
        {
            var nalozeno = nakladak.Zaparkovat();
            ZobrazAuto(nakladak);
            MessageBox.Show($"Vyloženo {nalozeno} kg");
        }
    }
}
