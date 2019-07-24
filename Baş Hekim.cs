using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem_odevi
{
    public partial class Baş_Hekim : Form
    {
        public Baş_Hekim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bashekimDoktorEkleme ke = new bashekimDoktorEkleme();
            ke.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Baş_Hekim_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            duyuruEkrani YapDuyuru = new duyuruEkrani();
            YapDuyuru.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HastaArama2 araHasta = new HastaArama2();
            araHasta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hemsireBolumGorevleri hemsireGor = new hemsireBolumGorevleri();
            hemsireGor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PoliKlinikler poli = new PoliKlinikler();
            poli.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RandevuEkrani1 randevu = new RandevuEkrani1();
            randevu.Show();


        }
    }
}
