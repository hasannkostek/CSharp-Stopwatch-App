using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre_Uygulaması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stopwatch km = new Stopwatch(); // c# kütüphanesi kullandık ("using System.Diagnostics;")
        
        private void buttonBasla_Click(object sender, EventArgs e)
        {
            if (!km.IsRunning) // kronometre çalışmıyorsa
            {
                km.Start();
            }
            buttonBasla.Enabled = false;
            buttonBasla.BackColor = Color.Red;
        }

        private void buttonBekle_Click(object sender, EventArgs e)
        {
            
            if (km.IsRunning)
            {
                km.Stop();
                buttonBekle.Text = "Devam Et";
                buttonBekle.BackColor = Color.Orange;
            }
            else
            {
                km.Start();
                buttonBekle.Text = "Bekle";
                buttonBekle.BackColor = Color.Yellow;
            }
            

       
            
        }

        private void buttonTekrar_Click(object sender, EventArgs e)
        {
            labelKronometre.Text = "00:00:00:00:000";
            km.Reset();
            buttonBasla.Enabled = true;
            buttonBasla.BackColor = Color.Lime;
            buttonBekle.Text = "Bekle";
            buttonBekle.BackColor = Color.Yellow;
            listBoxKayitlar.Items.Add("---------------------------------------------");
        }

        private void timerKronometre_Tick(object sender, EventArgs e)
        {
            if (km.IsRunning)
            {
                TimeSpan ts = km.Elapsed; // geçen zaman aralığını belirttik
                labelKronometre.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                    ts.Hours, ts.Minutes , ts.Seconds , ts.Milliseconds);
            }
            
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            listBoxKayitlar.Items.Add(labelKronometre.Text);
        }
    }
}
