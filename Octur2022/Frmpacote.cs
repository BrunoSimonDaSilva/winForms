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
    public partial class Frmpacote : Form
    {
        public Frmpacote()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig() {
            AuthSecret = "eP9qNzZLr3pufmpKLdHAGEwkxQM2QVtdZ4FoWJNP",
            BasePath = "https://octurbd-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient viagens;

        private void btncadastro_Click(object sender, EventArgs e)
        {
           
        }

        private void Frmpacote_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
