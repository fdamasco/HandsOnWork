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


namespace HandsOnWork
{
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                Clientes.Unit Cliente = new Clientes.Unit();
                Cliente = LeituraFormulario();
                Cliente.ValidaClasse();
                MessageBox.Show("Cliente cadastrado com sucesso!", "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (ValidationException Excep)
            {
                MessageBox.Show(Excep.Message, "UniBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }

        Clientes.Unit LeituraFormulario()
        {
            Clientes.Unit Cliente = new Clientes.Unit();
            Cliente.Nome = txt_Nome.Text;
            Cliente.Cpf = txt_Cpf.Text;
            Cliente.Email = txt_Email.Text;
            Cliente.Conta = txt_Conta.Text;
           

  
            return Cliente; 
        }

       
    }
}
