using LocadoraSA.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace LocadoraSA.DTO
{
    internal class Locações
    {
        private conexaoDB cliente;

        private string _CPF;
        private string _Placa;
        private string _DataLocacao;
        private string _DataDevolucao;
        private string _KmInicial;
        private string _KmFinal;


        public string CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                _CPF = value;
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

        public string DataLocacao
        {
            get
            {
                return _DataLocacao;
            }
            set
            {
                _DataLocacao = value;
            }
        }

        public string DataDevolucao
        {
            get
            {
                return _DataDevolucao;
            }
            set
            {
                _DataDevolucao = value;
            }
        }

        public string KmInicial
        {
            get
            {
                return _KmInicial;
            }
            set
            {
                _KmInicial = value;
            }
        }
        public string KmFinal
        {
            get
            {
                return _KmFinal;
            }
            set
            {
                _KmFinal = value;
            }
        }
        public Locações()
        {
            this.cliente = new conexaoDB();

        }
        public void CadastrarCliente()
        {
            this.cliente.NonQuery(
                "INSERT INTO `locadorasa`.`locados`(`CPF`, `Placa`, `DataLocacao`, `DataDevolucao`, `KmInicial`, `KmFinal`) VALUES('" + CPF + "', '" + Placa + "', '" + DataLocacao + "', '" + DataDevolucao + "', '" + KmInicial + "', '" + KmFinal + "');"
                //"UPDATE `locadorasa`.`veiculos` SET `locado`= 's'"
            );
        }
        public void AlterarLocacao()
        {
            this.cliente.NonQuery("UPDATE `locadorasa`.`veiculos` SET `locado`= 'S' WHERE `Placa` = '" + Placa + "'"
            );
        }
        public void AlterarCliente(string idCliente)
        {
            this.cliente.NonQuery(
                "UPDATE `locadorasa`.`locados` SET `CPF`= '" + CPF + "',`Placa`= '" + Placa + "',`DataLocacao`= '" + DataLocacao + "',`DataDevolucao`= '" + DataDevolucao + "',`KmInicial`= '" + KmInicial + "',`KmFinal`= '" + KmFinal + "'"
                );
        }
        public MySqlDataReader ListarClientes()
        {
            return this.cliente.Query("Select * from `locadorasa`.`clientes` order by CPF asc");
        }
        public MySqlDataReader ListarCarros()
        {
            return this.cliente.Query("Select * from `locadorasa`.`veiculos` order by Placa asc");
        }
        public MySqlDataReader ListarLocados()
        {
            return this.cliente.Query("Select * from `locadorasa`.`locados` order by Placa asc");
        }
        public MySqlDataReader ListarLocados(string Filtro)
        {
            return this.cliente.Query("Select * from `locadorasa`.`locados` order by Placa asc");
        }
        public Locações(string CPF, string Placa, string DataLocacao, string DataDevolucao, string KmInicial, string KmFinal)
        {
            this.CPF = CPF;
            this.Placa = Placa;
            this.DataLocacao = DataLocacao;
            this.DataDevolucao = DataDevolucao;
            this.KmInicial = KmInicial;
            this.KmFinal = KmFinal;
        }
    }
}
