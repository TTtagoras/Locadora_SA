namespace LocadoraSA.Frm
{
    partial class Frm_CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente));
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Lbl_Cnh = new System.Windows.Forms.Label();
            this.Lbl_Endereco = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.Pcb_Olho = new System.Windows.Forms.PictureBox();
            this.Txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Cnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Olho)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cep.Location = new System.Drawing.Point(433, 126);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(43, 19);
            this.Lbl_Cep.TabIndex = 54;
            this.Lbl_Cep.Text = "CEP";
            // 
            // Lbl_Cnh
            // 
            this.Lbl_Cnh.AutoSize = true;
            this.Lbl_Cnh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cnh.Location = new System.Drawing.Point(433, 65);
            this.Lbl_Cnh.Name = "Lbl_Cnh";
            this.Lbl_Cnh.Size = new System.Drawing.Size(45, 19);
            this.Lbl_Cnh.TabIndex = 53;
            this.Lbl_Cnh.Text = "CNH";
            // 
            // Lbl_Endereco
            // 
            this.Lbl_Endereco.AutoSize = true;
            this.Lbl_Endereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Endereco.Location = new System.Drawing.Point(202, 65);
            this.Lbl_Endereco.Name = "Lbl_Endereco";
            this.Lbl_Endereco.Size = new System.Drawing.Size(83, 19);
            this.Lbl_Endereco.TabIndex = 52;
            this.Lbl_Endereco.Text = "Endereço";
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Endereco.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Endereco.Location = new System.Drawing.Point(202, 87);
            this.Txt_Endereco.Multiline = true;
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.PlaceholderText = "Digite aqui seu endereço";
            this.Txt_Endereco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Endereco.Size = new System.Drawing.Size(151, 36);
            this.Txt_Endereco.TabIndex = 41;
            this.Txt_Endereco.TextChanged += new System.EventHandler(this.Txt_Endereco_TextChanged);
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Senha.Location = new System.Drawing.Point(202, 9);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(58, 19);
            this.Lbl_Senha.TabIndex = 51;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Senha.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Senha.Location = new System.Drawing.Point(202, 31);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PlaceholderText = "Digite aqui sua Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(151, 20);
            this.Txt_Senha.TabIndex = 40;
            this.Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.Location = new System.Drawing.Point(12, 186);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(127, 33);
            this.Btn_Voltar.TabIndex = 50;
            this.Btn_Voltar.Text = "Voltar para  login";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(151, 187);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(130, 33);
            this.Btn_Cadastrar.TabIndex = 44;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(202, 148);
            this.Txt_Telefone.Mask = "+55 (99) 0 0000-0000";
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(151, 23);
            this.Txt_Telefone.TabIndex = 37;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cpf.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(42, 19);
            this.Lbl_Cpf.TabIndex = 49;
            this.Lbl_Cpf.Text = "CPF";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Email.Location = new System.Drawing.Point(433, 9);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(56, 19);
            this.Lbl_Email.TabIndex = 48;
            this.Lbl_Email.Text = "E-mail";
            // 
            // Txt_Email
            // 
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Email.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Email.Location = new System.Drawing.Point(433, 31);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.PlaceholderText = "Digite aqui seu E-mail";
            this.Txt_Email.Size = new System.Drawing.Size(151, 20);
            this.Txt_Email.TabIndex = 38;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Telefone.Location = new System.Drawing.Point(202, 126);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Telefone.TabIndex = 47;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nome.Location = new System.Drawing.Point(12, 65);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Nome.TabIndex = 46;
            this.Lbl_Nome.Text = "Nome";
            this.Lbl_Nome.Click += new System.EventHandler(this.Lbl_UltimoNome_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Nome.Location = new System.Drawing.Point(12, 87);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.PlaceholderText = "Digite aqui seu nome";
            this.Txt_Nome.Size = new System.Drawing.Size(151, 20);
            this.Txt_Nome.TabIndex = 36;
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(12, 126);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(98, 19);
            this.Lbl_Sobrenome.TabIndex = 45;
            this.Lbl_Sobrenome.Text = "Sobrenome";
            this.Lbl_Sobrenome.Click += new System.EventHandler(this.Lbl_Sobrenome_Click);
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Sobrenome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Sobrenome.Location = new System.Drawing.Point(12, 148);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.PlaceholderText = "Digite aqui seu sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(151, 20);
            this.Txt_Sobrenome.TabIndex = 35;
            // 
            // Pcb_Olho
            // 
            this.Pcb_Olho.BackColor = System.Drawing.Color.White;
            this.Pcb_Olho.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_Olho.Image")));
            this.Pcb_Olho.Location = new System.Drawing.Point(332, 33);
            this.Pcb_Olho.Name = "Pcb_Olho";
            this.Pcb_Olho.Size = new System.Drawing.Size(19, 15);
            this.Pcb_Olho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_Olho.TabIndex = 55;
            this.Pcb_Olho.TabStop = false;
            this.Pcb_Olho.Click += new System.EventHandler(this.Pcb_Olho_Click);
            // 
            // Txt_Cpf
            // 
            this.Txt_Cpf.Location = new System.Drawing.Point(12, 31);
            this.Txt_Cpf.Mask = "000,000,000-00";
            this.Txt_Cpf.Name = "Txt_Cpf";
            this.Txt_Cpf.Size = new System.Drawing.Size(151, 23);
            this.Txt_Cpf.TabIndex = 56;
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(433, 148);
            this.Txt_Cep.Mask = "00000-000";
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.Size = new System.Drawing.Size(151, 23);
            this.Txt_Cep.TabIndex = 57;
            // 
            // Txt_Cnh
            // 
            this.Txt_Cnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cnh.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Cnh.Location = new System.Drawing.Point(433, 87);
            this.Txt_Cnh.Name = "Txt_Cnh";
            this.Txt_Cnh.PlaceholderText = "Digite aqui o n° de registro";
            this.Txt_Cnh.Size = new System.Drawing.Size(135, 20);
            this.Txt_Cnh.TabIndex = 42;
            // 
            // Frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(636, 248);
            this.Controls.Add(this.Txt_Cep);
            this.Controls.Add(this.Txt_Cpf);
            this.Controls.Add(this.Pcb_Olho);
            this.Controls.Add(this.Lbl_Cep);
            this.Controls.Add(this.Lbl_Cnh);
            this.Controls.Add(this.Txt_Cnh);
            this.Controls.Add(this.Lbl_Endereco);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Txt_Telefone);
            this.Controls.Add(this.Lbl_Cpf);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Sobrenome);
            this.Controls.Add(this.Txt_Sobrenome);
            this.Name = "Frm_CadastroCliente";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.Frm_CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Olho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Cep;
        private Label Lbl_Cnh;
        private Label Lbl_Endereco;
        private TextBox Txt_Endereco;
        private Label Lbl_Senha;
        private TextBox Txt_Senha;
        private Button Btn_Voltar;
        private Button Btn_Cadastrar;
        private MaskedTextBox Txt_Telefone;
        private Label Lbl_Cpf;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private Label Lbl_Telefone;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_Sobrenome;
        private TextBox Txt_Sobrenome;
        private PictureBox Pcb_Olho;
        private MaskedTextBox Txt_Cpf;
        private MaskedTextBox Txt_Cep;
        private TextBox Txt_Cnh;
    }
}