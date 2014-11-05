using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebAula5
{
    public partial class ExemploADO_NET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCriarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn;
                //Utilizando Usuário do Banco
                //strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=123123";
                //Utilizando Usuário do Windows
                strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                string sql = "CREATE DATABASE TesteAula05;";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected void btnCriarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TesteAula05;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                string sql = "CREATE TABLE Pessoas (" +
                     "id       int IDENTITY," +
                     "nome     varchar(40) NOT NULL," +
                     "endereco	char(80)," +
                     "cpf	numeric(11) UNIQUE, " +
                     "PRIMARY KEY(id))";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        protected void btnInserirDados_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TesteAula05;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                string sql = "INSERT INTO Pessoas (Nome, Endereco, Cpf) " +
                              "VALUES ('Nero', 'Av. da Labareda, ROMA',12345678901);" +
                   "INSERT INTO Pessoas (Nome, Endereco, Cpf) " +
                   "VALUES ('Gensis Khan', 'Av. dos Unos, Persia',12345678902);";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected void btnLerDadosConectado_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TesteAula05;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                string sql = "SELECT * FROM Pessoas";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                StringBuilder buff = new StringBuilder();
                while (sqlDataReader.Read())
                {
                    buff.AppendFormat("Nome: {0} - Endereço: {1} \n", 
                        sqlDataReader["Nome"].ToString().Trim(), 
                        sqlDataReader["Endereco"].ToString().Trim());
                }
                connection.Close();
                System.Diagnostics.Debug.WriteLine(buff);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected void btnLerDadosDesconectado_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TesteAula05;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * FROM Pessoas", connection);
                System.Data.DataSet dataSet = new System.Data.DataSet();
                sqlDataAdapter.Fill(dataSet);

                connection.Close();

                StringBuilder buff = new StringBuilder();
                foreach (System.Data.DataRow dataRow in dataSet.Tables[0].Rows) {
                    buff.AppendFormat("Nome: {0} - Endereço: {1} \n",
                        dataRow["Nome"].ToString().Trim(),
                        dataRow["Endereco"].ToString().Trim());
                }
                System.Diagnostics.Debug.WriteLine(buff);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected void btnAlterarDadosDesconectado_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TesteAula05;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * FROM Pessoas", connection);
                System.Data.DataSet dataSet = new System.Data.DataSet();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Fill(dataSet, "Pessoas");

                connection.Close();

                StringBuilder buff = new StringBuilder();
                foreach (System.Data.DataRow dr in dataSet.Tables[0].Rows)
                {
                    buff.AppendFormat("Nome: {0} - Endereço: {1} \n",
                        dr["Nome"].ToString().Trim(),
                        dr["Endereco"].ToString().Trim());
                }
                connection.Close();
                System.Diagnostics.Debug.WriteLine(buff);

                System.Data.DataRow alteraDR = dataSet.Tables[0].Rows[0];
                alteraDR["Nome"] = "Cleopatra";

                //Abre novamente a conexão com o banco
                connection.Open();
                sqlDataAdapter.Update(dataSet, "Pessoas");
                connection.Close();
                
                buff.Clear();
                buff.AppendLine("=== Registros Alterados ===");
                foreach (System.Data.DataRow dr in dataSet.Tables[0].Rows)
                {
                    buff.AppendFormat("Nome: {0} - Endereço: {1} \n",
                        dr["Nome"].ToString().Trim(),
                        dr["Endereco"].ToString().Trim());
                }
                System.Diagnostics.Debug.WriteLine(buff);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        protected void btnPreencheGridView_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TesteAula05;Integrated Security=True";
                SqlConnection connection = new SqlConnection(strConn);
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * FROM Pessoas", connection);
                System.Data.DataSet dataSet = new System.Data.DataSet();
                sqlDataAdapter.Fill(dataSet);

                connection.Close();

                System.Data.DataView dataView = new DataView(dataSet.Tables[0]);
                gvTestes.DataSource = dataView;
                gvTestes.DataBind();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
    }
}