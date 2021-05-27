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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            CadGeral form1 = new CadGeral(); //INSTANCIA O FORMS CADGERAL
            this.Hide();                    //ESCONDE ESTE
            form1.ShowDialog();             //MOSTRA O NOVO FORMS
            this.Close();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            ConsultaGeral form1 = new ConsultaGeral();      //INSTANCIA O FORMS CONSULTAGERAL
            this.Hide();                                    //ESCONDE ESTE
            form1.ShowDialog();                             //MOSTRA O NOVO FORMS
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
