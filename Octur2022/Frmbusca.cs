using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;


namespace Octur2022
{
    public partial class Frmbusca : Form
    {
        public Frmbusca()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig() {
            AuthSecret ="eP9qNzZLr3pufmpKLdHAGEwkxQM2QVtdZ4FoWJNP",
            BasePath = "https://octurbd-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient viagens;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("If the file save fails, do you want to automatically try again?",
                     "Save file");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                viagens = new FireSharp.FirebaseClient(fcon);
             }
            catch
            {
                MessageBox.Show("Verifique sua conexão.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label17_Click(object sender, EventArgs e)
        {

        }


       
    }
}
