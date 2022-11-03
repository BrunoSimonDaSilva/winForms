using System;
using System.Windows.Documents;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Data;

namespace Octur2022
{
    public partial class Frmcadastro : Form
    {
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
        public Frmcadastro()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig() {
            AuthSecret = "2GjQGIZghpAEYIEsZ3w6yhmulvdnuW0b5FArWmOT",
            BasePath = "https://octura-ec124-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient viagens;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("If the file save fails, do you want to automatically try again?",
                     "Save file");

        }

        //cadastros
        private void btncadas_Click(object sender, EventArgs e)
        {
            Pacotes std = new Pacotes() {
                pais = paistbox.Text,
                cidade = cidadetbox.Text,
                inicio = iniciodt.Text,
                fim = fimdt.Text,
                numero=numpc.Text,
                valor = valordt.Text,
            };
            var setter = viagens.Set("Lista de Pacotes/"+numpc.Text,std);
            MessageBox.Show("Pacote cadastrado com sucesso");
        }

        private void cadastroVoos(object sender, EventArgs e)
        {
            voos std = new voos() {
                paisOrigem = paisOrigembox.Text,
                paisDestino = paisDestinobox.Text,
                cidadeOrigem = cidadeOrigembox.Text,
                cidadeDestino = cidadeDestinobox.Text,
                dataViagem = dataViagembox.Text,
                horario = horario.Text,
                idpassagem = idpassagembox.Text,
                valor = valorbox.Text
            };
            var setter = viagens.Set("Lista de voos/" + idpassagembox.Text, std);
            MessageBox.Show("Voo cadastrado com sucesso");
        }
        private void cadastrarHoteis_Click(object sender, EventArgs e)
        {
            Hotel std = new Hotel() {
                pais = paisbox.Text,
                cidade = cidadebox.Text,
                diaEntrada = diaEntradabox.Text,
                idVaga = idVagabox.Text,
                tipoQuarto = tipoQuartobox.Text,
                valorHotelDiaria = valorHotelDiaria.Text,
            };
            var setter = viagens.Set("Lista de Hoteis/" + idVagabox.Text, std);
            MessageBox.Show("Hotel cadastrado com sucesso");
        }
        //cadastros

        //consulta
        private void btnconsul_Click(object sender, EventArgs e)
        {
            var result = viagens.Get("Lista de Pacotes/" + numpc.Text);
            Pacotes std = result.ResultAs<Pacotes>();
            paistbox.Text = std.pais;
            cidadetbox.Text = std.cidade;
            iniciodt.Text = std.inicio;
            fimdt.Text = std.fim;
            valordt.Text = std.valor;
            MessageBox.Show("sucesso na busca");
        }

        private void btnConsultaPassagem_Click(object sender, EventArgs e)
        {
            var result = viagens.Get("Lista de voos/" + idpassagembox.Text);
            voos std = result.ResultAs<voos>();
            paisOrigembox.Text = std.paisOrigem;
            paisDestinobox.Text = std.paisDestino;
            cidadeOrigembox.Text = std.cidadeOrigem;
            cidadeDestinobox.Text = std.cidadeDestino;
            dataViagembox.Text = std.dataViagem;
            horario.Text = std.horario;
            valorbox.Text = std.valor;
            MessageBox.Show("sucesso na busca");
        }
        private void consultaHoteis_Click(object sender, EventArgs e)
        {
            var result = viagens.Get("Lista de Hoteis/" + idVagabox.Text);
            Hotel std = result.ResultAs<Hotel>();
            paisbox.Text = std.pais;
            cidadebox.Text = std.cidade;
            diaEntradabox.Text = std.diaEntrada;
            tipoQuartobox.Text = std.tipoQuarto;
            valorHotelDiaria.Text = std.valorHotelDiaria;

            MessageBox.Show("sucesso na busca");
        }
        //consulta

        //atualizar
        private void btnatualizar_Click(object sender, EventArgs e)
        {
            Pacotes std = new Pacotes() {
                pais = paistbox.Text,
                cidade = cidadetbox.Text,
                inicio = iniciodt.Text,
                fim = fimdt.Text,
                numero = numpc.Text,
                valor = valordt.Text,
            };
            var setter = viagens.Update("Lista de Pacotes/" + numpc.Text, std);
            MessageBox.Show("Pacote atualizados com sucesso");
        }

        private void AtualizarVoo_Click(object sender, EventArgs e)
        {
            voos std = new voos() 
            {
                paisOrigem = paisOrigembox.Text,
                paisDestino = paisDestinobox.Text,
                cidadeOrigem = cidadeOrigembox.Text,
                cidadeDestino = cidadeDestinobox.Text,
                dataViagem = dataViagembox.Text,
                horario = horario.Text,
                valor = valorbox.Text,
                idpassagem = idpassagembox.Text,
            };
            var setter = viagens.Update("Lista de voos/" + idpassagembox.Text, std);
            MessageBox.Show("Voo atualizado com sucesso");
        }
        private void AtualizarHoteis_Click(object sender, EventArgs e)
        {
            Hotel std = new Hotel() {
                pais = paisbox.Text,
                cidade = cidadebox.Text,
                diaEntrada = diaEntradabox.Text,
                tipoQuarto = tipoQuartobox.Text,
                valorHotelDiaria = valorHotelDiaria.Text
            };
            var setter = viagens.Update("Lista de Hoteis/" + idVagabox.Text, std);
            MessageBox.Show("Hotel atualizado com sucesso");
        }
        //atualizar

        //Delete
        private void btndeletar_Click(object sender, EventArgs e)
        {
            var setter = viagens.Delete("Lista de Pacotes/" + numpc.Text);
            MessageBox.Show("Pacote deletado com sucesso");
        }

        private void DeleteVoo_Click(object sender, EventArgs e)
        {
            var setter = viagens.Delete("Lista de voos/" + idpassagembox.Text);
            MessageBox.Show("Dado deletado com sucesso");
        }

        private void DeleteHotel_Click(object sender, EventArgs e)
        {
            var setter = viagens.Delete("Lista de Hoteis/" + idVagabox.Text);
            MessageBox.Show("Dado deletado com sucesso");
        }

        private void numpc_TextChanged(object sender, EventArgs e)
        {

        }

        private void paistbox_TextChanged(object sender, EventArgs e)
        {

        }
        //Delete

        //mostrar
        private void button2_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            dt.Columns.Add("pais");
            dt.Columns.Add("tipoQuarto");
            dt.Columns.Add("Valor");
            dt.Columns.Add("idVaga");
            dt.Columns.Add("diaEntrada");
            dt.Columns.Add("Cidade");
            FirebaseResponse res = viagens.Get(@"Counter");
            int Counter = int.Parse(res.ResultAs<string>());

            for (int i= 0; i <= Counter; i++ )
             {
              FirebaseResponse res2 = viagens.Get(@"Sno/" + i + "/idVaga");
            string idVaga = res2.ResultAs<string>();

            var res3 = viagens.Get(@"Lista de Hoteis/" + idVaga);
             Hotel std = res3.ResultAs<Hotel>();

             if(std.pais != "")
             {
             dt.Rows.Add(std.pais, std.diaEntrada, std.cidade, std.tipoQuarto,std.valorHotelDiaria, std.idVaga);
             }
             }

             foreach (DataRow item in dt.Rows)
            {
                dataGridView1.Rows.Add(item.ItemArray);
            } 

        }

        private void valorHotelDiaria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
