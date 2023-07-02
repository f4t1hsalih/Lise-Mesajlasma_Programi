using System;
using System.IO;
using System.Windows.Forms;

namespace Mesajlasma_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.kad = textBox1.Text;
            StreamReader sr = new StreamReader(Application.StartupPath + "\\kullanicilar.txt");
            while (!sr.EndOfStream)
            {
                string st = sr.ReadLine();
                string[] dizi = st.Split(';');
                for (int i = 0; i < dizi.Length; i++)
                {
                    if ((textBox1.Text == dizi[i]) && (textBox2.Text == dizi[i + 1]))
                    {
                        frm2.ShowDialog();

                    }
                }

            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\kullanicilar.txt", true);
            sw.WriteLine(textBox1.Text + ";" + textBox2.Text);
            MessageBox.Show("Kayıt Başarılıdır.");
            sw.Close();
        }
    }
}
