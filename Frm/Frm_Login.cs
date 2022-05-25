using LocadoraSA.Frm;
using MySql.Data.MySqlClient;

namespace LocadoraSA

{
    
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_CadastroCliente_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente cadastrar = new Frm_CadastroCliente();
            cadastrar.Show();
        }


        private void Btn_CadastroFuncionario_Click(object sender, EventArgs e)
        {
            Frm_CadastroFuncionario cadastrar = new Frm_CadastroFuncionario();
            cadastrar.Show();
        }


        private void Pcb_Olho_Click(object sender, EventArgs e)
        {
            if (Txt_senha.UseSystemPasswordChar == true)
            {
                Txt_senha.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_senha.UseSystemPasswordChar = true;
            }
        }


        private void Btn_LoginCliente_Click(object sender, EventArgs e)
        {
            if ((Txt_Cpf.Text == "") || (Txt_senha.Text == ""))
            {
                MessageBox.Show("É necessario preencher todos os campos.");
            }
            else
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=locadorasa; password=root;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "SELECT * from `locadorasa`.`clientes` WHERE (CPF='" + Txt_Cpf.Text + "' and Senha='" + Txt_senha.Text + "');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    if (logado.HasRows)
                    {
                        Frm_PrincipalClientes cadastrar = new Frm_PrincipalClientes();
                        cadastrar.Show();
                    }
                    else
                    {
                        MessageBox.Show("login ou senha incorretos");
                        Txt_Cpf.Text = "";
                        Txt_senha.Text = "";
                    }
                    conexao.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Btn_LoginFuncionario_Click(object sender, EventArgs e)
        {
            if ((Txt_Cpf.Text == "") || (Txt_senha.Text == ""))
            {
                MessageBox.Show("É necessario preencher todos os campos.");
            }
            else
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=locadorasa; password=root;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "SELECT * from `locadorasa`.`funcionarios` WHERE (CPF='" + Txt_Cpf.Text + "' and Senha='" + Txt_senha.Text + "');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    if (logado.HasRows)
                    {
                       Frm_PrincipalFuncionario cadastrar = new Frm_PrincipalFuncionario();
                        cadastrar.Show();
                    }
                    else
                    {
                        MessageBox.Show("login ou senha incorretos");
                        Txt_Cpf.Text = "";
                        Txt_senha.Text = "";
                    }
                    conexao.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Btn_Adiministrador_Click(object sender, EventArgs e)
        {
            if ((Txt_Cpf.Text == "") || (Txt_senha.Text == ""))
            {
                MessageBox.Show("É necessario preencher todos os campos.");
            }
            else
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=locadorasa; password=root;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "SELECT * from `locadorasa`.`adiministrador` WHERE (CPF='" + Txt_Cpf.Text + "' and Senha='" + Txt_senha.Text + "');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    if (logado.HasRows)
                    {
                        Frm_PrincipalAdm cadastrar = new Frm_PrincipalAdm();
                        cadastrar.Show();
                    }
                    else
                    {
                        MessageBox.Show("login ou senha incorretos");
                        Txt_Cpf.Text = "";
                        Txt_senha.Text = "";
                    }
                    conexao.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}