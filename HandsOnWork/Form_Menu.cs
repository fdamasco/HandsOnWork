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

namespace HandsOnWork
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            //Nova instância da classe Form_Clientes
            Form_Clientes clientes = new Form_Clientes();
            clientes.ShowDialog();
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {
            //Nova instância da classe Form_Funcionarios
            Form_Funcionarios funcionarios = new Form_Funcionarios();
            funcionarios.ShowDialog();
        }
    }
}
