using System;
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
    public partial class Form_PesquisarClientes : Form
    {
        List<List<string>> _ListaPesquisa = new List<List<string>>();

        public string IdSelect { get; set; }

        public Form_PesquisarClientes(List<List<string>> ListaPesquisa)
        {
            _ListaPesquisa = ListaPesquisa;
            InitializeComponent();
            PreencheLista();
        }

        private void PreencheLista()
        {
            lst_Pesquisa.Items.Clear();
            for (int i = 0; i <= _ListaPesquisa.Count - 1; i++)
            {
                lst_Pesquisa.Items.Add(_ListaPesquisa[i][1]);
            }
        }

    private void btn_Fechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            IdSelect = _ListaPesquisa[lst_Pesquisa.SelectedIndex][0];
            this.Close();

        }
    }
}
