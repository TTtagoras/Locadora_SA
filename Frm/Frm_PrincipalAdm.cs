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
    public partial class Frm_PrincipalAdm : Form
    {
        private Veiculos clienteD;

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
        string Nome;
        string Sobrenome;
        string Senha;
        string Endereco;
        string Telefone;
        string Email;
        string CNH;
        string CEP;



        public Frm_PrincipalAdm()
        {
            InitializeComponent();
        }

        //listar veiculos

        private void Frm_PrincipalAdm_Load(object sender, EventArgs e)
        {
            listarClientes();
            listarClientes02();
        }

        public void listarClientes()
        {
            this.clienteD = new Veiculos();
            MySqlDataReader temp = this.clienteD.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_ListarVeiculos.DataSource = dt;
        }

        private void Dgv_QuadroDeHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = DataGrid_ListarVeiculos.Rows[e.RowIndex];
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
            Placa = linha.Cells[13].Value.ToString();
            Lbl_PlacaDoCarro.Text = Modelo;
            Lbl_ModeloDoCarro.Text = Placa;
        }

        private void Btn_BuscarCLiente_Click_1(object sender, EventArgs e)
        {
            String Filtro = Txt_BuscarCarro.Text;
            MySqlDataReader temp = this.clienteD.ListarClientes(Filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_ListarVeiculos.DataSource = dt;
        }

        private void Btn_CadastrarCarro_Click(object sender, EventArgs e)
        {
            string Tamanho = "";
            string Categoria = "";
            string Cilindradas = "";
            string GPS = "";
            string TelaLcd = "";
            string Fabricante = "";
            string Modelo = "";
            string Ano = "";
            string PainelDigital = "";
            string Cambio = "";
            string Combustivel = "";
            string DatadeFabricação = "";
            string ValorCompra = "";
            string Placa = "";
            Frm_cadastroCarros form = new Frm_cadastroCarros(Tamanho, Categoria, Cilindradas, GPS, TelaLcd, Fabricante, Modelo, Ano, PainelDigital, Cambio, Combustivel, DatadeFabricação, ValorCompra, Placa);
            form.Show();
            listarClientes();
            //Frm_cadastroCarros form = new Frm_cadastroCarros();
            //form.Show();
            //listarClientes();
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            listarClientes();
            
        }
        //termino do listar veiculos 
        // aqui são os botoes do veiculo

        private void Btn_AlterarVeiculos_Click(object sender, EventArgs e)
        {
            if (Placa == null)
            {
                MessageBox.Show("Selecione a placa do veiculo");
                return;
            }
            else
            {
                Frm_cadastroCarros form = new Frm_cadastroCarros(Tamanho, Categoria, Cilindradas, GPS, TelaLcd, Fabricante, Modelo, Ano, PainelDigital, Cambio, Combustivel, DatadeFabricação, ValorCompra, Placa);
                form.Show();
            }
        }

        private void Btn_NovoAdm_Click(object sender, EventArgs e)
        {
            Frm_CadastroAdiministrador ADM = new Frm_CadastroAdiministrador();
            ADM.Show();

        }

        private void Btn_NovoFuncionario_Click(object sender, EventArgs e)
        {
            Frm_CadastroFuncionario funcionario = new Frm_CadastroFuncionario();
            funcionario.Show();
        }

        private void Btn_NovoCliente_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente Cliente = new Frm_CadastroCliente();
            Cliente.Show();
        }

        // termino dos botoes 
        // apartir daqui é para o listar clientes 

        private Clientes clientes;

        public void listarClientes02()
        {
            this.clientes = new Clientes();
            MySqlDataReader temp = this.clientes.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            Dgv_ListarCliente.DataSource = dt;
        }

        private void Dgv_ListarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = Dgv_ListarCliente.Rows[e.RowIndex];
            CPF = linha.Cells[0].Value.ToString();
            Nome = linha.Cells[1].Value.ToString();
            Sobrenome = linha.Cells[2].Value.ToString();
            Senha = linha.Cells[3].Value.ToString();
            Endereco = linha.Cells[4].Value.ToString();
            Telefone = linha.Cells[5].Value.ToString();
            Email = linha.Cells[6].Value.ToString();
            CNH = linha.Cells[7].Value.ToString();
            CEP = linha.Cells[8].Value.ToString();
            Lbl_PlacaDoCarro.Text = Nome;
            Lbl_ModeloDoCarro.Text = Telefone;
        }

        //termino do liostar clientes
        // botoes do clientes
        private void Btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            String Filtro = Txt_BuscarClinte.Text;
            MySqlDataReader temp = this.clientes.ListarClientes(Filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            Dgv_ListarCliente.DataSource = dt;
        }

        private void Btn_AtualizarCliente_Click(object sender, EventArgs e)
        {
            listarClientes02();
        }

        private void Btn_AlterarClientes_Click(object sender, EventArgs e)
        {
            if (Nome == null)
            {
                MessageBox.Show("Selecione o nome do cliente");
                return;
            }
            else
            {
                Frm_cadastroCarros form = new Frm_cadastroCarros(Tamanho, Categoria, Cilindradas, GPS, TelaLcd, Fabricante, Modelo, Ano, PainelDigital, Cambio, Combustivel, DatadeFabricação, ValorCompra, Placa);
                form.Show();
            }
        }

        private void DataGrid_ListarVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_LocarCarro_Click(object sender, EventArgs e)
        {
            Frm_CadastroLocações locacao = new Frm_CadastroLocações();
            locacao.Show();
        }
    }
}
