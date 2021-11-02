using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace aysentekeliformödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Random rnd = new Random();
        int toplam =0;
        int saniye = 10;

        Button btn = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            btntimer.Start();
            oyunTimer.Start();
        }

        private void btntimer_Tick(object sender, EventArgs e)
        {
            
            btn.Size = new Size(rnd.Next(20, 100), 50);
            btn.Location = new Point(rnd.Next(this.Width), rnd.Next(this.Height));
            btn.Text = rnd.Next(10, 100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
                
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblpuan.Text = ($"Puanınız:{toplam}");
            


        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            btn.Size = panel1.ClientSize;
            btn.Size = this.ClientSize;

        }

        private void oyunTimer_Tick(object sender, EventArgs e)
        {
            saniye = saniye - 1;
            lblsüre.Text = Convert.ToString(saniye);
            lblsüre.Text = $"Kalan Süre:{saniye}";
            if (lblsüre.Text == "Kalan Süre:0")
            {
                btntimer.Stop();
                oyunTimer.Stop();
                btn.Visible = false;

                string puan = @"Puanlar.txt";
                FileStream dy = new FileStream(puan, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter yaz = new StreamWriter(dy);
                yaz.WriteLine(yaz);
                yaz.Close();
            }


        }
    }
}
