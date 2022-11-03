
namespace Octur2022
{
    partial class Frmcadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cidadetbox = new System.Windows.Forms.TextBox();
            this.paistbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btncadas = new System.Windows.Forms.Button();
            this.iniciodt = new System.Windows.Forms.DateTimePicker();
            this.fimdt = new System.Windows.Forms.DateTimePicker();
            this.valordt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnconsul = new System.Windows.Forms.Button();
            this.numpc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paisOrigembox = new System.Windows.Forms.TextBox();
            this.paisbox = new System.Windows.Forms.TextBox();
            this.cidadeOrigembox = new System.Windows.Forms.TextBox();
            this.cidadebox = new System.Windows.Forms.TextBox();
            this.diaEntradabox = new System.Windows.Forms.TextBox();
            this.cidadeDestinobox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.paisDestinobox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dataViagembox = new System.Windows.Forms.TextBox();
            this.idpassagembox = new System.Windows.Forms.TextBox();
            this.horario = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.valorbox = new System.Windows.Forms.TextBox();
            this.tipoQuartobox = new System.Windows.Forms.TextBox();
            this.idVagabox = new System.Windows.Forms.TextBox();
            this.valorHotelDiaria = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.Preço = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultaPassagem = new System.Windows.Forms.Button();
            this.AtualizarVoo = new System.Windows.Forms.Button();
            this.DeleteVoo = new System.Windows.Forms.Button();
            this.cadastrarHoteis = new System.Windows.Forms.Button();
            this.consultaHoteis = new System.Windows.Forms.Button();
            this.AtualizarHoteis = new System.Windows.Forms.Button();
            this.DeleteHotel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cidadetbox
            // 
            this.cidadetbox.Location = new System.Drawing.Point(92, 92);
            this.cidadetbox.Name = "cidadetbox";
            this.cidadetbox.Size = new System.Drawing.Size(142, 20);
            this.cidadetbox.TabIndex = 34;
            // 
            // paistbox
            // 
            this.paistbox.Location = new System.Drawing.Point(92, 48);
            this.paistbox.Name = "paistbox";
            this.paistbox.Size = new System.Drawing.Size(142, 20);
            this.paistbox.TabIndex = 37;
            this.paistbox.TextChanged += new System.EventHandler(this.paistbox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Pais ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "inicio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "fim";
            // 
            // btncadas
            // 
            this.btncadas.Location = new System.Drawing.Point(92, 272);
            this.btncadas.Name = "btncadas";
            this.btncadas.Size = new System.Drawing.Size(62, 23);
            this.btncadas.TabIndex = 44;
            this.btncadas.Text = "cadastrar";
            this.btncadas.UseVisualStyleBackColor = true;
            this.btncadas.Click += new System.EventHandler(this.btncadas_Click);
            // 
            // iniciodt
            // 
            this.iniciodt.Location = new System.Drawing.Point(92, 134);
            this.iniciodt.Name = "iniciodt";
            this.iniciodt.Size = new System.Drawing.Size(142, 20);
            this.iniciodt.TabIndex = 45;
            // 
            // fimdt
            // 
            this.fimdt.Location = new System.Drawing.Point(92, 172);
            this.fimdt.Name = "fimdt";
            this.fimdt.Size = new System.Drawing.Size(142, 20);
            this.fimdt.TabIndex = 46;
            // 
            // valordt
            // 
            this.valordt.Location = new System.Drawing.Point(92, 246);
            this.valordt.Name = "valordt";
            this.valordt.Size = new System.Drawing.Size(142, 20);
            this.valordt.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "valor";
            // 
            // btnconsul
            // 
            this.btnconsul.Location = new System.Drawing.Point(172, 272);
            this.btnconsul.Name = "btnconsul";
            this.btnconsul.Size = new System.Drawing.Size(62, 23);
            this.btnconsul.TabIndex = 49;
            this.btnconsul.Text = "consultar";
            this.btnconsul.UseVisualStyleBackColor = true;
            this.btnconsul.Click += new System.EventHandler(this.btnconsul_Click);
            // 
            // numpc
            // 
            this.numpc.Location = new System.Drawing.Point(92, 210);
            this.numpc.Name = "numpc";
            this.numpc.Size = new System.Drawing.Size(142, 20);
            this.numpc.TabIndex = 50;
            this.numpc.TextChanged += new System.EventHandler(this.numpc_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Nº  pacote";
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(92, 317);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(62, 23);
            this.btnatualizar.TabIndex = 52;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(172, 317);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(62, 23);
            this.btndeletar.TabIndex = 53;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Pacotes completos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Cadastro de Passagens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cadastro de Hoteis";
            // 
            // paisOrigembox
            // 
            this.paisOrigembox.Location = new System.Drawing.Point(409, 50);
            this.paisOrigembox.Name = "paisOrigembox";
            this.paisOrigembox.Size = new System.Drawing.Size(170, 20);
            this.paisOrigembox.TabIndex = 57;
            // 
            // paisbox
            // 
            this.paisbox.Location = new System.Drawing.Point(711, 48);
            this.paisbox.Name = "paisbox";
            this.paisbox.Size = new System.Drawing.Size(171, 20);
            this.paisbox.TabIndex = 58;
            // 
            // cidadeOrigembox
            // 
            this.cidadeOrigembox.Location = new System.Drawing.Point(409, 124);
            this.cidadeOrigembox.Name = "cidadeOrigembox";
            this.cidadeOrigembox.Size = new System.Drawing.Size(170, 20);
            this.cidadeOrigembox.TabIndex = 59;
            // 
            // cidadebox
            // 
            this.cidadebox.Location = new System.Drawing.Point(711, 85);
            this.cidadebox.Name = "cidadebox";
            this.cidadebox.Size = new System.Drawing.Size(171, 20);
            this.cidadebox.TabIndex = 60;
            // 
            // diaEntradabox
            // 
            this.diaEntradabox.Location = new System.Drawing.Point(711, 117);
            this.diaEntradabox.Name = "diaEntradabox";
            this.diaEntradabox.Size = new System.Drawing.Size(171, 20);
            this.diaEntradabox.TabIndex = 61;
            // 
            // cidadeDestinobox
            // 
            this.cidadeDestinobox.Location = new System.Drawing.Point(409, 159);
            this.cidadeDestinobox.Name = "cidadeDestinobox";
            this.cidadeDestinobox.Size = new System.Drawing.Size(170, 20);
            this.cidadeDestinobox.TabIndex = 62;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(284, -40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 20);
            this.textBox7.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Pais Origem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cidade Origem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Data da Viagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Pais ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Dia de Entrada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "id-Passagens";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Horario";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(622, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "id-agendamento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(340, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 73;
            this.label19.Text = "Pais Destino";
            // 
            // paisDestinobox
            // 
            this.paisDestinobox.Location = new System.Drawing.Point(409, 88);
            this.paisDestinobox.Name = "paisDestinobox";
            this.paisDestinobox.Size = new System.Drawing.Size(170, 20);
            this.paisDestinobox.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(327, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 75;
            this.label20.Text = "Cidade Destino";
            // 
            // dataViagembox
            // 
            this.dataViagembox.Location = new System.Drawing.Point(409, 195);
            this.dataViagembox.Name = "dataViagembox";
            this.dataViagembox.Size = new System.Drawing.Size(170, 20);
            this.dataViagembox.TabIndex = 76;
            // 
            // idpassagembox
            // 
            this.idpassagembox.Location = new System.Drawing.Point(409, 262);
            this.idpassagembox.Name = "idpassagembox";
            this.idpassagembox.Size = new System.Drawing.Size(170, 20);
            this.idpassagembox.TabIndex = 77;
            // 
            // horario
            // 
            this.horario.Location = new System.Drawing.Point(409, 229);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(170, 20);
            this.horario.TabIndex = 78;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(372, 301);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 79;
            this.label21.Text = "Valor";
            // 
            // valorbox
            // 
            this.valorbox.Location = new System.Drawing.Point(409, 298);
            this.valorbox.Name = "valorbox";
            this.valorbox.Size = new System.Drawing.Size(170, 20);
            this.valorbox.TabIndex = 80;
            // 
            // tipoQuartobox
            // 
            this.tipoQuartobox.Location = new System.Drawing.Point(711, 191);
            this.tipoQuartobox.Name = "tipoQuartobox";
            this.tipoQuartobox.Size = new System.Drawing.Size(171, 20);
            this.tipoQuartobox.TabIndex = 81;
            // 
            // idVagabox
            // 
            this.idVagabox.Location = new System.Drawing.Point(711, 152);
            this.idVagabox.Name = "idVagabox";
            this.idVagabox.Size = new System.Drawing.Size(171, 20);
            this.idVagabox.TabIndex = 82;
            // 
            // valorHotelDiaria
            // 
            this.valorHotelDiaria.Location = new System.Drawing.Point(711, 229);
            this.valorHotelDiaria.Name = "valorHotelDiaria";
            this.valorHotelDiaria.Size = new System.Drawing.Size(171, 20);
            this.valorHotelDiaria.TabIndex = 83;
            this.valorHotelDiaria.TextChanged += new System.EventHandler(this.valorHotelDiaria_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(711, 262);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(171, 20);
            this.textBox16.TabIndex = 84;
            // 
            // Preço
            // 
            this.Preço.AutoSize = true;
            this.Preço.Location = new System.Drawing.Point(642, 236);
            this.Preço.Name = "Preço";
            this.Preço.Size = new System.Drawing.Size(61, 13);
            this.Preço.TabIndex = 86;
            this.Preço.Text = "Valor Diaria";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(627, 195);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 13);
            this.label24.TabIndex = 87;
            this.label24.Text = "Tipo de quarto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 88;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cadastroVoos);
            // 
            // btnConsultaPassagem
            // 
            this.btnConsultaPassagem.Location = new System.Drawing.Point(504, 324);
            this.btnConsultaPassagem.Name = "btnConsultaPassagem";
            this.btnConsultaPassagem.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaPassagem.TabIndex = 89;
            this.btnConsultaPassagem.Text = "consultar";
            this.btnConsultaPassagem.UseVisualStyleBackColor = true;
            this.btnConsultaPassagem.Click += new System.EventHandler(this.btnConsultaPassagem_Click);
            // 
            // AtualizarVoo
            // 
            this.AtualizarVoo.Location = new System.Drawing.Point(409, 363);
            this.AtualizarVoo.Name = "AtualizarVoo";
            this.AtualizarVoo.Size = new System.Drawing.Size(75, 23);
            this.AtualizarVoo.TabIndex = 90;
            this.AtualizarVoo.Text = "atualizar";
            this.AtualizarVoo.UseVisualStyleBackColor = true;
            this.AtualizarVoo.Click += new System.EventHandler(this.AtualizarVoo_Click);
            // 
            // DeleteVoo
            // 
            this.DeleteVoo.Location = new System.Drawing.Point(504, 363);
            this.DeleteVoo.Name = "DeleteVoo";
            this.DeleteVoo.Size = new System.Drawing.Size(75, 23);
            this.DeleteVoo.TabIndex = 91;
            this.DeleteVoo.Text = "deletar";
            this.DeleteVoo.UseVisualStyleBackColor = true;
            this.DeleteVoo.Click += new System.EventHandler(this.DeleteVoo_Click);
            // 
            // cadastrarHoteis
            // 
            this.cadastrarHoteis.Location = new System.Drawing.Point(711, 295);
            this.cadastrarHoteis.Name = "cadastrarHoteis";
            this.cadastrarHoteis.Size = new System.Drawing.Size(75, 23);
            this.cadastrarHoteis.TabIndex = 92;
            this.cadastrarHoteis.Text = "cadastrar";
            this.cadastrarHoteis.UseVisualStyleBackColor = true;
            this.cadastrarHoteis.Click += new System.EventHandler(this.cadastrarHoteis_Click);
            // 
            // consultaHoteis
            // 
            this.consultaHoteis.Location = new System.Drawing.Point(807, 295);
            this.consultaHoteis.Name = "consultaHoteis";
            this.consultaHoteis.Size = new System.Drawing.Size(75, 23);
            this.consultaHoteis.TabIndex = 93;
            this.consultaHoteis.Text = "consultar";
            this.consultaHoteis.UseVisualStyleBackColor = true;
            this.consultaHoteis.Click += new System.EventHandler(this.consultaHoteis_Click);
            // 
            // AtualizarHoteis
            // 
            this.AtualizarHoteis.Location = new System.Drawing.Point(711, 333);
            this.AtualizarHoteis.Name = "AtualizarHoteis";
            this.AtualizarHoteis.Size = new System.Drawing.Size(75, 23);
            this.AtualizarHoteis.TabIndex = 94;
            this.AtualizarHoteis.Text = "atualizar";
            this.AtualizarHoteis.UseVisualStyleBackColor = true;
            this.AtualizarHoteis.Click += new System.EventHandler(this.AtualizarHoteis_Click);
            // 
            // DeleteHotel
            // 
            this.DeleteHotel.Location = new System.Drawing.Point(807, 333);
            this.DeleteHotel.Name = "DeleteHotel";
            this.DeleteHotel.Size = new System.Drawing.Size(75, 23);
            this.DeleteHotel.TabIndex = 95;
            this.DeleteHotel.Text = "deletar";
            this.DeleteHotel.UseVisualStyleBackColor = true;
            this.DeleteHotel.Click += new System.EventHandler(this.DeleteHotel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(152, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 206);
            this.dataGridView1.TabIndex = 96;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pais";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dia de Entrada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo de Quarto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 97;
            this.button2.Text = "pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1224, 659);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteHotel);
            this.Controls.Add(this.AtualizarHoteis);
            this.Controls.Add(this.consultaHoteis);
            this.Controls.Add(this.cadastrarHoteis);
            this.Controls.Add(this.DeleteVoo);
            this.Controls.Add(this.AtualizarVoo);
            this.Controls.Add(this.btnConsultaPassagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Preço);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.valorHotelDiaria);
            this.Controls.Add(this.idVagabox);
            this.Controls.Add(this.tipoQuartobox);
            this.Controls.Add(this.valorbox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.horario);
            this.Controls.Add(this.idpassagembox);
            this.Controls.Add(this.dataViagembox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.paisDestinobox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.cidadeDestinobox);
            this.Controls.Add(this.diaEntradabox);
            this.Controls.Add(this.cidadebox);
            this.Controls.Add(this.cidadeOrigembox);
            this.Controls.Add(this.paisbox);
            this.Controls.Add(this.paisOrigembox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numpc);
            this.Controls.Add(this.btnconsul);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.valordt);
            this.Controls.Add(this.fimdt);
            this.Controls.Add(this.iniciodt);
            this.Controls.Add(this.btncadas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.paistbox);
            this.Controls.Add(this.cidadetbox);
            this.Name = "Frmcadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cidadetbox;
        private System.Windows.Forms.TextBox paistbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btncadas;
        private System.Windows.Forms.DateTimePicker iniciodt;
        private System.Windows.Forms.DateTimePicker fimdt;
        private System.Windows.Forms.TextBox valordt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnconsul;
        private System.Windows.Forms.TextBox numpc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paisOrigembox;
        private System.Windows.Forms.TextBox paisbox;
        private System.Windows.Forms.TextBox cidadeOrigembox;
        private System.Windows.Forms.TextBox cidadebox;
        private System.Windows.Forms.TextBox diaEntradabox;
        private System.Windows.Forms.TextBox cidadeDestinobox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox paisDestinobox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox dataViagembox;
        private System.Windows.Forms.TextBox idpassagembox;
        private System.Windows.Forms.TextBox horario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox valorbox;
        private System.Windows.Forms.TextBox tipoQuartobox;
        private System.Windows.Forms.TextBox idVagabox;
        private System.Windows.Forms.TextBox valorHotelDiaria;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label Preço;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultaPassagem;
        private System.Windows.Forms.Button AtualizarVoo;
        private System.Windows.Forms.Button DeleteVoo;
        private System.Windows.Forms.Button cadastrarHoteis;
        private System.Windows.Forms.Button consultaHoteis;
        private System.Windows.Forms.Button AtualizarHoteis;
        private System.Windows.Forms.Button DeleteHotel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
    }
}

