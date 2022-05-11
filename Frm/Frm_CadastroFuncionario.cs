using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraSA.DTO;

namespace LocadoraSA.Frm
{
    public partial class Frm_CadastroFuncionario : Form
    {
        private Funcionarios funcionario;

        public Frm_CadastroFuncionario(string CPF, string Nome, string Sobrenome, string Senha, string Endereco, string Telefone, string Email, string CNH, string CEP)
        {
            InitializeComponent();
            Txt_Cpf.Text = CPF;
            Txt_Nome.Text = Nome;
            Txt_Sobrenome.Text = Sobrenome;
            Txt_Senha.Text = Senha;
            Txt_Endereco.Text = Endereco;
            Txt_Telefone.Text = Telefone;
            Txt_Email.Text = Email;
            Txt_Cnh.Text = CNH;
            Txt_Cep.Text = CEP;
        }

        public Frm_CadastroFuncionario()
        {
            InitializeComponent();
        }

        public void salvarRegistro()
        {
            try
            {
                this.funcionario = new Funcionarios();
                this.funcionario.CPF = Txt_Cpf.Text;
                this.funcionario.Nome = Txt_Nome.Text;
                this.funcionario.Sobrenome = Txt_Sobrenome.Text;
                this.funcionario.Senha = Txt_Senha.Text;
                this.funcionario.Endereco = Txt_Endereco.Text;
                this.funcionario.Telefone = Txt_Telefone.Text;
                this.funcionario.Email = Txt_Email.Text;
                this.funcionario.CNH = Txt_Cnh.Text;
                this.funcionario.CEP = Txt_Cep.Text;
                this.funcionario.CadastrarCliente();
                MessageBox.Show("Registro salvo com sucesso.");
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

        private void Lbl_UltimoNome_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pcb_Olho_Click(object sender, EventArgs e)
        {
            if (Txt_Senha.UseSystemPasswordChar == true)
            {
                Txt_Senha.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Senha.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Cadastrar_Click_1(object sender, EventArgs e)
        {
            if (Txt_Cpf.Text.Equals(""))
            {
                Lbl_Cpf.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu primeiro nome.");
                return;
            }
            if (Txt_Nome.Text.Equals(""))
            {
                Lbl_Nome.ForeColor = Color.Red;
                MessageBox.Show("Informe o seuultimo nome.");
                return;
            }
            if (Txt_Sobrenome.Text.Equals("+55 (  )       -"))
            {
                Lbl_Sobrenome.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu telefone.");
                return;
            }
            if (Txt_Senha.Text.Equals(""))
            {
                Lbl_Senha.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu email.");
                return;
            }
            if (Txt_Endereco.Text.Equals(""))
            {
                Lbl_Endereco.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu nome de usuario");
                return;
            }
            if (Txt_Telefone.Text.Equals(""))
            {
                Lbl_Telefone.ForeColor = Color.Red;
                MessageBox.Show("Informe a sua senha");
                return;
            }
            if (Txt_Email.Text.Equals(""))
            {
                Lbl_Email.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu ndereço.");
                return;
            }
            if (Txt_Cnh.Text.Equals(""))
            {
                Lbl_Cnh.ForeColor = Color.Red;
                MessageBox.Show("Informe o numero da sua casa.");
                return;
            }
            if (Txt_Cep.Text.Equals(""))
            {
                Lbl_Cep.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu CEP.");
                return;
            }
            //Frm_ListarCliente lista = new Frm_ListarCliente();
            //lista.listarClientes();
            salvarRegistro();
        }

        private void Btn_Voltar_Click_1(object sender, EventArgs e)
        {
            Frm_Login voltar = new Frm_Login();
            voltar.Show();
        }
    }
}
