using LocadoraSA.DataBase;
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
    public partial class Frm_cadastroCarros : Form
    {

        private Veiculos funcionario;

        public Frm_cadastroCarros(string Tamanho, string Categoria, string Cilindradas, string GPS, string TelaLcd, string Fabricante, string Modelo, string Ano, string PainelDigital, string Cambio, string Combustivel, string DatadeFabricação, string ValorCompra, string Placa)
        {
            Txt_Tamanho.Text = Tamanho;
            Txt_Categoria.Text = Categoria;
            Txt_Cilindradas.Text = Cilindradas;
            Txt_GPS.Text = GPS;
            Txt_LCD.Text = TelaLcd;
            Txt_Fabricante.Text = Fabricante;
            Txt_Modelo.Text = Modelo;
            Txt_Ano.Text = Ano;
            Txt_PainelDigital.Text = PainelDigital;
            Txt_Cambio.Text = Cambio;
            Txt_Combustivel.Text = Combustivel;
            Txt_DatadeFabricação.Text = DatadeFabricação;
            Txt_ValorCompra.Text = ValorCompra;
            Txt_Placa.Text = Placa;
        }

        public Frm_cadastroCarros()
        {
            InitializeComponent();
        }

        public void salvarRegistro()
        {
            try
            {
                this.funcionario = new Veiculos();
                this.funcionario.Tamanho = Txt_Tamanho.Text;
                this.funcionario.Categoria = Txt_Categoria.Text;
                this.funcionario.Cilindradas = Txt_Cilindradas.Text;
                this.funcionario.GPS = Txt_GPS.Text;
                this.funcionario.TelaLcd = Txt_LCD.Text;
                this.funcionario.Fabricante = Txt_Fabricante.Text;
                this.funcionario.Modelo = Txt_Modelo.Text;
                this.funcionario.Ano = Txt_Ano.Text;
                this.funcionario.PainelDigital = Txt_PainelDigital.Text;
                this.funcionario.Cambio = Txt_Cambio.Text;
                this.funcionario.Combustivel = Txt_Combustivel.Text;
                this.funcionario.DatadeFabricação = Txt_DatadeFabricação.Text;
                this.funcionario.ValorCompra = Txt_ValorCompra.Text;
                this.funcionario.Placa = Txt_Placa.Text;
                this.funcionario.CadastrarCliente();
                MessageBox.Show("Registro salvo com sucesso.");
                this.Close();
            }
            catch (Exception c)
            {
                if (c.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Usuário Já existe! ", "Erro no Formulário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Lbl_Placa.ForeColor = Color.Red;
                    this.Lbl_Placa.Text = "CPF Duplicado";
                }
                else
                {
                    MessageBox.Show("Não é possivel conectar no banco de dados!" + c.Message, "Erro no salvamentoo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Login voltar = new Frm_Login();
            voltar.Show();
        }


        private void Frm_cadastroVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Telefone_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_GPS_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Txt_Tamanho.Text.Equals(""))
            {
                Lbl_Tamanho.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu primeiro nome.");
                return;
            }
            if (Txt_Categoria.Text.Equals(""))
            {
                Lbl_Categoria.ForeColor = Color.Red;
                MessageBox.Show("Informe o seuultimo nome.");
                return;
            }
            if (Txt_Cilindradas.Text.Equals("+55 (  )       -"))
            {
                Lbl_Cilindradas.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu telefone.");
                return;
            }
            if (Txt_GPS.Text.Equals(""))
            {
                Lbl_GPS.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu email.");
                return;
            }
            if (Txt_LCD.Text.Equals(""))
            {
                Lbl_LCD.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu nome de usuario");
                return;
            }
            if (Txt_Fabricante.Text.Equals(""))
            {
                Lbl_Fabricante.ForeColor = Color.Red;
                MessageBox.Show("Informe a sua senha");
                return;
            }
            if (Txt_Modelo.Text.Equals(""))
            {
                Lbl_Modelo.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu ndereço.");
                return;
            }
            if (Txt_Ano.Text.Equals(""))
            {
                Lbl_Ano.ForeColor = Color.Red;
                MessageBox.Show("Informe o numero da sua casa.");
                return;
            }
            if (Txt_PainelDigital.Text.Equals(""))
            {
                Lbl_PainelDigital.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu CEP.");
                return;
            }
            if (Txt_Cambio.Text.Equals(""))
            {
                Lbl_Cambio.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu email.");
                return;
            }
            if (Txt_Combustivel.Text.Equals(""))
            {
                Lbl_Combustivel.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu nome de usuario");
                return;
            }
            if (Txt_DatadeFabricação.Text.Equals(""))
            {
                Lbl_DatadeFabricação.ForeColor = Color.Red;
                MessageBox.Show("Informe a sua senha");
                return;
            }
            if (Txt_ValorCompra.Text.Equals(""))
            {
                Lbl_ValorCompra.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu ndereço.");
                return;
            }
            if (Txt_Placa.Text.Equals(""))
            {
                Lbl_Placa.ForeColor = Color.Red;
                MessageBox.Show("Informe o numero da sua casa.");
                return;
            }
            //Frm_ListarCliente lista = new Frm_ListarCliente();
            //lista.listarClientes();
            salvarRegistro();
        }
    }
}


