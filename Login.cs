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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            if(codFunc.Text == "0001" && senha.Text == "senha")         //PARA SIMULAR UM LOGIN COLOCAMOS A CONDIÇÃO QUE VERIFICA SE USER '0001' E PASSWORD 'SENHA'
            {
                MessageBox.Show("  BEM VINDO !  ");                     //SE A CONDIÇÃO FOR ATENDIDA MOSTRA NA TELA
                Main novo = new Main();                                 //INSTANCIA O FORMS MAIN
                this.Hide();
                novo.ShowDialog();
                this.Close();
            }
        }
    }
}