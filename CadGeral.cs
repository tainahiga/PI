using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class CadGeral : Form
    {
        public CadGeral()
        {
            InitializeComponent();
        }
        private void btProdutos_Click(object sender, EventArgs e)
        {
            CadProdutos form1 = new CadProdutos();      //INSTANCIA O FORMS CADPRODUTOS
            this.Hide();
            form1.ShowDialog();                         //MOSTRA O CADPRODUTOS
            this.Close();
        }
        private void btFornecedores_Click(object sender, EventArgs e)
        {
            CadFornecedores form1 = new CadFornecedores();      //INSTANCIA O FORMS CADFORNECEDORES
            this.Hide();
            form1.ShowDialog();                         //MOSTRA O CADFORNECEDORES
            this.Close();
        }
        private void btDepartamentos_Click(object sender, EventArgs e)
        {
            CadDepartamentos form1 = new CadDepartamentos();      //INSTANCIA O FORMS CADDEPARTAMENTOS
            this.Hide();
            form1.ShowDialog();                                    //MOSTRA O CADDEPARTAMENTOS
            this.Close();
        }
    }
}