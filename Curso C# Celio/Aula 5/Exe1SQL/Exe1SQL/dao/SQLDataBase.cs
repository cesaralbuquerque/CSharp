using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Exe1SQL.dao
{
    class SQLDataBase : IDB
    {
        private static string dadosConexao = "Data Source=localhost\\SQLEXPRESS; Initial Catalog = master; Integrated Security=True";
        private static string criaBanco = "create database TesteAula5Cesar";
        private SqlConnection connection = new SqlConnection(dadosConexao);


        //executar no construtor
        //public void criaDB()
        //{
        //    //cria DB
        //    SqlConnection connection = new SqlConnection(dadosConexao);
        //    connection.Open();
        //    SqlCommand sqlCommand = new SqlCommand(criaBanco, connection);
        //    sqlCommand.ExecuteNonQuery();
        //    connection.Close();
        //}

        /**
         *O DataTable é um objeto central na biblioteca ADO.NET. Outros objetos que usam o DataTable incluem o DataSet e o DataView.
         */
        public System.Data.DataTable dataTable(string sql)
        {
            return dataSet(sql).Tables[0];

        }

        /**
         * componente principal da arquitetura ADO.NET. DataSet consiste em uma coleção de objetos DataTable
         */
        public System.Data.DataSet dataSet(string sql)
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            sqlDataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;
        }

        /**
         * consultar a estrutura de um banco de dados ou criar objetos de banco de dados como tabelas
         * UPDATE, INSERT ou DELETE
         */
        public int executeNoQuery(string sql)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            int x = sqlCommand.ExecuteNonQuery();
            connection.Close();
            return x;
        }

        /**
         * Executa a consulta, e retorna a primeira coluna da primeira linha no conjunto de resultados retornados pela consulta
         */
        public object executeScalar(string sql)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            object x = sqlCommand.ExecuteScalar();
            connection.Close();
            return x;
        }
    }
}
