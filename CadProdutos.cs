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
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CONDIÇÃO PARA VERIFICAR O PREENCHIMENTO DOS CAMPOS
                if (descricao.Text != String.Empty &&
                        preco.Text != String.Empty &&
                        quantidade.Text != String.Empty &&
                        departamento.Text != String.Empty &&
                        fornecedor.Text != String.Empty)
                {
                    //REALIZA AS CONVERSÕES NECESSÁRIAS DO OBJETO RETORNADO DAS COMBOBOXES
                    DataRowView drv = (DataRowView)fornecedor.SelectedValue;
                    string forn = drv.Row["CNPJ"].ToString();
                    DataRowView dv = (DataRowView)departamento.SelectedValue;
                    string cod = dv.Row["COD_DEPARTAMENTO"].ToString();
                    
                    Produto p = new Produto(int.Parse(quantidade.Text), double.Parse(preco.Text), descricao.Text, new Fornecedores(forn), new Departamento(int.Parse(cod)));

                    if (p.cadastrar())          //MÉTODO QUE REALIZA O INSERT NO DB
                    {
                        MessageBox.Show("Produto Cadastrado");
                        LimparCampos();             //MÉTODO QUE LIMPA OS CAMPOS PARA NOVO REGISTRO                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto! Erro: " + ex.Message);
            }
        }
        //MÉTODO QUE LIMPA OS CAMPOS PARA NOVO REGISTRO
        private void LimparCampos()
        {
            descricao.Clear();
            preco.Clear();
            quantidade.Clear();
            departamento.Text = String.Empty;
            fornecedor.Text = String.Empty;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();            //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();                 //MOSTRA O MAIN
            this.Close();
        }

        private void CadProdutos_Load(object sender, EventArgs e)   //AO CARREGAR O FORMS CRIA AS COMBOBOXES COM DADOS DO DB
        {
            carregarComboFornecedor();          //MÉTODOS QUE CARREGAM AS COMBOBOXES
            carregarComboDepartamento();
        }

        public void carregarComboFornecedor()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT CNPJ FROM FORNECEDORES");
                fornecedor.DataSource = dt;             //PASSA O SELECT COMO FONTE DA COMBOBOX
                fornecedor.DisplayMember = "CNPJ";      //PASSA O NOME DA COLUNA SELECIONADA
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
                departamento.DisplayMember = "COD_DEPARTAMENTO";        //PASSA O NOME DA COLUNA SELECIONADA
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar departamentos! Erro: " + ex.Message);
            }
        }
    }
}