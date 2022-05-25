namespace LocadoraSA.Frm
{
    partial class Frm_PrincipalAdm
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
            this.Btn_NovoAdm = new System.Windows.Forms.Button();
            this.Btn_NovoFuncionario = new System.Windows.Forms.Button();
            this.Btn_CadastrarCarro = new System.Windows.Forms.Button();
            this.Lbl_ModeloDoCarro = new System.Windows.Forms.Label();
            this.Lbl_PlacaDoCarro = new System.Windows.Forms.Label();
            this.DataGrid_ListarVeiculos = new System.Windows.Forms.DataGridView();
            this.Btn_AtualizarCarro = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_BuscarCarro = new System.Windows.Forms.Button();
            this.Txt_BuscarCarro = new System.Windows.Forms.TextBox();
            this.Lbl_BuscarCarro = new System.Windows.Forms.Label();
            this.Btn_NovoCliente = new System.Windows.Forms.Button();
            this.Btn_AlterarVeiculos = new System.Windows.Forms.Button();
            this.Btn_AlterarClientes = new System.Windows.Forms.Button();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Btn_AtualizarCliente = new System.Windows.Forms.Button();
            this.Btn_BuscarCliente = new System.Windows.Forms.Button();
            this.Txt_BuscarClinte = new System.Windows.Forms.TextBox();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.Dgv_ListarCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_NovoAdm
            // 
            this.Btn_NovoAdm.Location = new System.Drawing.Point(369, 516);
            this.Btn_NovoAdm.Name = "Btn_NovoAdm";
            this.Btn_NovoAdm.Size = new System.Drawing.Size(136, 25);
            this.Btn_NovoAdm.TabIndex = 15;
            this.Btn_NovoAdm.Text = "Adicionar ADM";
            this.Btn_NovoAdm.UseVisualStyleBackColor = true;
            this.Btn_NovoAdm.Click += new System.EventHandler(this.Btn_NovoAdm_Click);
            // 
            // Btn_NovoFuncionario
            // 
            this.Btn_NovoFuncionario.Location = new System.Drawing.Point(511, 516);
            this.Btn_NovoFuncionario.Name = "Btn_NovoFuncionario";
            this.Btn_NovoFuncionario.Size = new System.Drawing.Size(132, 25);
            this.Btn_NovoFuncionario.TabIndex = 14;
            this.Btn_NovoFuncionario.Text = "Adicionar Funcionario";
            this.Btn_NovoFuncionario.UseVisualStyleBackColor = true;
            this.Btn_NovoFuncionario.Click += new System.EventHandler(this.Btn_NovoFuncionario_Click);
            // 
            // Btn_CadastrarCarro
            // 
            this.Btn_CadastrarCarro.Location = new System.Drawing.Point(234, 516);
            this.Btn_CadastrarCarro.Name = "Btn_CadastrarCarro";
            this.Btn_CadastrarCarro.Size = new System.Drawing.Size(129, 25);
            this.Btn_CadastrarCarro.TabIndex = 11;
            this.Btn_CadastrarCarro.Text = "Cadastrar Carro";
            this.Btn_CadastrarCarro.UseVisualStyleBackColor = true;
            this.Btn_CadastrarCarro.Click += new System.EventHandler(this.Btn_CadastrarCarro_Click);
            // 
            // Lbl_ModeloDoCarro
            // 
            this.Lbl_ModeloDoCarro.AutoSize = true;
            this.Lbl_ModeloDoCarro.Location = new System.Drawing.Point(550, 36);
            this.Lbl_ModeloDoCarro.Name = "Lbl_ModeloDoCarro";
            this.Lbl_ModeloDoCarro.Size = new System.Drawing.Size(19, 15);
            this.Lbl_ModeloDoCarro.TabIndex = 23;
            this.Lbl_ModeloDoCarro.Text = "....";
            //this.Lbl_ModeloDoCarro.Click += new System.EventHandler(this.Lbl_ModeloDoCarro_Click);
            // 
            // Lbl_PlacaDoCarro
            // 
            this.Lbl_PlacaDoCarro.AutoSize = true;
            this.Lbl_PlacaDoCarro.Location = new System.Drawing.Point(550, 15);
            this.Lbl_PlacaDoCarro.Name = "Lbl_PlacaDoCarro";
            this.Lbl_PlacaDoCarro.Size = new System.Drawing.Size(19, 15);
            this.Lbl_PlacaDoCarro.TabIndex = 22;
            this.Lbl_PlacaDoCarro.Text = "....";
            // 
            // DataGrid_ListarVeiculos
            // 
            this.DataGrid_ListarVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListarVeiculos.Location = new System.Drawing.Point(5, 91);
            this.DataGrid_ListarVeiculos.Name = "DataGrid_ListarVeiculos";
            this.DataGrid_ListarVeiculos.RowTemplate.Height = 25;
            this.DataGrid_ListarVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ListarVeiculos.Size = new System.Drawing.Size(776, 141);
            this.DataGrid_ListarVeiculos.TabIndex = 21;
            // 
            // Btn_AtualizarCarro
            // 
            this.Btn_AtualizarCarro.Location = new System.Drawing.Point(450, 33);
            this.Btn_AtualizarCarro.Name = "Btn_AtualizarCarro";
            this.Btn_AtualizarCarro.Size = new System.Drawing.Size(75, 23);
            this.Btn_AtualizarCarro.TabIndex = 20;
            this.Btn_AtualizarCarro.Text = "Atualizar";
            this.Btn_AtualizarCarro.UseVisualStyleBackColor = true;
            this.Btn_AtualizarCarro.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(12, 515);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(86, 26);
            this.Btn_Excluir.TabIndex = 19;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarCarro
            // 
            this.Btn_BuscarCarro.Location = new System.Drawing.Point(369, 33);
            this.Btn_BuscarCarro.Name = "Btn_BuscarCarro";
            this.Btn_BuscarCarro.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarCarro.TabIndex = 18;
            this.Btn_BuscarCarro.Text = "Buscar";
            this.Btn_BuscarCarro.UseVisualStyleBackColor = true;
            this.Btn_BuscarCarro.Click += new System.EventHandler(this.Btn_BuscarCLiente_Click_1);
            // 
            // Txt_BuscarCarro
            // 
            this.Txt_BuscarCarro.Location = new System.Drawing.Point(12, 33);
            this.Txt_BuscarCarro.Name = "Txt_BuscarCarro";
            this.Txt_BuscarCarro.Size = new System.Drawing.Size(330, 23);
            this.Txt_BuscarCarro.TabIndex = 17;
            // 
            // Lbl_BuscarCarro
            // 
            this.Lbl_BuscarCarro.AutoSize = true;
            this.Lbl_BuscarCarro.Location = new System.Drawing.Point(12, 15);
            this.Lbl_BuscarCarro.Name = "Lbl_BuscarCarro";
            this.Lbl_BuscarCarro.Size = new System.Drawing.Size(88, 15);
            this.Lbl_BuscarCarro.TabIndex = 16;
            this.Lbl_BuscarCarro.Text = "Buscar veiculos";
            // 
            // Btn_NovoCliente
            // 
            this.Btn_NovoCliente.Location = new System.Drawing.Point(649, 516);
            this.Btn_NovoCliente.Name = "Btn_NovoCliente";
            this.Btn_NovoCliente.Size = new System.Drawing.Size(132, 25);
            this.Btn_NovoCliente.TabIndex = 24;
            this.Btn_NovoCliente.Text = "Adicionar Cliente";
            this.Btn_NovoCliente.UseVisualStyleBackColor = true;
            this.Btn_NovoCliente.Click += new System.EventHandler(this.Btn_NovoCliente_Click);
            // 
            // Btn_AlterarVeiculos
            // 
            this.Btn_AlterarVeiculos.Location = new System.Drawing.Point(391, 62);
            this.Btn_AlterarVeiculos.Name = "Btn_AlterarVeiculos";
            this.Btn_AlterarVeiculos.Size = new System.Drawing.Size(105, 23);
            this.Btn_AlterarVeiculos.TabIndex = 25;
            this.Btn_AlterarVeiculos.Text = "Alterar Veiculos";
            this.Btn_AlterarVeiculos.UseVisualStyleBackColor = true;
            this.Btn_AlterarVeiculos.Click += new System.EventHandler(this.Btn_AlterarVeiculos_Click);
            // 
            // Btn_AlterarClientes
            // 
            this.Btn_AlterarClientes.Location = new System.Drawing.Point(391, 315);
            this.Btn_AlterarClientes.Name = "Btn_AlterarClientes";
            this.Btn_AlterarClientes.Size = new System.Drawing.Size(105, 23);
            this.Btn_AlterarClientes.TabIndex = 32;
            this.Btn_AlterarClientes.Text = "Alterar Clientes";
            this.Btn_AlterarClientes.UseVisualStyleBackColor = true;
            this.Btn_AlterarClientes.Click += new System.EventHandler(this.Btn_AlterarClientes_Click);
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(550, 289);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Telefone.TabIndex = 31;
            this.Lbl_Telefone.Text = "....";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(550, 268);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Nome.TabIndex = 30;
            this.Lbl_Nome.Text = "....";
            // 
            // Btn_AtualizarCliente
            // 
            this.Btn_AtualizarCliente.Location = new System.Drawing.Point(450, 286);
            this.Btn_AtualizarCliente.Name = "Btn_AtualizarCliente";
            this.Btn_AtualizarCliente.Size = new System.Drawing.Size(75, 23);
            this.Btn_AtualizarCliente.TabIndex = 29;
            this.Btn_AtualizarCliente.Text = "Atualizar";
            this.Btn_AtualizarCliente.UseVisualStyleBackColor = true;
            this.Btn_AtualizarCliente.Click += new System.EventHandler(this.Btn_AtualizarCliente_Click);
            // 
            // Btn_BuscarCliente
            // 
            this.Btn_BuscarCliente.Location = new System.Drawing.Point(369, 286);
            this.Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            this.Btn_BuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarCliente.TabIndex = 28;
            this.Btn_BuscarCliente.Text = "Buscar";
            this.Btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.Btn_BuscarCliente.Click += new System.EventHandler(this.Btn_BuscarCliente_Click);
            // 
            // Txt_BuscarClinte
            // 
            this.Txt_BuscarClinte.Location = new System.Drawing.Point(12, 286);
            this.Txt_BuscarClinte.Name = "Txt_BuscarClinte";
            this.Txt_BuscarClinte.Size = new System.Drawing.Size(330, 23);
            this.Txt_BuscarClinte.TabIndex = 27;
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(12, 268);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(82, 15);
            this.Lbl_Clientes.TabIndex = 26;
            this.Lbl_Clientes.Text = "Buscar Cliente";
            // 
            // Dgv_ListarCliente
            // 
            this.Dgv_ListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListarCliente.Location = new System.Drawing.Point(5, 344);
            this.Dgv_ListarCliente.Name = "Dgv_ListarCliente";
            this.Dgv_ListarCliente.RowTemplate.Height = 25;
            this.Dgv_ListarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ListarCliente.Size = new System.Drawing.Size(776, 141);
            this.Dgv_ListarCliente.TabIndex = 33;
            this.Dgv_ListarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ListarCliente_CellContentClick);
            // 
            // Frm_PrincipalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.Dgv_ListarCliente);
            this.Controls.Add(this.Btn_AlterarClientes);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Btn_AtualizarCliente);
            this.Controls.Add(this.Btn_BuscarCliente);
            this.Controls.Add(this.Txt_BuscarClinte);
            this.Controls.Add(this.Lbl_Clientes);
            this.Controls.Add(this.Btn_AlterarVeiculos);
            this.Controls.Add(this.Btn_NovoCliente);
            this.Controls.Add(this.Lbl_ModeloDoCarro);
            this.Controls.Add(this.Lbl_PlacaDoCarro);
            this.Controls.Add(this.DataGrid_ListarVeiculos);
            this.Controls.Add(this.Btn_AtualizarCarro);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_BuscarCarro);
            this.Controls.Add(this.Txt_BuscarCarro);
            this.Controls.Add(this.Lbl_BuscarCarro);
            this.Controls.Add(this.Btn_NovoAdm);
            this.Controls.Add(this.Btn_NovoFuncionario);
            this.Controls.Add(this.Btn_CadastrarCarro);
            this.Name = "Frm_PrincipalAdm";
            this.Text = "Frm_PrincipalAdm";
            this.Load += new System.EventHandler(this.Frm_PrincipalAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_NovoAdm;
        private Button Btn_NovoFuncionario;
        private Button Btn_CadastrarCarro;
        private Label Lbl_ModeloDoCarro;
        private Label Lbl_PlacaDoCarro;
        private DataGridView DataGrid_ListarVeiculos;
        private Button Btn_AtualizarCarro;
        private Button Btn_Excluir;
        private Button Btn_BuscarCarro;
        private TextBox Txt_BuscarCarro;
        private Label Lbl_BuscarCarro;
        private Button Btn_NovoCliente;
        private Button Btn_AlterarVeiculos;
        private Button Btn_AlterarClientes;
        private Label Lbl_Telefone;
        private Label Lbl_Nome;
        private Button Btn_AtualizarCliente;
        private Button Btn_BuscarCliente;
        private TextBox Txt_BuscarClinte;
        private Label Lbl_Clientes;
        private DataGridView Dgv_ListarCliente;
    }
}