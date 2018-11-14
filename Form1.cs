using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisiOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int firstHorse, secondHorse, thirdHorse;

        private void Form1_Load(object sender, EventArgs e)
        {
            firstHorse = pictureBox1.Left;
            secondHorse = pictureBox2.Left;
            thirdHorse = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int firstHorseWith = pictureBox1.Width;
            int secondHorseWitdh = pictureBox2.Width;
            int thirdHorseWitdh = pictureBox3.Width;

            int bitis = finish.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 14);
            pictureBox3.Left += rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label5.Text = "Birinci At Yarışı Önde Götürüyor..";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label5.Text = "İkinci At Güzel Bir Atakla Öne Geçti..";
            }

            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label5.Text = "Üçüncü At Bu Yarışı KAzanmayı Çok İstiyor..";
            }


            if (firstHorseWith + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarışı birinci at kazandı.");
            }

            if (secondHorseWitdh + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarışı ikinci at kazandı.");
            }

            if (thirdHorseWitdh + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarışı üçüncü at kazandı.");
            }

        }

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
