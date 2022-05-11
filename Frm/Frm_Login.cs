using LocadoraSA.Frm;
namespace LocadoraSA

{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Lbl_Senha_Click(object sender, EventArgs e)
        {

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

        private void Lbl_Cpf_Click(object sender, EventArgs e)
        {

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
    }
}