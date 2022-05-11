using LocadoraSA.DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraSA.DTO
{
    internal class Clientes
    {
        private conexaoDB cliente;

        private string _CPF;
        private string _Nome;
        private string _Sobrenome;
        private string _Senha;
        private string _Endereco;
        private string _Telefone;
        private string _Email;
        private string _CNH;
        private string _CEP;


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


        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return _Sobrenome;
            }
            set
            {
                _Sobrenome = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                _Senha = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _Endereco;
            }
            set
            {
                _Endereco = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }
            set
            {
                _Telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string CNH
        {
            get
            {
                return _CNH;
            }
            set
            {
                _CNH = value;
            }

        }

        public string CEP
        {
            get
            {
                return _CEP;
            }
            set
            {
                _CEP = value;
            }
        }
        public Clientes()
        {
            this.cliente = new conexaoDB();

        }
        public void CadastrarCliente()
        {
            this.cliente.NonQuery(
                "INSERT INTO `locadorasa`.`clientes`(`CPF`, `Nome`, `Sobrenome`, `Senha`, `Endereco`, `Telefone`, `Email`, `CNH`, `CEP`) VALUES('" + CPF + "', '" + Nome + "', '" + Sobrenome + "', '" + Senha + "', '" + Endereco + "', '" + Telefone + "', '" + Email + "', '" + CNH + "', '" + CEP + "');"
            );
        }

        public void AlterarCliente(string idCliente)
        {
            this.cliente.NonQuery(
                "UPDATE `locadorasa`.`clientes` SET `CPF`= '" + CPF + "',`Nome`= '" + Nome + "',`Sobrenome`= '" + Sobrenome + "',`Senha`= '" + Senha + "',`Endereco`= '" + Endereco + "',`Telefone`= '" + Telefone + "',`Email`= '" + Email + "',`CNH`= '" + CNH + "',`CEP`= '" + CEP + "' WHERE id = '" + idCliente + "'"
                );
        }


        public MySqlDataReader ListarClientes()
        {
            return this.cliente.Query("Select * from clientes order by CPF asc");
        }

        public MySqlDataReader ListarClientes(String filtro)
        {
            if (filtro == "")
            {
                return ListarClientes();
            }
            return this.cliente.Query("Select * from clientes where CPF LIKE '%" + filtro + "%' order by CPF asc");
        }

        public Clientes(string CPF, string Nome, string Sobrenome, string Senha, string Endereco, string Telefone, string Email, string CNH, string CEP)
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Senha = Senha;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            this.Email = Email;
            this.CNH = CNH;
            this.CEP = CEP;
            
            
        }
    }
}

