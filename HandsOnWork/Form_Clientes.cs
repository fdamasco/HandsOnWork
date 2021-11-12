using System;
using HandsOnWorkBiblioteca;
using HandsOnWorkBiblioteca.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using HandsOnWorkBiblioteca.Classes.Databases;

namespace HandsOnWork
{
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
            LimparCampos();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                Clientes.Unit Cliente = new Clientes.Unit();
                Cliente = LeituraFormulario();
                Cliente.ValidaClasse();
                //transformação da classe em string
                string clienteJson = Clientes.SerializedClassUnit(Cliente);
                // conexão com fichário
                Fichario F = new Fichario("C:\\Users\\fedam\\OneDrive\\Documentos\\HoW4\\Fichario");
                if (F.status)
                {
                    F.Incluir(Cliente.Id, clienteJson);
                    if (F.status)
                    {
                        MessageBox.Show(F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (ValidationException Excep)
            {
                MessageBox.Show(Excep.Message, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //Se o identificador do cliente estiver em branco, o sistema aponta a seguinte mensagem:
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Código do Cliente não existe!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    Clientes.Unit Cliente = new Clientes.Unit();
                    Cliente = LeituraFormulario();
                    Cliente.ValidaClasse();
                    //transformação da classe em string
                    string clienteJson = Clientes.SerializedClassUnit(Cliente);
                    // conexão com fichário
                    Fichario F = new Fichario("C:\\Users\\fedam\\OneDrive\\Documentos\\HoW4\\Fichario");
                    if (F.status)
                    {
                        F.Editar(Cliente.Id, clienteJson);
                        if (F.status)
                        {
                            MessageBox.Show(F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                catch (ValidationException Excep)
                {
                    MessageBox.Show(Excep.Message, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Se o identificador do cliente estiver em branco, o sistema aponta a seguinte mensagem:
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Código do Cliente não existe!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Caso contrário, conecta ao Fichário
            else
            {
                Fichario F = new Fichario("C:\\Users\\fedam\\OneDrive\\Documentos\\HoW4\\Fichario");
                if (F.status)
                {
                    //Escrever os dados do cliente no formulário
                    string clienteJson = F.Buscar(txt_ID.Text);
                    Clientes.Unit Cliente = new Clientes.Unit();
                    Cliente = Clientes.DesSerializedClassUnit(clienteJson);
                    EscreveFormulario(Cliente);

                    Form_Confirmar Confirma = new Form_Confirmar("Você realmente deseja excluir o(a) cliente selecionado(a)?");
                    Confirma.ShowDialog();
                    if (Confirma.DialogResult == DialogResult.Yes)
                    {
                        F.Apagar(txt_ID.Text);
                        if (F.status)
                        {
                            MessageBox.Show(F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        Clientes.Unit LeituraFormulario()
        {
            Clientes.Unit Cliente = new Clientes.Unit();
            Cliente.Id = txt_ID.Text;
            Cliente.Nome = txt_Nome.Text;
            Cliente.Cpf = txt_Cpf.Text;
            Cliente.Email = txt_Email.Text;
            Cliente.Conta = txt_Conta.Text;
            return Cliente;
        }


        void EscreveFormulario(Clientes.Unit Cliente)
        {
            txt_ID.Text = Cliente.Id;
            txt_Nome.Text = Cliente.Nome;
            txt_Cpf.Text = Cliente.Cpf;
            txt_Email.Text = Cliente.Email;
            txt_Conta.Text = Cliente.Conta;
        }


        private void LimparCampos()
        {
            txt_ID.Clear();
            txt_Nome.Clear();
            txt_Cpf.Clear();
            txt_Email.Clear();
            txt_Conta.Clear();
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Fechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
           /* Fichario F = new Fichario("C:\\Users\\fedam\\OneDrive\\Documentos\\HoW4\\Fichario");
            if (F.status)
            {
                List<string> List = new List<string>();
                List = F.Listar();
                Form_ListagemClientes ListagemClientes = new Form_ListagemClientes();
                ListagemClientes.ShowDialog();

            }
            else
            {
                MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/



            

          if (txt_ID.Text == "")
            {
                MessageBox.Show("Código do Cliente não existe!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario F = new Fichario("C:\\Users\\fedam\\OneDrive\\Documentos\\HoW4\\Fichario");
                if (F.status)
                {
                    string clienteJson = F.Buscar(txt_ID.Text);
                    Clientes.Unit Cliente = new Clientes.Unit();
                    Cliente = Clientes.DesSerializedClassUnit(clienteJson);
                    EscreveFormulario(Cliente);

                }
                else
                {
                    MessageBox.Show("ERRO: " + F.mensagem, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
