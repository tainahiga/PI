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
    public partial class CadFornecedores : Form
    {
        public CadFornecedores()
        {
            InitializeComponent();
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CONDIÇÃO PARA VERIFICAR O PREENCHIMENTO DOS CAMPOS
                if (razaoSocial.Text != String.Empty &&
                        cnpj.Text != String.Empty)
                {
                    Fornecedores p = new Fornecedores(cnpj.Text, razaoSocial.Text);
                    if (p.cadastrar())              //MÉTODO QUE REALIZA O INSERT NO DB
                    {
                        MessageBox.Show("Fornecedor Cadastrado");
                        LimparCampos();             //MÉTODO QUE LIMPA OS CAMPOS PARA NOVO REGISTRO                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor! Erro: " + ex.Message);
            }
        }
        //MÉTODO QUE LIMPA OS CAMPOS PARA NOVO REGISTRO                    
        private void LimparCampos()
        {
            razaoSocial.Clear();
            cnpj.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();                //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();                     //MOSTRA O MAIN
            this.Close();
        }
    }
}