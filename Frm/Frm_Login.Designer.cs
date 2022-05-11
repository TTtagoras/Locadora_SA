namespace LocadoraSA
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Btn_LoginCliente = new System.Windows.Forms.Button();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_LoginFuncionario = new System.Windows.Forms.Button();
            this.Btn_Adiministrador = new System.Windows.Forms.Button();
            this.Btn_CadastroCliente = new System.Windows.Forms.Button();
            this.Btn_CadastroFuncionario = new System.Windows.Forms.Button();
            this.Pcb_Olho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Olho)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_LoginCliente
            // 
            this.Btn_LoginCliente.Location = new System.Drawing.Point(23, 161);
            this.Btn_LoginCliente.Name = "Btn_LoginCliente";
            this.Btn_LoginCliente.Size = new System.Drawing.Size(82, 44);
            this.Btn_LoginCliente.TabIndex = 0;
            this.Btn_LoginCliente.Text = "Logar como cliente";
            this.Btn_LoginCliente.UseVisualStyleBackColor = true;
            this.Btn_LoginCliente.Click += new System.EventHandler(this.Btn_LoginCliente_Click);
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cpf.Location = new System.Drawing.Point(92, 36);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(38, 21);
            this.Lbl_Cpf.TabIndex = 22;
            this.Lbl_Cpf.Text = "CPF";
            
            // 
            // Txt_Cpf
            // 
            this.Txt_Cpf.Location = new System.Drawing.Point(92, 60);
            this.Txt_Cpf.Mask = "000,000,000-00";
            this.Txt_Cpf.Name = "Txt_Cpf";
            this.Txt_Cpf.Size = new System.Drawing.Size(167, 23);
            this.Txt_Cpf.TabIndex = 23;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Senha.Location = new System.Drawing.Point(92, 98);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(57, 21);
            this.Lbl_Senha.TabIndex = 24;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(92, 122);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.Size = new System.Drawing.Size(167, 23);
            this.Txt_senha.TabIndex = 25;
            this.Txt_senha.UseSystemPasswordChar = true;
            // 
            // Btn_LoginFuncionario
            // 
            this.Btn_LoginFuncionario.Location = new System.Drawing.Point(124, 161);
            this.Btn_LoginFuncionario.Name = "Btn_LoginFuncionario";
            this.Btn_LoginFuncionario.Size = new System.Drawing.Size(82, 44);
            this.Btn_LoginFuncionario.TabIndex = 26;
            this.Btn_LoginFuncionario.Text = "Logar como funcionario";
            this.Btn_LoginFuncionario.UseVisualStyleBackColor = true;
            this.Btn_LoginFuncionario.Click += new System.EventHandler(this.Btn_LoginFuncionario_Click);
            // 
            // Btn_Adiministrador
            // 
            this.Btn_Adiministrador.Location = new System.Drawing.Point(227, 161);
            this.Btn_Adiministrador.Name = "Btn_Adiministrador";
            this.Btn_Adiministrador.Size = new System.Drawing.Size(82, 44);
            this.Btn_Adiministrador.TabIndex = 27;
            this.Btn_Adiministrador.Text = "Logar como ADM";
            this.Btn_Adiministrador.UseVisualStyleBackColor = true;
            this.Btn_Adiministrador.Click += new System.EventHandler(this.Btn_Adiministrador_Click);
            // 
            // Btn_CadastroCliente
            // 
            this.Btn_CadastroCliente.Location = new System.Drawing.Point(46, 227);
            this.Btn_CadastroCliente.Name = "Btn_CadastroCliente";
            this.Btn_CadastroCliente.Size = new System.Drawing.Size(114, 46);
            this.Btn_CadastroCliente.TabIndex = 28;
            this.Btn_CadastroCliente.Text = "Fazer cadastro como cliente";
            this.Btn_CadastroCliente.UseVisualStyleBackColor = true;
            this.Btn_CadastroCliente.Click += new System.EventHandler(this.Btn_CadastroCliente_Click);
            // 
            // Btn_CadastroFuncionario
            // 
            this.Btn_CadastroFuncionario.Location = new System.Drawing.Point(166, 227);
            this.Btn_CadastroFuncionario.Name = "Btn_CadastroFuncionario";
            this.Btn_CadastroFuncionario.Size = new System.Drawing.Size(114, 46);
            this.Btn_CadastroFuncionario.TabIndex = 29;
            this.Btn_CadastroFuncionario.Text = "Fazer cadastro como funcionario";
            this.Btn_CadastroFuncionario.UseVisualStyleBackColor = true;
            this.Btn_CadastroFuncionario.Click += new System.EventHandler(this.Btn_CadastroFuncionario_Click);
            // 
            // Pcb_Olho
            // 
            this.Pcb_Olho.BackColor = System.Drawing.Color.White;
            this.Pcb_Olho.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_Olho.Image")));
            this.Pcb_Olho.Location = new System.Drawing.Point(235, 126);
            this.Pcb_Olho.Name = "Pcb_Olho";
            this.Pcb_Olho.Size = new System.Drawing.Size(19, 15);
            this.Pcb_Olho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_Olho.TabIndex = 30;
            this.Pcb_Olho.TabStop = false;
            this.Pcb_Olho.Click += new System.EventHandler(this.Pcb_Olho_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(334, 337);
            this.Controls.Add(this.Pcb_Olho);
            this.Controls.Add(this.Btn_CadastroFuncionario);
            this.Controls.Add(this.Btn_CadastroCliente);
            this.Controls.Add(this.Btn_Adiministrador);
            this.Controls.Add(this.Btn_LoginFuncionario);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_Cpf);
            this.Controls.Add(this.Lbl_Cpf);
            this.Controls.Add(this.Btn_LoginCliente);
            this.Name = "Frm_Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Olho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_LoginCliente;
        private Label Lbl_Cpf;
        private MaskedTextBox Txt_Cpf;
        private Label Lbl_Senha;
        private TextBox Txt_senha;
        private Button Btn_LoginFuncionario;
        private Button Btn_Adiministrador;
        private Button Btn_CadastroCliente;
        private Button Btn_CadastroFuncionario;
        private PictureBox Pcb_Olho;
    }
}