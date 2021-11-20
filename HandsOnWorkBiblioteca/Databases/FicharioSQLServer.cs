using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWorkBiblioteca.Databases
{
    public class FicharioSQLServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SQLServerClass db;


        public FicharioSQLServer(string Tabela)
        {
            status = true;
            try
            {
                // Instanciando a conexão com o banco 
                db = new SQLServerClass();
                tabela = Tabela;
                mensagem = "Conexão com o Banco de Dados realizada com sucesso!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "ERRO: " + ex.Message;
            }
        }


        public void Cadastrar(string Id, string jsonUnit)
        {
            status = true;
            try
            {

                //INSERT INTO CLIENTE (ID, JSON) VALUES ('0', '{..})

                var SQL = "INSERT INTO " + tabela + "(Id, JSON) VALUES ('" + Id + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = "Cliente cadastrado com sucesso!";
            }

            catch (Exception ex)
            {
                status = false;
                mensagem = "ERRO: " + ex.Message;
            }

        }

        public string Listar(string Id)
        {
            status = true;
            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID = "0"

                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Cliente não existe!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "ERRO: " + ex.Message;
            }
            return "";

        }


        public List<string> Pesquisar()
        {
            status = true;
            //Variável de lista de strings, que vai ser o retorno da função
            List<string> List = new List<string>();
            try
            {
                // SELECT ID, JSON FROM CLIENTE 

                var SQL = "SELECT Id, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existem Clientes na Base de Dados!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "ERRO: " + ex.Message;
            }
            return List;
        }


        public void Apagar(string Id)
        {
            status = true;
            try
            {
                //Verifica se identificador existe
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // DELETE FROM CLIENTE WHERE ID = "0"

                    SQL = "DELETE FROM " + tabela + " WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Exclusão realizada com sucesso!";
                }
                else
                {
                    status = false;
                    mensagem = "Cliente não existe!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "ERRO: " + ex.Message;
            }
        }

        public void Editar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // UPDATE CLIENTE SET JASON = '{NOVO VALOR}' WHERE ID = "0"
                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Edição realizada com sucesso!";
                }
                else
                {
                    status = false;
                    mensagem = "Edição não permitida! O Cliente não existe!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "ERRO: " + ex.Message;
            }

        }


    }
  }
