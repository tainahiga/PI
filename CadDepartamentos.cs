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
    public partial class CadDepartamentos : Form
    {
        public CadDepartamentos()
        {
            InitializeComponent();
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CONDIÇÃO PARA VERIFICAR O PREENCHIMENTO DOS CAMPOS
                if (descricao.Text != String.Empty &&
                        nome.Text != String.Empty)
                {
                   Departamento d = new Departamento(nome.Text, descricao.Text);
                    if (d.cadastrar())              //MÉTODO QUE REALIZA O INSERT NO DB
                    {
                        MessageBox.Show("Departamento Cadastrado");
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
            nome.Clear();
            descricao.Clear();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();            //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();                 //MOSTRA O MAIN
            this.Close();
        }
    }
}