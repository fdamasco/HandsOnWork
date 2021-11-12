using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Classe para salvar dados enquanto não houver ligação com banco de dados

namespace HandsOnWorkBiblioteca.Classes.Databases
{
    public class Fichario
    {

        public string diretorio;
        public string mensagem;
        public bool status;

        //string de conexão
        public Fichario(string Diretorio)
        {

            status = true;

            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o Fichário criada com sucesso!";
            }

            catch (Exception ex)
            {
                status = false;
                mensagem = "Não foi possível conectar com o Fichário: " + ex.Message;
            }

        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Cadastro em duplicidade! O Cliente de identificador " + Id + " já existe!";
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Cliente cadastrado com sucesso!";
                }
            }

            catch (Exception ex)
            {
                status = false;
                mensagem = "Não foi possível conectar com o Fichário: " + ex.Message;
            }
           
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Cliente não existente!";
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    status = true;
                    mensagem = "Cliente cadastrado com sucesso!";
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
               status = false;
               mensagem = "Erro ao buscar o conteúdo do identificador do cliente: " + ex.Message;
            }
            return "";
        }

        public List<string> Listar()
        {
            status = true;
            //Variável de lista de strings, que vai ser o retorno da função
            List<string> List = new List<string>();
            try
            {
                //For para ler arquivo por arquivo
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador do cliente: " + ex.Message;
            }
            return List;
        }



        public void Apagar(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Cliente não existente!";
                }
                else
                {
                   File.Delete(diretorio + "\\" + Id + ".json");
                   status = true;
                   mensagem = "Exclusão realizada com sucesso!";
                   
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador do cliente: " + ex.Message;
            }
        }



        public void Editar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    mensagem = "Alteração não permitida! O Cliente de identificador " + Id + " não existe!";
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Edição realizada com sucesso!";
                }
            }

            catch (Exception ex)
            {
                status = false;
                mensagem = "Não foi possível conectar com o Fichário: " + ex.Message;
            }

        }
    }
}
