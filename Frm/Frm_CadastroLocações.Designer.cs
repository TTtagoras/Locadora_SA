﻿namespace LocadoraSA.Frm
{
    partial class Frm_CadastroLocações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroLocações));
            this.Lbl_Placa = new System.Windows.Forms.Label();
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_Locacao = new System.Windows.Forms.Label();
            this.Txt_Locacao = new System.Windows.Forms.TextBox();
            this.DataGrid_ListarClientes = new System.Windows.Forms.DataGridView();
            this.DataGrid_ListarLocado = new System.Windows.Forms.DataGridView();
            this.Txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.DataGrid_ListarLocados = new System.Windows.Forms.DataGridView();
            this.Btn_AlterarLocacao = new System.Windows.Forms.Button();
            this.Lbl_Modelo1 = new System.Windows.Forms.Label();
            this.Lbl_Placa1 = new System.Windows.Forms.Label();
            this.Btn_AtualizarVeiculoLocado = new System.Windows.Forms.Button();
            this.Btn_BuscarVeiculoLocado = new System.Windows.Forms.Button();
            this.Txt_BuscarVeiculoLocado = new System.Windows.Forms.TextBox();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.Lbl_Modelo2 = new System.Windows.Forms.Label();
            this.Lbl_Placa2 = new System.Windows.Forms.Label();
            this.Btn_AtualizarVeiculoDisponivel = new System.Windows.Forms.Button();
            this.Btn_BuscarVeiculoDisponivel = new System.Windows.Forms.Button();
            this.Txt_BuscarVeiculoDisponivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGrid_ListarDisponiveis = new System.Windows.Forms.DataGridView();
            this.Btn_AlterarVeiculoDisponivel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_kmInicial = new System.Windows.Forms.Label();
            this.Txt_KmInicial = new System.Windows.Forms.TextBox();
            this.Lbl_KmFinal = new System.Windows.Forms.Label();
            this.Txt_KmFinal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarLocado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarLocados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarDisponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Placa
            // 
            this.Lbl_Placa.AutoSize = true;
            this.Lbl_Placa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Placa.Location = new System.Drawing.Point(12, 143);
            this.Lbl_Placa.Name = "Lbl_Placa";
            this.Lbl_Placa.Size = new System.Drawing.Size(122, 19);
            this.Lbl_Placa.TabIndex = 124;
            this.Lbl_Placa.Text = "Placa do Carro";
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Placa.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Placa.Location = new System.Drawing.Point(12, 165);
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.PlaceholderText = "Digite a placa do carro";
            this.Txt_Placa.Size = new System.Drawing.Size(151, 20);
            this.Txt_Placa.TabIndex = 115;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.Location = new System.Drawing.Point(588, 6);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(127, 29);
            this.Btn_Voltar.TabIndex = 123;
            this.Btn_Voltar.Text = "Voltar para  login";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(721, 6);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(130, 29);
            this.Btn_Cadastrar.TabIndex = 117;
            this.Btn_Cadastrar.Text = "Cadastrar Locação";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cpf.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(123, 19);
            this.Lbl_Cpf.TabIndex = 122;
            this.Lbl_Cpf.Text = "CPF do Cliente";
            this.Lbl_Cpf.Click += new System.EventHandler(this.Lbl_Tamanho_Click);
            // 
            // Lbl_Locacao
            // 
            this.Lbl_Locacao.AutoSize = true;
            this.Lbl_Locacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Locacao.Location = new System.Drawing.Point(186, 143);
            this.Lbl_Locacao.Name = "Lbl_Locacao";
            this.Lbl_Locacao.Size = new System.Drawing.Size(137, 19);
            this.Lbl_Locacao.TabIndex = 126;
            this.Lbl_Locacao.Text = "Data da Locação";
            // 
            // Txt_Locacao
            // 
            this.Txt_Locacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Locacao.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Locacao.Location = new System.Drawing.Point(186, 165);
            this.Txt_Locacao.Name = "Txt_Locacao";
            this.Txt_Locacao.PlaceholderText = "Digite a data da locação";
            this.Txt_Locacao.Size = new System.Drawing.Size(151, 20);
            this.Txt_Locacao.TabIndex = 125;
            // 
            // DataGrid_ListarClientes
            // 
            this.DataGrid_ListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListarClientes.Location = new System.Drawing.Point(12, 56);
            this.DataGrid_ListarClientes.Name = "DataGrid_ListarClientes";
            this.DataGrid_ListarClientes.RowTemplate.Height = 25;
            this.DataGrid_ListarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ListarClientes.Size = new System.Drawing.Size(776, 78);
            this.DataGrid_ListarClientes.TabIndex = 127;
            // 
            // DataGrid_ListarLocado
            // 
            this.DataGrid_ListarLocado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListarLocado.Location = new System.Drawing.Point(12, 191);
            this.DataGrid_ListarLocado.Name = "DataGrid_ListarLocado";
            this.DataGrid_ListarLocado.RowTemplate.Height = 25;
            this.DataGrid_ListarLocado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ListarLocado.Size = new System.Drawing.Size(776, 77);
            this.DataGrid_ListarLocado.TabIndex = 128;
            // 
            // Txt_Cpf
            // 
            this.Txt_Cpf.Location = new System.Drawing.Point(12, 27);
            this.Txt_Cpf.Mask = "000,000,000-00";
            this.Txt_Cpf.Name = "Txt_Cpf";
            this.Txt_Cpf.Size = new System.Drawing.Size(151, 23);
            this.Txt_Cpf.TabIndex = 129;
            // 
            // DataGrid_ListarLocados
            // 
            this.DataGrid_ListarLocados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListarLocados.Location = new System.Drawing.Point(8, 342);
            this.DataGrid_ListarLocados.Name = "DataGrid_ListarLocados";
            this.DataGrid_ListarLocados.RowTemplate.Height = 25;
            this.DataGrid_ListarLocados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ListarLocados.Size = new System.Drawing.Size(776, 77);
            this.DataGrid_ListarLocados.TabIndex = 130;
            // 
            // Btn_AlterarLocacao
            // 
            this.Btn_AlterarLocacao.Location = new System.Drawing.Point(532, 313);
            this.Btn_AlterarLocacao.Name = "Btn_AlterarLocacao";
            this.Btn_AlterarLocacao.Size = new System.Drawing.Size(105, 23);
            this.Btn_AlterarLocacao.TabIndex = 137;
            this.Btn_AlterarLocacao.Text = "Alterar Locação";
            this.Btn_AlterarLocacao.UseVisualStyleBackColor = true;
            // 
            // Lbl_Modelo1
            // 
            this.Lbl_Modelo1.AutoSize = true;
            this.Lbl_Modelo1.Location = new System.Drawing.Point(655, 317);
            this.Lbl_Modelo1.Name = "Lbl_Modelo1";
            this.Lbl_Modelo1.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Modelo1.TabIndex = 136;
            this.Lbl_Modelo1.Text = "....";
            // 
            // Lbl_Placa1
            // 
            this.Lbl_Placa1.AutoSize = true;
            this.Lbl_Placa1.Location = new System.Drawing.Point(655, 296);
            this.Lbl_Placa1.Name = "Lbl_Placa1";
            this.Lbl_Placa1.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Placa1.TabIndex = 135;
            this.Lbl_Placa1.Text = "....";
            // 
            // Btn_AtualizarVeiculoLocado
            // 
            this.Btn_AtualizarVeiculoLocado.Location = new System.Drawing.Point(451, 313);
            this.Btn_AtualizarVeiculoLocado.Name = "Btn_AtualizarVeiculoLocado";
            this.Btn_AtualizarVeiculoLocado.Size = new System.Drawing.Size(75, 23);
            this.Btn_AtualizarVeiculoLocado.TabIndex = 134;
            this.Btn_AtualizarVeiculoLocado.Text = "Atualizar";
            this.Btn_AtualizarVeiculoLocado.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarVeiculoLocado
            // 
            this.Btn_BuscarVeiculoLocado.Location = new System.Drawing.Point(370, 313);
            this.Btn_BuscarVeiculoLocado.Name = "Btn_BuscarVeiculoLocado";
            this.Btn_BuscarVeiculoLocado.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarVeiculoLocado.TabIndex = 133;
            this.Btn_BuscarVeiculoLocado.Text = "Buscar";
            this.Btn_BuscarVeiculoLocado.UseVisualStyleBackColor = true;
            // 
            // Txt_BuscarVeiculoLocado
            // 
            this.Txt_BuscarVeiculoLocado.Location = new System.Drawing.Point(13, 313);
            this.Txt_BuscarVeiculoLocado.Name = "Txt_BuscarVeiculoLocado";
            this.Txt_BuscarVeiculoLocado.PlaceholderText = "Digite a placa do veiculo";
            this.Txt_BuscarVeiculoLocado.Size = new System.Drawing.Size(330, 23);
            this.Txt_BuscarVeiculoLocado.TabIndex = 132;
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(13, 295);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(122, 15);
            this.Lbl_Clientes.TabIndex = 131;
            this.Lbl_Clientes.Text = "Buscar Veiculo locado";
            // 
            // Lbl_Modelo2
            // 
            this.Lbl_Modelo2.AutoSize = true;
            this.Lbl_Modelo2.Location = new System.Drawing.Point(655, 447);
            this.Lbl_Modelo2.Name = "Lbl_Modelo2";
            this.Lbl_Modelo2.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Modelo2.TabIndex = 144;
            this.Lbl_Modelo2.Text = "....";
            // 
            // Lbl_Placa2
            // 
            this.Lbl_Placa2.AutoSize = true;
            this.Lbl_Placa2.Location = new System.Drawing.Point(655, 426);
            this.Lbl_Placa2.Name = "Lbl_Placa2";
            this.Lbl_Placa2.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Placa2.TabIndex = 143;
            this.Lbl_Placa2.Text = "....";
            // 
            // Btn_AtualizarVeiculoDisponivel
            // 
            this.Btn_AtualizarVeiculoDisponivel.Location = new System.Drawing.Point(451, 444);
            this.Btn_AtualizarVeiculoDisponivel.Name = "Btn_AtualizarVeiculoDisponivel";
            this.Btn_AtualizarVeiculoDisponivel.Size = new System.Drawing.Size(75, 23);
            this.Btn_AtualizarVeiculoDisponivel.TabIndex = 142;
            this.Btn_AtualizarVeiculoDisponivel.Text = "Atualizar";
            this.Btn_AtualizarVeiculoDisponivel.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarVeiculoDisponivel
            // 
            this.Btn_BuscarVeiculoDisponivel.Location = new System.Drawing.Point(370, 444);
            this.Btn_BuscarVeiculoDisponivel.Name = "Btn_BuscarVeiculoDisponivel";
            this.Btn_BuscarVeiculoDisponivel.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarVeiculoDisponivel.TabIndex = 141;
            this.Btn_BuscarVeiculoDisponivel.Text = "Buscar";
            this.Btn_BuscarVeiculoDisponivel.UseVisualStyleBackColor = true;
            // 
            // Txt_BuscarVeiculoDisponivel
            // 
            this.Txt_BuscarVeiculoDisponivel.Location = new System.Drawing.Point(13, 444);
            this.Txt_BuscarVeiculoDisponivel.Name = "Txt_BuscarVeiculoDisponivel";
            this.Txt_BuscarVeiculoDisponivel.PlaceholderText = "Digite a placa do veiculo";
            this.Txt_BuscarVeiculoDisponivel.Size = new System.Drawing.Size(330, 23);
            this.Txt_BuscarVeiculoDisponivel.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 139;
            this.label4.Text = "Buscar Veiculos";
            // 
            // DataGrid_ListarDisponiveis
            // 
            this.DataGrid_ListarDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ListarDisponiveis.Location = new System.Drawing.Point(8, 473);
            this.DataGrid_ListarDisponiveis.Name = "DataGrid_ListarDisponiveis";
            this.DataGrid_ListarDisponiveis.RowTemplate.Height = 25;
            this.DataGrid_ListarDisponiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ListarDisponiveis.Size = new System.Drawing.Size(776, 77);
            this.DataGrid_ListarDisponiveis.TabIndex = 138;
            // 
            // Btn_AlterarVeiculoDisponivel
            // 
            this.Btn_AlterarVeiculoDisponivel.Location = new System.Drawing.Point(532, 444);
            this.Btn_AlterarVeiculoDisponivel.Name = "Btn_AlterarVeiculoDisponivel";
            this.Btn_AlterarVeiculoDisponivel.Size = new System.Drawing.Size(105, 23);
            this.Btn_AlterarVeiculoDisponivel.TabIndex = 145;
            this.Btn_AlterarVeiculoDisponivel.Text = "Alterar Veiculo";
            this.Btn_AlterarVeiculoDisponivel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-26, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1197, 15);
            this.label5.TabIndex = 146;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Lbl_kmInicial
            // 
            this.Lbl_kmInicial.AutoSize = true;
            this.Lbl_kmInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_kmInicial.Location = new System.Drawing.Point(359, 143);
            this.Lbl_kmInicial.Name = "Lbl_kmInicial";
            this.Lbl_kmInicial.Size = new System.Drawing.Size(83, 19);
            this.Lbl_kmInicial.TabIndex = 148;
            this.Lbl_kmInicial.Text = "Km Inicial";
            // 
            // Txt_KmInicial
            // 
            this.Txt_KmInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_KmInicial.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_KmInicial.Location = new System.Drawing.Point(359, 165);
            this.Txt_KmInicial.Name = "Txt_KmInicial";
            this.Txt_KmInicial.PlaceholderText = "Digite a quilometragem de saida";
            this.Txt_KmInicial.Size = new System.Drawing.Size(167, 20);
            this.Txt_KmInicial.TabIndex = 147;
            // 
            // Lbl_KmFinal
            // 
            this.Lbl_KmFinal.AutoSize = true;
            this.Lbl_KmFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_KmFinal.Location = new System.Drawing.Point(532, 143);
            this.Lbl_KmFinal.Name = "Lbl_KmFinal";
            this.Lbl_KmFinal.Size = new System.Drawing.Size(76, 19);
            this.Lbl_KmFinal.TabIndex = 150;
            this.Lbl_KmFinal.Text = "Km Final";
            // 
            // Txt_KmFinal
            // 
            this.Txt_KmFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_KmFinal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_KmFinal.Location = new System.Drawing.Point(532, 165);
            this.Txt_KmFinal.Name = "Txt_KmFinal";
            this.Txt_KmFinal.PlaceholderText = "Digite a quilometragem de entrada";
            this.Txt_KmFinal.Size = new System.Drawing.Size(169, 20);
            this.Txt_KmFinal.TabIndex = 149;
            // 
            // Frm_CadastroLocações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 557);
            this.Controls.Add(this.Lbl_KmFinal);
            this.Controls.Add(this.Txt_KmFinal);
            this.Controls.Add(this.Lbl_kmInicial);
            this.Controls.Add(this.Txt_KmInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_AlterarVeiculoDisponivel);
            this.Controls.Add(this.Lbl_Modelo2);
            this.Controls.Add(this.Lbl_Placa2);
            this.Controls.Add(this.Btn_AtualizarVeiculoDisponivel);
            this.Controls.Add(this.Btn_BuscarVeiculoDisponivel);
            this.Controls.Add(this.Txt_BuscarVeiculoDisponivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGrid_ListarDisponiveis);
            this.Controls.Add(this.Btn_AlterarLocacao);
            this.Controls.Add(this.Lbl_Modelo1);
            this.Controls.Add(this.Lbl_Placa1);
            this.Controls.Add(this.Btn_AtualizarVeiculoLocado);
            this.Controls.Add(this.Btn_BuscarVeiculoLocado);
            this.Controls.Add(this.Txt_BuscarVeiculoLocado);
            this.Controls.Add(this.Lbl_Clientes);
            this.Controls.Add(this.DataGrid_ListarLocados);
            this.Controls.Add(this.Txt_Cpf);
            this.Controls.Add(this.DataGrid_ListarLocado);
            this.Controls.Add(this.DataGrid_ListarClientes);
            this.Controls.Add(this.Lbl_Locacao);
            this.Controls.Add(this.Txt_Locacao);
            this.Controls.Add(this.Lbl_Placa);
            this.Controls.Add(this.Txt_Placa);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Lbl_Cpf);
            this.Name = "Frm_CadastroLocações";
            this.Text = "Frm_CadastroLocações";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarLocado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarLocados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ListarDisponiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Lbl_Placa;
        private TextBox Txt_Placa;
        private Button Btn_Voltar;
        private Button Btn_Cadastrar;
        private Label Lbl_Cpf;
        private Label Lbl_Locacao;
        private TextBox Txt_Locacao;
        private DataGridView DataGrid_ListarClientes;
        private DataGridView DataGrid_ListarLocado;
        private MaskedTextBox Txt_Cpf;
        private DataGridView DataGrid_ListarLocados;
        private Button Btn_AlterarLocacao;
        private Label Lbl_Modelo1;
        private Label Lbl_Placa1;
        private Button Btn_AtualizarVeiculoLocado;
        private Button Btn_BuscarVeiculoLocado;
        private TextBox Txt_BuscarVeiculoLocado;
        private Label Lbl_Clientes;
        private Label Lbl_Modelo2;
        private Label Lbl_Placa2;
        private Button Btn_AtualizarVeiculoDisponivel;
        private Button Btn_BuscarVeiculoDisponivel;
        private TextBox Txt_BuscarVeiculoDisponivel;
        private Label label4;
        private DataGridView DataGrid_ListarDisponiveis;
        private Button Btn_AlterarVeiculoDisponivel;
        private Label label5;
        private Label Lbl_kmInicial;
        private TextBox Txt_KmInicial;
        private Label Lbl_KmFinal;
        private TextBox Txt_KmFinal;
    }
}