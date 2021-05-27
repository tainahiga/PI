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
    public partial class AltProduto : Form
    {
        private Produto prod;                       //DECLARAÇÃO DE ATRIBUTO PARA MANIPULAÇÃO NESTA CLASSE
        public AltProduto(Produto p)                //CONSTRUTOR QUE RECEBE OBJETO COMO PARAMETRO PARA REALIZAR O UPDATE
        {
            InitializeComponent();
            this.prod = p;                          //ATRIBUI O OBJETO DE PARAMETRO AO ATRIBUTO PRIVATE DESSA CLASSE
        }
        private void AltProduto_Load(object sender, EventArgs e)
        {
            //MÉTODOS QUE CARREGAM AS COMBOBOXES COM AS INFORMAÇÕES DO DB
            carregarComboFornecedor();
            carregarComboDepartamento();
            //COLOCA NOS CAMPOS AS INFORMAÇÕES DO REGISTRO QUE SERÁ FEITO UPDATE
            quantidade.Text = prod.getQuantidade().ToString();
            preco.Text = prod.getPreco().ToString();
            descricao.Text = prod.getDescricao();
            //COLOCA NAS COMBOBOXES OS VALORES QUE CONSTAM NO DB
            fornecedor.ValueMember = "CNPJ";
            fornecedor.SelectedValue = prod.getFornecedor().getCnpj();
            departamento.ValueMember = "COD_DEPARTAMENTO";
            departamento.SelectedValue = prod.getDepartamento().getCodDepartamento();
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CONDIÇÃO QUE VERIFICA SE OS CAMPOS ESTÃO PREENCHIDOS
                if (descricao.Text != String.Empty &&
                        preco.Text != String.Empty &&
                        quantidade.Text != String.Empty &&
                        departamento.Text != String.Empty &&
                        fornecedor.Text != String.Empty)
                {
                    //PASSANDO AO OBJETO OS NOVOS VALORES INSERIDOS NOS CAMPOS
                    prod.setQuantidade(int.Parse(quantidade.Text));
                    prod.setPreco(Double.Parse(preco.Text));
                    prod.setDescricao(descricao.Text);
                    prod.setFornecedor(new Fornecedores(fornecedor.Text));
                    prod.setDepartamento(new Departamento(int.Parse(departamento.Text)));
                }
                prod.alterar(prod.getCodProduto());                 //MÉTODO QUE REALIZA O UPDATE
                MessageBox.Show("Produto Alterado");
                ConsultaProduto form2 = new ConsultaProduto();      //INSTANCIA O FORMS DE CONSULTA
                this.Hide();
                form2.ShowDialog();                                 //MOSTRA O FORMS DE CONSULTA ATUALIZADO
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar produto! Erro: " + ex.Message);
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();                //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();                     //MOSTRA O MAIN
            this.Close();
        }
        //MÉTODOS QUE CARREGAM AS COMBOBOXES COM AS INFORMAÇÕES DO DB
        public void carregarComboFornecedor()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT CNPJ FROM FORNECEDORES");
                fornecedor.DataSource = dt;             //PASSA O SELECT COMO FONTE DA COMBOBOX
                fornecedor.DisplayMember = "CNPJ";      //INFORMA O NOME DA COLUNA
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores! Erro: " + ex.Message);
            }
        }
        public void carregarComboDepartamento()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT COD_DEPARTAMENTO FROM DEPARTAMENTOS");
                departamento.DataSource = dt;                           //PASSA O SELECT COMO FONTE DA COMBOBOX
                departamento.DisplayMember = "COD_DEPARTAMENTO";        //INFORMA O NOME DA COLUNA
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar departamentos! Erro: " + ex.Message);
            }
        }
    }
}