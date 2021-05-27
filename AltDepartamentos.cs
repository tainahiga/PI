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
    public partial class AltDepartamentos : Form
    {
        private Departamento dep;                                       //DECLARAÇÃO DE ATRIBUTOS PARA MANIPULAÇÃO NESTA CLASSE
        private int cod;
        public AltDepartamentos(Departamento d, int cod)                //CONSTRUTOR QUE RECEBE OBJETO COMO PARAMETRO PARA REALIZAR O UPDATE
        {
            InitializeComponent();
            this.dep = d;                                               //ATRIBUI O OBJETO DE PARAMETRO AO ATRIBUTO PRIVATE DESSA CLASSE
            this.cod = cod;                                             //ATRIBUI O OBJETO DE PARAMETRO AO ATRIBUTO PRIVATE DESSA CLASSE
        }
        private void AltDepartamentos_Load(object sender, EventArgs e)
        {
            //COLOCA NOS CAMPOS AS INFORMAÇÕES DO REGISTRO QUE SERÁ FEITO UPDATE
            descricao.Text = dep.getDescricao();
            nome.Text = dep.getNome();
        }         
            private void btCadastrar_Click(object sender, EventArgs e)
            {
                try
                {
                    //CONDIÇÃO QUE VERIFICA SE OS CAMPOS ESTÃO PREENCHIDOS
                    if (descricao.Text != String.Empty &&
                        nome.Text != String.Empty)
                        {
                            //PASSANDO AO OBJETO OS NOVOS VALORES INSERIDOS NOS CAMPOS
                            dep.setNome(nome.Text);
                            dep.setDescricao(descricao.Text);
                        }
                        dep.alterar(cod);                                             //MÉTODO QUE REALIZA O UPDATE
                        MessageBox.Show("Departamento Alterado");
                        ConsultaDepartamento form2 = new ConsultaDepartamento();      //INSTANCIA O FORMS DE CONSULTA
                        this.Hide();
                        form2.ShowDialog();                                           //MOSTRA O FORMS DE CONSULTA ATUALIZADO
                        this.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar departamento! Erro: " + ex.Message);
                }
            }
        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            Main form1 = new Main();                //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();                     //MOSTRA O MAIN
            this.Close();
        }
    }
}