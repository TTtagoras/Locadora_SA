namespace LocadoraSA.Frm
{
    partial class Frm_cadastroCarros
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
            this.Lbl_Ano = new System.Windows.Forms.Label();
            this.Txt_Ano = new System.Windows.Forms.TextBox();
            this.Lbl_GPS = new System.Windows.Forms.Label();
            this.Txt_GPS = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Lbl_Tamanho = new System.Windows.Forms.Label();
            this.Txt_Tamanho = new System.Windows.Forms.TextBox();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.Lbl_Fabricante = new System.Windows.Forms.Label();
            this.Lbl_Categoria = new System.Windows.Forms.Label();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            this.Lbl_Cilindradas = new System.Windows.Forms.Label();
            this.Txt_Cilindradas = new System.Windows.Forms.TextBox();
            this.Txt_Fabricante = new System.Windows.Forms.TextBox();
            this.Lbl_Combustivel = new System.Windows.Forms.Label();
            this.Txt_Combustivel = new System.Windows.Forms.TextBox();
            this.Lbl_PainelDigital = new System.Windows.Forms.Label();
            this.Txt_PainelDigital = new System.Windows.Forms.TextBox();
            this.Lbl_Cambio = new System.Windows.Forms.Label();
            this.Txt_Cambio = new System.Windows.Forms.TextBox();
            this.Lbl_DatadeFabricação = new System.Windows.Forms.Label();
            this.Txt_DatadeFabricação = new System.Windows.Forms.TextBox();
            this.Lbl_ValorCompra = new System.Windows.Forms.Label();
            this.Txt_ValorCompra = new System.Windows.Forms.TextBox();
            this.Lbl_Placa = new System.Windows.Forms.Label();
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.Lbl_LCD = new System.Windows.Forms.Label();
            this.Txt_LCD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Ano
            // 
            this.Lbl_Ano.AutoSize = true;
            this.Lbl_Ano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Ano.Location = new System.Drawing.Point(347, 75);
            this.Lbl_Ano.Name = "Lbl_Ano";
            this.Lbl_Ano.Size = new System.Drawing.Size(40, 19);
            this.Lbl_Ano.TabIndex = 94;
            this.Lbl_Ano.Text = "Ano";
            // 
            // Txt_Ano
            // 
            this.Txt_Ano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Ano.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Ano.Location = new System.Drawing.Point(351, 97);
            this.Txt_Ano.Name = "Txt_Ano";
            this.Txt_Ano.PlaceholderText = "Digite o Ano do carro";
            this.Txt_Ano.Size = new System.Drawing.Size(151, 20);
            this.Txt_Ano.TabIndex = 84;
            // 
            // Lbl_GPS
            // 
            this.Lbl_GPS.AutoSize = true;
            this.Lbl_GPS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_GPS.Location = new System.Drawing.Point(190, 19);
            this.Lbl_GPS.Name = "Lbl_GPS";
            this.Lbl_GPS.Size = new System.Drawing.Size(43, 19);
            this.Lbl_GPS.TabIndex = 92;
            this.Lbl_GPS.Text = "GPS\t";
            this.Lbl_GPS.Click += new System.EventHandler(this.Lbl_GPS_Click);
            // 
            // Txt_GPS
            // 
            this.Txt_GPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_GPS.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_GPS.Location = new System.Drawing.Point(190, 41);
            this.Txt_GPS.Name = "Txt_GPS";
            this.Txt_GPS.PlaceholderText = "Digite se tem GPS ou não";
            this.Txt_GPS.Size = new System.Drawing.Size(151, 20);
            this.Txt_GPS.TabIndex = 82;
            //this.Txt_GPS.TextChanged += new System.EventHandler(this.Txt_GPS_TextChanged);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.Location = new System.Drawing.Point(30, 196);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(127, 33);
            this.Btn_Voltar.TabIndex = 91;
            this.Btn_Voltar.Text = "Voltar para  login";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(169, 197);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(130, 33);
            this.Btn_Cadastrar.TabIndex = 85;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Lbl_Tamanho
            // 
            this.Lbl_Tamanho.AutoSize = true;
            this.Lbl_Tamanho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Tamanho.Location = new System.Drawing.Point(30, 19);
            this.Lbl_Tamanho.Name = "Lbl_Tamanho";
            this.Lbl_Tamanho.Size = new System.Drawing.Size(80, 19);
            this.Lbl_Tamanho.TabIndex = 90;
            this.Lbl_Tamanho.Text = "Tamanho";
            // 
            // Txt_Tamanho
            // 
            this.Txt_Tamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Tamanho.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Tamanho.Location = new System.Drawing.Point(30, 40);
            this.Txt_Tamanho.Name = "Txt_Tamanho";
            this.Txt_Tamanho.PlaceholderText = "Digite o tamanho do carro.";
            this.Txt_Tamanho.Size = new System.Drawing.Size(151, 20);
            this.Txt_Tamanho.TabIndex = 81;
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Modelo.Location = new System.Drawing.Point(347, 19);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Modelo.TabIndex = 89;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Modelo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Modelo.Location = new System.Drawing.Point(347, 41);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.PlaceholderText = "Digite o modelo do carro";
            this.Txt_Modelo.Size = new System.Drawing.Size(151, 20);
            this.Txt_Modelo.TabIndex = 80;
            // 
            // Lbl_Fabricante
            // 
            this.Lbl_Fabricante.AutoSize = true;
            this.Lbl_Fabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Fabricante.Location = new System.Drawing.Point(190, 136);
            this.Lbl_Fabricante.Name = "Lbl_Fabricante";
            this.Lbl_Fabricante.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Fabricante.TabIndex = 88;
            this.Lbl_Fabricante.Text = "Fabricante";
            this.Lbl_Fabricante.Click += new System.EventHandler(this.Lbl_Telefone_Click);
            // 
            // Lbl_Categoria
            // 
            this.Lbl_Categoria.AutoSize = true;
            this.Lbl_Categoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Categoria.Location = new System.Drawing.Point(30, 75);
            this.Lbl_Categoria.Name = "Lbl_Categoria";
            this.Lbl_Categoria.Size = new System.Drawing.Size(83, 19);
            this.Lbl_Categoria.TabIndex = 87;
            this.Lbl_Categoria.Text = "Categoria";
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Categoria.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Categoria.Location = new System.Drawing.Point(30, 97);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.PlaceholderText = "Digite a categoria do carro";
            this.Txt_Categoria.Size = new System.Drawing.Size(151, 20);
            this.Txt_Categoria.TabIndex = 78;
            this.Txt_Categoria.TextChanged += new System.EventHandler(this.Txt_Categoria_TextChanged);
            // 
            // Lbl_Cilindradas
            // 
            this.Lbl_Cilindradas.AutoSize = true;
            this.Lbl_Cilindradas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cilindradas.Location = new System.Drawing.Point(30, 136);
            this.Lbl_Cilindradas.Name = "Lbl_Cilindradas";
            this.Lbl_Cilindradas.Size = new System.Drawing.Size(96, 19);
            this.Lbl_Cilindradas.TabIndex = 86;
            this.Lbl_Cilindradas.Text = "Cilindradas";
            // 
            // Txt_Cilindradas
            // 
            this.Txt_Cilindradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cilindradas.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Cilindradas.Location = new System.Drawing.Point(30, 158);
            this.Txt_Cilindradas.Name = "Txt_Cilindradas";
            this.Txt_Cilindradas.PlaceholderText = "Digite as cilindradas do carro";
            this.Txt_Cilindradas.Size = new System.Drawing.Size(151, 20);
            this.Txt_Cilindradas.TabIndex = 77;
            // 
            // Txt_Fabricante
            // 
            this.Txt_Fabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Fabricante.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Fabricante.Location = new System.Drawing.Point(190, 158);
            this.Txt_Fabricante.Name = "Txt_Fabricante";
            this.Txt_Fabricante.PlaceholderText = "Digite o fabricante do carro";
            this.Txt_Fabricante.Size = new System.Drawing.Size(151, 20);
            this.Txt_Fabricante.TabIndex = 95;
            // 
            // Lbl_Combustivel
            // 
            this.Lbl_Combustivel.AutoSize = true;
            this.Lbl_Combustivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Combustivel.Location = new System.Drawing.Point(520, 19);
            this.Lbl_Combustivel.Name = "Lbl_Combustivel";
            this.Lbl_Combustivel.Size = new System.Drawing.Size(105, 19);
            this.Lbl_Combustivel.TabIndex = 97;
            this.Lbl_Combustivel.Text = "Combustivel";
            // 
            // Txt_Combustivel
            // 
            this.Txt_Combustivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Combustivel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Combustivel.Location = new System.Drawing.Point(520, 40);
            this.Txt_Combustivel.Name = "Txt_Combustivel";
            this.Txt_Combustivel.PlaceholderText = "Digite qual o conbustivel do carro";
            this.Txt_Combustivel.Size = new System.Drawing.Size(169, 20);
            this.Txt_Combustivel.TabIndex = 96;
            // 
            // Lbl_PainelDigital
            // 
            this.Lbl_PainelDigital.AutoSize = true;
            this.Lbl_PainelDigital.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PainelDigital.Location = new System.Drawing.Point(351, 136);
            this.Lbl_PainelDigital.Name = "Lbl_PainelDigital";
            this.Lbl_PainelDigital.Size = new System.Drawing.Size(108, 19);
            this.Lbl_PainelDigital.TabIndex = 99;
            this.Lbl_PainelDigital.Text = "Painel Digital";
            // 
            // Txt_PainelDigital
            // 
            this.Txt_PainelDigital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PainelDigital.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_PainelDigital.Location = new System.Drawing.Point(351, 158);
            this.Txt_PainelDigital.Name = "Txt_PainelDigital";
            this.Txt_PainelDigital.PlaceholderText = "Digite se tem Painel Digital ou nao ";
            this.Txt_PainelDigital.Size = new System.Drawing.Size(163, 20);
            this.Txt_PainelDigital.TabIndex = 98;
            // 
            // Lbl_Cambio
            // 
            this.Lbl_Cambio.AutoSize = true;
            this.Lbl_Cambio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cambio.Location = new System.Drawing.Point(355, 197);
            this.Lbl_Cambio.Name = "Lbl_Cambio";
            this.Lbl_Cambio.Size = new System.Drawing.Size(68, 19);
            this.Lbl_Cambio.TabIndex = 101;
            this.Lbl_Cambio.Text = "Cambio";
            // 
            // Txt_Cambio
            // 
            this.Txt_Cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Cambio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Cambio.Location = new System.Drawing.Point(351, 219);
            this.Txt_Cambio.Name = "Txt_Cambio";
            this.Txt_Cambio.PlaceholderText = "Digite se é automatico ou manual";
            this.Txt_Cambio.Size = new System.Drawing.Size(167, 20);
            this.Txt_Cambio.TabIndex = 100;
            // 
            // Lbl_DatadeFabricação
            // 
            this.Lbl_DatadeFabricação.AutoSize = true;
            this.Lbl_DatadeFabricação.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DatadeFabricação.Location = new System.Drawing.Point(520, 75);
            this.Lbl_DatadeFabricação.Name = "Lbl_DatadeFabricação";
            this.Lbl_DatadeFabricação.Size = new System.Drawing.Size(156, 19);
            this.Lbl_DatadeFabricação.TabIndex = 103;
            this.Lbl_DatadeFabricação.Text = "Data de Fabricação";
            // 
            // Txt_DatadeFabricação
            // 
            this.Txt_DatadeFabricação.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DatadeFabricação.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_DatadeFabricação.Location = new System.Drawing.Point(520, 98);
            this.Txt_DatadeFabricação.Name = "Txt_DatadeFabricação";
            this.Txt_DatadeFabricação.PlaceholderText = "Data de fabricação do veiculo";
            this.Txt_DatadeFabricação.Size = new System.Drawing.Size(169, 20);
            this.Txt_DatadeFabricação.TabIndex = 102;
            // 
            // Lbl_ValorCompra
            // 
            this.Lbl_ValorCompra.AutoSize = true;
            this.Lbl_ValorCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ValorCompra.Location = new System.Drawing.Point(520, 136);
            this.Lbl_ValorCompra.Name = "Lbl_ValorCompra";
            this.Lbl_ValorCompra.Size = new System.Drawing.Size(136, 19);
            this.Lbl_ValorCompra.TabIndex = 105;
            this.Lbl_ValorCompra.Text = "Valor da Compra";
            // 
            // Txt_ValorCompra
            // 
            this.Txt_ValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ValorCompra.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_ValorCompra.Location = new System.Drawing.Point(520, 159);
            this.Txt_ValorCompra.Name = "Txt_ValorCompra";
            this.Txt_ValorCompra.PlaceholderText = "Valor que o carro foi comprado";
            this.Txt_ValorCompra.Size = new System.Drawing.Size(169, 20);
            this.Txt_ValorCompra.TabIndex = 104;
            // 
            // Lbl_Placa
            // 
            this.Lbl_Placa.AutoSize = true;
            this.Lbl_Placa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Placa.Location = new System.Drawing.Point(520, 196);
            this.Lbl_Placa.Name = "Lbl_Placa";
            this.Lbl_Placa.Size = new System.Drawing.Size(51, 19);
            this.Lbl_Placa.TabIndex = 107;
            this.Lbl_Placa.Text = "Placa";
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Placa.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Placa.Location = new System.Drawing.Point(520, 219);
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.PlaceholderText = "Digite a placa do carro";
            this.Txt_Placa.Size = new System.Drawing.Size(169, 20);
            this.Txt_Placa.TabIndex = 106;
            // 
            // Lbl_LCD
            // 
            this.Lbl_LCD.AutoSize = true;
            this.Lbl_LCD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_LCD.Location = new System.Drawing.Point(190, 75);
            this.Lbl_LCD.Name = "Lbl_LCD";
            this.Lbl_LCD.Size = new System.Drawing.Size(78, 19);
            this.Lbl_LCD.TabIndex = 109;
            this.Lbl_LCD.Text = "Tela LCD";
            // 
            // Txt_LCD
            // 
            this.Txt_LCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_LCD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_LCD.Location = new System.Drawing.Point(190, 98);
            this.Txt_LCD.Name = "Txt_LCD";
            this.Txt_LCD.PlaceholderText = "Digite se o carro tem LCD";
            this.Txt_LCD.Size = new System.Drawing.Size(151, 20);
            this.Txt_LCD.TabIndex = 110;
            // 
            // Frm_cadastroCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(693, 248);
            this.Controls.Add(this.Txt_LCD);
            this.Controls.Add(this.Lbl_LCD);
            this.Controls.Add(this.Lbl_Placa);
            this.Controls.Add(this.Txt_Placa);
            this.Controls.Add(this.Lbl_ValorCompra);
            this.Controls.Add(this.Txt_ValorCompra);
            this.Controls.Add(this.Lbl_DatadeFabricação);
            this.Controls.Add(this.Txt_DatadeFabricação);
            this.Controls.Add(this.Lbl_Cambio);
            this.Controls.Add(this.Txt_Cambio);
            this.Controls.Add(this.Lbl_PainelDigital);
            this.Controls.Add(this.Txt_PainelDigital);
            this.Controls.Add(this.Lbl_Combustivel);
            this.Controls.Add(this.Txt_Combustivel);
            this.Controls.Add(this.Txt_Fabricante);
            this.Controls.Add(this.Lbl_Ano);
            this.Controls.Add(this.Txt_Ano);
            this.Controls.Add(this.Lbl_GPS);
            this.Controls.Add(this.Txt_GPS);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Lbl_Tamanho);
            this.Controls.Add(this.Txt_Tamanho);
            this.Controls.Add(this.Lbl_Modelo);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.Lbl_Fabricante);
            this.Controls.Add(this.Lbl_Categoria);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Lbl_Cilindradas);
            this.Controls.Add(this.Txt_Cilindradas);
            this.Name = "Frm_cadastroCarros";
            this.Text = "Cadastrar Veiculos";
            this.Load += new System.EventHandler(this.Frm_cadastroVeiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Ano;
        private TextBox Txt_Ano;
        private TextBox Txt_TelaLcd;
        private Label Lbl_GPS;
        private TextBox Txt_GPS;
        private Button Btn_Voltar;
        private Button Btn_Cadastrar;
        private Label Lbl_Tamanho;
        private TextBox Txt_Tamanho;
        private Label Lbl_Modelo;
        private TextBox Txt_Modelo;
        private Label Lbl_Fabricante;
        private Label Lbl_Categoria;
        private TextBox Txt_Categoria;
        private Label Lbl_Cilindradas;
        private TextBox Txt_Cilindradas;
        private TextBox Txt_Fabricante;
        private Label Lbl_Combustivel;
        private TextBox Txt_Combustivel;
        private Label Lbl_PainelDigital;
        private TextBox Txt_PainelDigital;
        private Label Lbl_Cambio;
        private TextBox Txt_Cambio;
        private Label Lbl_DatadeFabricação;
        private TextBox Txt_DatadeFabricação;
        private Label Lbl_ValorCompra;
        private TextBox Txt_ValorCompra;
        private Label Lbl_Placa;
        private TextBox Txt_Placa;
        //private TextBox Txt_TelaLcd;
        private Label Lbl_LCD;
        private TextBox Txt_LCD;
    }
}