using System;
using HandsOnWorkBiblioteca;
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
using HandsOnWorkBiblioteca.Databases;
using System.Net;
using System.IO;

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
                Cliente.Incluir();
                MessageBox.Show("Cliente cadastrado com sucesso!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Cliente.Editar();
                    MessageBox.Show("Dados editados com sucesso!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                try
                {
                    Clientes.Unit Cliente = new Clientes.Unit();
                    Cliente = Cliente.Listar(txt_ID.Text);
                    if (Cliente == null)
                    {
                        MessageBox.Show("Cliente não encontrado!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(Cliente);
                        Form_Confirmar Confirma = new Form_Confirmar("Você realmente deseja excluir o(a) cliente selecionado(a)?");
                        Confirma.ShowDialog();
                        if (Confirma.DialogResult == DialogResult.Yes)
                        {
                           
                            Cliente.Excluir();
                            MessageBox.Show("Cliente excluído com sucesso!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Código do Cliente não existe!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    Clientes.Unit Cliente = new Clientes.Unit();
                    Cliente = Cliente.Listar(txt_ID.Text);
                    if (Cliente == null)
                    {
                        MessageBox.Show("Cliente não encontrado!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(Cliente);
                    }
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                Clientes.Unit Cliente = new Clientes.Unit();
                var ListPesquisar = Cliente.Pesquisar();
                Form_PesquisarClientes Form = new Form_PesquisarClientes(ListPesquisar);
                Form.ShowDialog();
                if (Form.DialogResult == DialogResult.OK)
                {
                    var idSelect = Form.IdSelect;
                    Cliente = Cliente.Listar(idSelect);
                    if (Cliente == null)
                    {
                        MessageBox.Show("Não existem clientes cadastrados!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(Cliente);
                    }
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}