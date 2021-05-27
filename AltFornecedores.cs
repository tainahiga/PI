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
    public partial class AltFornecedores : Form
    {
        private Fornecedores forn;                            //DECLARAÇÃO DE ATRIBUTO PARA MANIPULAÇÃO NESTA CLASSE
        public AltFornecedores(Fornecedores f)                //CONSTRUTOR QUE RECEBE OBJETO COMO PARAMETRO PARA REALIZAR O UPDATE
        {
            InitializeComponent();
            this.forn = f;                                    //ATRIBUI O OBJETO DE PARAMETRO AO ATRIBUTO PRIVATE DESSA CLASSE
        }
        private void AltFornecedores_Load(object sender, EventArgs e)
        {
            //COLOCA NOS CAMPOS AS INFORMAÇÕES DO REGISTRO QUE SERÁ FEITO UPDATE
            cnpj.Text = forn.getCnpj();
            razaoSocial.Text = forn.getRazaoSocial(); 
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CONDIÇÃO QUE VERIFICA SE OS CAMPOS ESTÃO PREENCHIDOS
                if (cnpj.Text != String.Empty &&
                    razaoSocial.Text != String.Empty)
                {
                    forn.setCnpj(cnpj.Text);
                    forn.setRazaoSocial(razaoSocial.Text);
                }
                forn.alterarFornecedor(cnpj.Text);                          //MÉTODO QUE REALIZA O UPDATE
                MessageBox.Show("Fornecedor Alterado");
                ConsultaFornecedor form2 = new ConsultaFornecedor();        //INSTANCIA O FORMS DE CONSULTA
                this.Hide();
                form2.ShowDialog();                                         //MOSTRA O FORMS DE CONSULTA ATUALIZADO
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor! Erro: " + ex.Message);
            }
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