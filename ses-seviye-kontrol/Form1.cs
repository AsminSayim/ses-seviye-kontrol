using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ses_seviye_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBarSes_Scroll(object sender, EventArgs e)
        {
            int deger = tBarSes.Value;

            lblSesDeger.Text=deger.ToString();

            if(deger>=0 && deger <25)
            {
                lblSesSeviye.Text = "Ses Seviyesi Düşük";
                this.BackColor = Color.Yellow;
            }
            else if (deger>=25 && deger <70)
            {
                lblSesSeviye.Text = "Ses Seviyesi Normal";
                this.BackColor = Color.Red;
            }
            else if (deger>=70 && deger < 90)
            {
                lblSesSeviye.Text = "Ses Seviyesi Yüksek";
                this.BackColor= Color.Green;
            }
            else
            {
                lblSesSeviye.Text = "Ses Seviyesi Çok Yüksek";
                this.BackColor=Color.Blue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSesSeviyesi.Text = "Ses Seviyesi Düşük";
            this.BackColor = Color.Yellow;
            lblSesDeger.Text = "0";
        }
    }
}
