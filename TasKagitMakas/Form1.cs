using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] taskagitmakas = { "Tas", "Kagit", "Makas" }; 

        void cagir()
        {
            int deger;
            Random random = new Random();
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                lblBot.Text = taskagitmakas[0];
            }
            else if (deger == 2)
            {
                lblBot.Text = taskagitmakas[1];
            }
            else if (deger == 3)
            {
                lblBot.Text = taskagitmakas[2];
            }
        }

        void btnrenk()
        {
            if (lblBot.Text == taskagitmakas[0])
            {
                btnTas2.BackColor = Color.Blue;
                btnKagıt2.BackColor = Color.FromArgb(51, 102, 255);
                btnMakas2.BackColor = Color.FromArgb(51, 102, 255);
            }
            else if (lblBot.Text == taskagitmakas[1])
            {
                btnKagıt2.BackColor = Color.Blue;
                btnTas2.BackColor = Color.FromArgb(51, 102, 255);
                btnMakas2.BackColor = Color.FromArgb(51, 102, 255);
            }
            else if (lblBot.Text == taskagitmakas[2])
            {
                btnMakas2.BackColor = Color.Blue;
                btnKagıt2.BackColor = Color.FromArgb(51, 102, 255);
                btnTas2.BackColor = Color.FromArgb(51, 102, 255);
            }
        }

        int skor1 = 0, skor2 = 0;

        private void btnTas1_Click(object sender, EventArgs e)
        {
            lblOyuncu.Text = taskagitmakas[0];
            cagir();
            btnTas1.BackColor = Color.Blue;
            btnMakas1.BackColor = Color.FromArgb(0, 102, 255);
            btnKagıt1.BackColor = Color.FromArgb(0, 102, 255);
            btnrenk();
            if (lblBot.Text == taskagitmakas[2])
            {
                skor1 = skor1 + 1;
                lblSkor1.Text = skor1.ToString();
            }
            else if(lblBot.Text == taskagitmakas[1])
            {
                skor2 += 1;
                lblSkor2.Text = skor2.ToString();
            }
        }

        private void btnKagıt1_Click(object sender, EventArgs e)
        {
            lblOyuncu.Text = taskagitmakas[1];
            cagir() ;
            btnKagıt1.BackColor = Color.Blue;
            btnTas1.BackColor = Color.FromArgb(0, 102, 255);
            btnMakas1.BackColor = Color.FromArgb(0, 102, 255);
            btnrenk();
            if (lblBot.Text == taskagitmakas[0])
            {
                skor1 = skor1 + 1;
                lblSkor1.Text = skor1.ToString();
            }
            else if (lblBot.Text == taskagitmakas[2])
            {
                skor2 += 1;
                lblSkor2.Text = skor2.ToString();
            }

        }

        

        private void btnMakas1_Click(object sender, EventArgs e)
        {
            lblOyuncu.Text = taskagitmakas[2];
            cagir();
            btnMakas1.BackColor = Color.Blue;
            btnTas1.BackColor = Color.FromArgb(0, 102, 255);
            btnKagıt1.BackColor = Color.FromArgb(0, 102, 255);
            btnrenk();
            if (lblBot.Text == taskagitmakas[1])
            {
                skor1 = skor1 + 1;
                lblSkor1.Text = skor1.ToString();
            }
            else if (lblBot.Text == taskagitmakas[0])
            {
                skor2 += 1;
                lblSkor2.Text = skor2.ToString();
            }
        }

        
    }
}
