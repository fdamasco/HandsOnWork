using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using HandsOnWorkBiblioteca.Databases;
using HandsOnWorkBiblioteca;
using System.Data;


//Biblioteca destinada às regras de negócio
namespace HandsOnWorkBiblioteca
{
    public class Clientes
    {


        //Subclasse que representa a unidade de Cliente
        public class Unit
        {

            public string Id { get; set; }

            [Required(ErrorMessage = "Campo 'Nome' é obrigatório!")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Campo 'CPF' é obrigatório!")]
            [RegularExpression(("[0-9]+"), ErrorMessage = "O campo 'CPF' aceita apenas números!")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo 'CPF' deve ter 11 dígitos!")]

            public string Cpf { get; set; }

            [Required(ErrorMessage = "Campo 'E-mail' é obrigatório!")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Campo 'Conta' é obrigatório!")]
            [RegularExpression(("[0-9]+"), ErrorMessage = "Campo 'Conta' aceita apenas números!")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Campo 'Conta' deve ter 8 dígitos!")]
            public string Conta { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());

                }
            }


            #region


            public string ToInsert()
            {
                string SQL;
                SQL = @"INSERT INTO Tb_Cliente
                    (Id
                    ,Nome
                    ,Cpf
                    ,Email
                    ,Conta)
                     VALUES ";
                SQL += "('" + this.Id + "'";
                SQL += ", '" + this.Nome + "'";
                SQL += ", '" + this.Cpf + "'";
                SQL += ", '" + this.Email + "'";
                SQL += ", '" + this.Conta + "');";
                return SQL;

            }

            public string ToUpdate(string Id)
            {
                string SQL;
                SQL = @"UPDATE Tb_Cliente
                    SET ";
                SQL += "Id = '" + this.Id + "'";
                SQL += ", Nome = '" + this.Nome + "'";
                SQL += "  , Cpf = '" + this.Cpf + "'";
                SQL += "  , Email = '" + this.Email + "'";
                SQL += "  , Conta = '" + this.Conta + "'";
                SQL += " WHERE Id = '" + Id + "';";
                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.Id = dr["Id"].ToString();
                u.Nome = dr["Nome"].ToString();
                u.Cpf = dr["Cpf"].ToString();
                u.Email = dr["Email"].ToString();
                u.Conta = dr["Conta"].ToString();
                return u;
            }

            public void Incluir()
            {
                try
                {
                    string SQL;
                    SQL = this.ToInsert();
                    var db = new SQLServerClass();
                    db.SQLCommand(SQL);
                    db.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Cadastro não incluído!" + ex.Message);
                }

            }

            public Unit Listar(string Id)
            {
                try
                {
                    string SQL = "SELECT *  FROM [Tb_Cliente] WHERE Id = '" + Id + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if(Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Cliente inexistente!");
                    }
                    else
                    {
                        Unit u = this.DataRowToUnit(Dt.Rows[0]);
                        return u;
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception("ERRO: " + ex.Message);
                }
            }

            public void Editar()
            {
                try
                {
                    string SQL = "SELECT *  FROM [Tb_Cliente] WHERE Id = '" + Id + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Cliente inexistente!" + Id);
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.Id);
                        db.SQLCommand(SQL);
                        db.Close();

                    }
                }

                catch (Exception ex)
                {
                    throw new Exception("ERRO: " + ex.Message);
                }
            }

            public void Excluir()
            {
                try
                {
                    string SQL = "SELECT *  FROM [Tb_Cliente] WHERE Id = '" + this.Id + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Cliente inexistente!" + this.Id); ;
                    }
                    else
                    {
                        SQL = "DELETE FROM Tb_Cliente WHERE Id = '" + this.Id + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("ERRO: " + ex.Message);
                }
            }

            public List<List<string>> Pesquisar()
            {
                List<List<string>> ListaPesquisa = new List<List<string>>();
                try
                {
                    var SQL = "SELECT * FROM Tb_Cliente";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        ListaPesquisa.Add(new List<string> { Dt.Rows[i]["Id"].ToString(), Dt.Rows[i]["Nome"].ToString() });
                    }
                    return ListaPesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("ERRO: " + ex.Message);
                }
            }

            #endregion

            //#region

            //    string clienteJson = Clientes.SerializedClassUnit(this);
            //    FicharioSQLServer F = new FicharioSQLServer(Conexao);
            //    if (F.status)
            //    {
            //        F.Cadastrar(this.Id, clienteJson);
            //        if (!(F.status))
            //        {
            //            throw new Exception(F.mensagem);
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception(F.mensagem);
            //    }
            //}


            //public void EditarFicharioSQL(string conexao)
            //{
            //    string clienteJson = Clientes.SerializedClassUnit(this);
            //    FicharioSQLServer F = new FicharioSQLServer(conexao);
            //    if (F.status)
            //    {
            //        F.Editar(this.Id, clienteJson);
            //        if (!(F.status))
            //        {
            //            throw new Exception(F.mensagem);
            //        }
            //    }

            //    else
            //    {
            //        throw new Exception(F.mensagem);
            //    }
            //}

            //public void ExcluirFicharioSQL(string conexao)
            //{
            //    FicharioSQLServer F = new FicharioSQLServer(conexao);
            //    if (F.status)
            //    {
            //        F.Apagar(this.Id);
            //        if (!(F.status))
            //        {
            //            throw new Exception(F.mensagem);
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception(F.mensagem);
            //    }

            //}

            //public Unit ListarFicharioSQL(string id, string conexao)
            //{
            //    FicharioSQLServer F = new FicharioSQLServer(conexao);
            //    if (F.status)
            //    {
            //        string clienteJson = F.Listar(id);
            //        return Clientes.DesSerializedClassUnit(clienteJson);
            //    }
            //    else
            //    {
            //        throw new Exception(F.mensagem);
            //    }
            //}

            //public List<List<string>> PesquisarFicharioSQL(string conexao)
            //{
            //    FicharioSQLServer F = new FicharioSQLServer(conexao);
            //    if (F.status)
            //    {
            //        List<string> List = new List<string>();
            //        List = F.Pesquisar();
            //        if (F.status)
            //        {
            //            List<List<string>> ListPesquisar = new List<List<string>>();
            //            for (int i = 0; i <= List.Count - 1; i++)
            //            {
            //                Clientes.Unit Cliente = Clientes.DesSerializedClassUnit(List[i]);
            //                ListPesquisar.Add(new List<string> { Cliente.Id, Cliente.Nome });
            //            }
            //            return ListPesquisar;
            //        }
            //        else
            //        {
            //            throw new Exception(F.mensagem);
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception(F.mensagem);
            //    }
            //}

            //#endregion


            //A lista de clientes é um conjunto de Clientes.Unit
            public class List
            {

                public List<Unit> ListUnit { get; set; }
            }

            public static string SerializedClassUnit(Unit unit)
            {
                return JsonConvert.SerializeObject(unit);
            }

            //Método para transformar string em Json
            public static Unit DesSerializedClassUnit(string vJson)
            {
                return JsonConvert.DeserializeObject<Unit>(vJson);
            }
        }
    }
}
