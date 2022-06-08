using LocadoraSA.DataBase;
using LocadoraSA.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraSA.Frm
{
    public partial class Frm_CadastroLocações : Form
    {
        private Locações clienteD;

        string Tamanho;
        string Categoria;
        string Cilindradas;
        string GPS;
        string TelaLcd;
        string Fabricante;
        string Modelo;
        string Ano;
        string PainelDigital;
        string Cambio;
        string Combustivel;
        string DatadeFabricação;
        string ValorCompra;
        string Placa;
        string CPF;
        string DataLocacao;
        string DataDevolucao;
        string KmInicial;
        string KmFinal;
        string Nome;
        string Sobrenome;
        string Senha;
        string Endereco;
        string Telefone;
        string Email;
        string CNH;
        string CEP;


        public Frm_CadastroLocações(string CPF, string Placa, string DataLocacao, string DataDevolucao, string KmInicial, string KmFinal)
        {
            InitializeComponent();
            Txt_Cpf.Text = CPF;
            Txt_Placa.Text = Placa;
            Txt_Locacao.Text = DataLocacao;
            Txt_Devolução.Text = DataDevolucao;
            Txt_KmInicial.Text = KmInicial;
            Txt_KmFinal.Text = KmFinal;
            
        }
        public Frm_CadastroLocações()
        {
            InitializeComponent();

        }

        public void salvarRegistro()
        {
            try
            {
                this.clienteD = new Locações();
                this.clienteD.CPF = Txt_Cpf.Text;
                this.clienteD.Placa = Txt_Placa.Text;
                this.clienteD.DataLocacao = Txt_Locacao.Text;
                this.clienteD.DataDevolucao = Txt_Devolução.Text;
                this.clienteD.KmInicial = Txt_KmInicial.Text;
                this.clienteD.KmFinal = Txt_KmFinal.Text;
                this.clienteD.CadastrarCliente();
                this.clienteD.AlterarLocacao();
                MessageBox.Show("Locação salva com sucesso.");
                this.Close();
            }
            catch (Exception c)
            {
                if (c.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Usuário Já existe! ", "Erro no Formulário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Lbl_Cpf.ForeColor = Color.Red;
                    this.Lbl_Cpf.Text = "CPF Duplicado";
                }
                else
                {
                    MessageBox.Show("Não é possivel conectar no banco de dados!" + c.Message, "Erro no salvamentoo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Txt_Cpf.Text.Equals(""))
            {
                Lbl_Cpf.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu primeiro nome.");
                return;
            }
            if (Txt_Placa.Text.Equals(""))
            {
                Lbl_Placa.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu ultimo nome.");
                return;
            }
            if (Txt_Locacao.Text.Equals(""))
            {
                Lbl_Locacao.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu telefone.");
                return;
            }
            if (Txt_Devolução.Text.Equals(""))
            {
                Lbl_Devolução.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu email.");
                return;
            }
            if (Txt_KmInicial.Text.Equals(""))
            {
                Lbl_kmInicial.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu nome de usuario");
                return;
            }
            if (Txt_KmFinal.Text.Equals(""))
            {
                Lbl_KmFinal.ForeColor = Color.Red;
                MessageBox.Show("Informe a sua senha");
                return;
            }
            salvarRegistro();
        }

        private void Lbl_Tamanho_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente cadastrar = new Frm_CadastroCliente();
            cadastrar.Show();
        }

        public void ListarClientes()
        {
            this.clienteD = new Locações();
            MySqlDataReader temp = this.clienteD.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_ListarClientes.DataSource = dt;
        }
        private void DataGrid_ListarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = DataGrid_ListarClientes.Rows[e.RowIndex];
            CPF = linha.Cells[0].Value.ToString();
            Nome = linha.Cells[1].Value.ToString();
            Sobrenome = linha.Cells[2].Value.ToString();
            Senha = linha.Cells[3].Value.ToString();
            Endereco = linha.Cells[4].Value.ToString();
            Telefone = linha.Cells[5].Value.ToString();
            Email = linha.Cells[6].Value.ToString();
            CNH = linha.Cells[7].Value.ToString();
            CEP = linha.Cells[8].Value.ToString();
        }

        private void ListarCarros()
        {
            this.clienteD = new Locações();
            MySqlDataReader temp = this.clienteD.ListarCarros();
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_ListarLocado.DataSource = dt;
        }
        private void DataGrid_ListarLocado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = DataGrid_ListarLocado.Rows[e.RowIndex];
            Placa = linha.Cells[13].Value.ToString();
            Tamanho = linha.Cells[0].Value.ToString();
            Categoria = linha.Cells[1].Value.ToString();
            Cilindradas = linha.Cells[2].Value.ToString();
            GPS = linha.Cells[3].Value.ToString();
            TelaLcd = linha.Cells[4].Value.ToString();
            Fabricante = linha.Cells[5].Value.ToString();
            Modelo = linha.Cells[6].Value.ToString();
            Ano = linha.Cells[7].Value.ToString();
            PainelDigital = linha.Cells[8].Value.ToString();
            Cambio = linha.Cells[9].Value.ToString();
            Combustivel = linha.Cells[10].Value.ToString();
            DatadeFabricação = linha.Cells[11].Value.ToString();
            ValorCompra = linha.Cells[12].Value.ToString();
            
        }

        private void ListarLocados()
        {
            this.clienteD = new Locações();
            MySqlDataReader temp = this.clienteD.ListarLocados();
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_ListarDisponiveis.DataSource = dt;
        }
        private void DataGrid_ListarDisponiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = DataGrid_ListarDisponiveis.Rows[e.RowIndex];
            CPF = linha.Cells[0].Value.ToString();
            Placa = linha.Cells[1].Value.ToString();
            DataLocacao = linha.Cells[2].Value.ToString();
            DataDevolucao = linha.Cells[3].Value.ToString();
            KmInicial = linha.Cells[4].Value.ToString();
            KmFinal = linha.Cells[5].Value. ToString();
        }

        private void Frm_CadastroLocações_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarCarros();
            ListarLocados();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
        }

        
        //termino do liostar clientes
        // botoes do clientes
        private void Btn_BuscarVeiculoLocado_Click(object sender, EventArgs e)
        {
            String Filtro = Txt_BuscarVeiculoLocado.Text;
            MySqlDataReader temp = this.clienteD.ListarLocados(Filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_ListarDisponiveis.DataSource = dt;
        }







        //public void listarClientes()
        //{
        //    this.clienteD = new Locações();
        //    MySqlDataReader temp = this.clienteD.ListarClientes();
        //    DataTable dt = new DataTable();
        //    dt.Load(temp);
        //    DataGrid_ListarClientes.DataSource = dt;
        //}

        //private void DataGrid_ListarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //        DataGridViewRow linha = DataGrid_ListarClientes.Rows[e.RowIndex];
        //        Tamanho = linha.Cells[0].Value.ToString();
        //        Categoria = linha.Cells[1].Value.ToString();
        //        Cilindradas = linha.Cells[2].Value.ToString();
        //        GPS = linha.Cells[3].Value.ToString();
        //        TelaLcd = linha.Cells[4].Value.ToString();
        //        Fabricante = linha.Cells[5].Value.ToString();
        //        Modelo = linha.Cells[6].Value.ToString();
        //        Ano = linha.Cells[7].Value.ToString();
        //        PainelDigital = linha.Cells[8].Value.ToString();
        //        Cambio = linha.Cells[9].Value.ToString();
        //        Combustivel = linha.Cells[10].Value.ToString();
        //        DatadeFabricação = linha.Cells[11].Value.ToString();
        //        ValorCompra = linha.Cells[12].Value.ToString();
        //        Placa = linha.Cells[13].Value.ToString();
        //        Lbl_PlacaDoCarro.Text = Modelo;
        //        Lbl_ModeloDoCarro.Text = Placa;

        //}
    }
}
