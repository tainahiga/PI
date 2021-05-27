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
    public partial class ConsultaGeral : Form
    {
        public ConsultaGeral()
        {
            InitializeComponent();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            ConsultaProduto form1 = new ConsultaProduto();      //INSTANCIA O FORMS CONSULTAPRODUTO
            this.Hide();
            form1.ShowDialog();                                 //MOSTRA O CONSULTAPRODUTO
            this.Close();
        }
        private void btFornecedores_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor form1 = new ConsultaFornecedor();    //INSTANCIA O FORMS CONSULTAFORNECEDOR
            this.Hide();
            form1.ShowDialog();                                     //MOSTRA O CONSULTAFORNECEDOR
            this.Close();
        }
        private void btDepartamentos_Click(object sender, EventArgs e)
        {
            ConsultaDepartamento form1 = new ConsultaDepartamento();    //INSTANCIA O FORMS CONSULTADEPARTAMENTO
            this.Hide();
            form1.ShowDialog();                                         //MOSTRA O CONSULTADEPARTAMENTO
            this.Close();
        }
        private void btRelatorios_Click(object sender, EventArgs e)
        {
            ConsultaQuickStock form1 = new ConsultaQuickStock();        //INSTANCIA O FORMS CONSULTAQUICKSTOCK
            this.Hide();
            form1.ShowDialog();                                         //MOSTRA O CONSULTAQUICKSTOCK
            this.Close();
        }
    }
}