using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HandsOnWorkBiblioteca.Databases
{
    public class SQLServerClass
    {
        public string stringConexao;
        public SqlConnection ConexaoDB;

        public SQLServerClass()
        {
            try
            {
                stringConexao = "Data Source=LAPTOP-J8CT7NCF;Initial Catalog=UniBank;Persist Security Info=True;User ID=sa;Password=123";
                ConexaoDB = new SqlConnection(stringConexao);
                ConexaoDB.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string SQL)
        {

            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(SQL, ConexaoDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, ConexaoDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            ConexaoDB.Close();
        }

    }

}
