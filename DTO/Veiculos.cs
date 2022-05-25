using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraSA.DTO;
using MySql.Data.MySqlClient;

namespace LocadoraSA.DataBase;

    internal class Veiculos
    {

        private conexaoDB cliente;

        private string _Tamanho;
        private string _Categoria;
        private string _Cilindradas;
        private string _GPS;
        private string _TelaLcd;
        private string _Fabricante;
        private string _Modelo;
        private string _Ano;
        private string _PainelDigital;
        private string _Cambio;
        private string _Combustivel;
        private string _DatadeFabricação;
        private string _ValorCompra;
        private string _Placa;


        public string Tamanho
        {
            get
            {
                return _Tamanho;
            }
            set
            {
                _Tamanho = value;
            }
        }


        public string Categoria
        {
            get
            {
                return _Categoria;
            }
            set
            {
                _Categoria = value;
            }
        }

        public string Cilindradas
        {
            get
            {
                return _Cilindradas;
            }
            set
            {
                _Cilindradas = value;
            }
        }

        public string GPS
        {
            get
            {
                return _GPS;
            }
            set
            {
                _GPS = value;
            }
        }

        public string TelaLcd
        {
            get
            {
                return _TelaLcd;
            }
            set
            {
                _TelaLcd = value;
            }
        }

        public string Fabricante
        {
            get
            {
                return _Fabricante;
            }
            set
            {
                _Fabricante = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _Modelo;
            }
            set
            {
                _Modelo = value;
            }
        }

        public string Ano
        {
            get
            {
                return _Ano;
            }
            set
            {
                _Ano = value;
            }

        }
        public string PainelDigital
        {
            get
            {
                return _PainelDigital;
            }
            set
            {
                _PainelDigital = value;
            }
        }
        public string Cambio
        {
            get
            {
                return _Cambio;
            }
            set
            {
                _Cambio = value;
            }
        }
        public string Combustivel
        {
            get
            {
                return _Combustivel;
            }
            set
            {
                _Combustivel = value;
            }
        }
        public string DatadeFabricação
        {
            get
            {
                return _DatadeFabricação;
            }
            set
            {
                _DatadeFabricação = value;
            }
        }
        public string ValorCompra
        {
            get
            {
                return _ValorCompra;
            }
            set
            {
                _ValorCompra = value;
            }
        }

        public string Placa
        {
            get
            {
                return _Placa;
            }
            set
            {
                _Placa = value;
            }
        }
        public Veiculos()
        {
            this.cliente = new conexaoDB();

        }

        public void CadastrarCliente()
        {
            this.cliente.NonQuery(
                "INSERT INTO `locadorasa`.`veiculos`(`Tamanho`, `Categoria`, `Cilindradas`, `GPS`, `TelaLcd`, `Fabricante`, `Modelo`, `Ano`, `PainelDigital`, `Cambio`, `Combustivel`, `DatadeFabricação`, `ValorCompra`, `Placa`) VALUES('" + Tamanho + "', '" + Categoria + "', '" + Cilindradas + "', '" + GPS + "', '" + TelaLcd + "', '" + Fabricante + "', '" + Modelo + "', '" + Ano + "', '" + PainelDigital + "', '" + Cambio + "', '" + Combustivel + "', '" + DatadeFabricação + "', '" + ValorCompra + "', '" + Placa + "');"
            );
        }

        public void AlterarCliente(string idCliente)
        {
            this.cliente.NonQuery(
                "UPDATE `locadorasa`.`veiculos` SET `Tamanho`= '" + Tamanho + "',`Categoria`= '" + Categoria + "',`Cilindradas`= '" + Cilindradas + "',`GPS`= '" + GPS + "',`TelaLcd`= '" + TelaLcd + "',`Fabricante`= '" + Fabricante + "',`Modelo`= '" + Modelo + "',`Ano`= '" + Ano + "',`PainelDigital`= '" + PainelDigital + "',`Cambio`= '" + Cambio + "',`Combustivel`= '" + Combustivel + "',`DatadeFabricação`= '" + DatadeFabricação + "',`ValorCompra`= '" + ValorCompra + "',`Placa`= '" + Placa + "' WHERE id = '" + idCliente + "'"
                );
        }


        public MySqlDataReader ListarClientes()
        {
            return this.cliente.Query("Select * from `locadorasa`.`veiculos` order by Placa asc");
        }

        public MySqlDataReader ListarClientes(String filtro)
        {
            if (filtro == "")
            {
                return ListarClientes();
            }
            return this.cliente.Query("Select * from `locadorasa`.`veiculos` where Placa LIKE '%" + filtro + "%' order by Placa asc");
        }

        public Veiculos(string Tamanho, string Categoria, string Cilindradas, string GPS, string TelaLcd, string Fabricante, string Modelo, string Ano, string PainelDigital, string Cambio, string Combustivel, string DatadeFabricação, string ValorCompra, string Placa)
        {
            this.Tamanho = Tamanho;
            this.Categoria = Categoria;
            this.Cilindradas = Cilindradas;
            this.GPS = GPS;
            this.TelaLcd = TelaLcd;
            this.Fabricante = Fabricante;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.PainelDigital = PainelDigital;
            this.Cambio = Cambio;
            this.Combustivel = Combustivel;
            this.Cilindradas = DatadeFabricação;
            this.GPS = ValorCompra;
            this.TelaLcd = Placa;


        }
    }

