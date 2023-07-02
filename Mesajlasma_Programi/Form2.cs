using System;
using System.IO;
using System.Windows.Forms;

namespace Mesajlasma_Programi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string kad;
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Mesaj.txt", true);
            sw.WriteLine(comboBox1.Text + ";" + textBox1.Text + ";" + dateTimePicker1.Text);
            sw.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\kullanicilar.txt", true);
            while (!sr.EndOfStream)
            {
                string st = sr.ReadLine();
                string[] dizi = st.Split(';');
                comboBox1.Items.Add(dizi[0]);
            }
            sr.Close();


            StreamReader sr1 = new StreamReader(Application.StartupPath + "\\Mesaj.txt");
            while (!sr1.EndOfStream)
            {
                string st = sr1.ReadLine();
                string[] dizi1 = st.Split(';');
                if (kad == dizi1[0])
                {
                    listBox1.Items.Add(dizi1[1] + " " + dizi1[2]);
                }
            }
            sr1.Close();

        }

    }
}
