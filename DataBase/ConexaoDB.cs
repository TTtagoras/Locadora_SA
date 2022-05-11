using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using LocadoraSA.Frm;

namespace LocadoraSA.DataBase
{
    class conexaoDB
    {
        private MySqlConnection con;
        private MySqlCommand command;

        public conexaoDB()
        {
            Conectar();
        }

        public void Conectar()
        {



            String stringCon = ConfigurationSettings.AppSettings["ConexaoBD"];
            this.con = new MySqlConnection(stringCon);
            this.command = this.con.CreateCommand();
            this.con.Open();
        }

        public void NonQuery(String sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery();
        }
        public MySqlDataReader Query(String sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();
        }

    }
}
