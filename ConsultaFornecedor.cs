using MySql.Data.MySqlClient;
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
    public partial class ConsultaFornecedor : Form
    {
        public ConsultaFornecedor()
        {
            InitializeComponent();
        }
        private void ConsultaFornecedor_Load(object sender, EventArgs e)        //AO CARREGAR O FORMS FAZ UM SELECT ESPECIFICANDO O NOME DAS COLUNAS DO DATAGRIDVIEW
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT CNPJ, RAZAO_SOCIAL AS 'Razão Social' FROM FORNECEDORES");
                dataGridView1.DataSource = dt;      //PASSA O SELECT COMO FONTE DO DATAGRIDVIEW
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum registro no banco de dados!");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();        //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();             //MOSTRA O MAIN
            this.Close();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;            //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE FORNECEDOR
            string cnpj = dataGridView1[0, indice].Value.ToString();           
            string nome = dataGridView1[1, indice].Value.ToString();

            Fornecedores d = new Fornecedores(cnpj, nome);
            //PASSA O OBJETO SELECIONADO COMO PARAMETRO PARA O FORMS QUE REALIZA O UPDATE
            AltFornecedores form1 = new AltFornecedores(d);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;            //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE FORNECEDOR
            string cnpj = dataGridView1[0, indice].Value.ToString();
            string nome = dataGridView1[1, indice].Value.ToString();

            Fornecedores d = new Fornecedores(cnpj, nome);
            try
            {
                d.excluirFornecedor(cnpj);              //MÉTODO PARA FAZER O DELETE
                MessageBox.Show("Fornecedor Excluído");
                ConsultaFornecedor_Load(sender, e);     //RECARREGA O FORMS ATUAL PARA ATUALIZAR O DATAGRIDVIEW APÓS DELETE
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir o departamento! \nConsulte informações");
            }
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;                //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE FORNECEDOR
            string cnpj = dataGridView1[0, indice].Value.ToString();
            string nome = dataGridView1[1, indice].Value.ToString();
            //CRIANDO OS ATRIBUTOS DA CLASSE QUICKSTOCK
            string desc = "Fornecedor: " + nome;
            double resultado = calcularResultado(cnpj);

            if(resultado != 0)              //CONDIÇÃO PARA QUANDO NÃO TEM VALOR EM ESTOQUE NÃO CRIAR RELATÓRIO
            { 
                Relatorio qs = new Relatorio(desc, resultado);
                if (qs.cadastrar())         //MÉTODO QUE REGISTRA O RELATORIO NA QUICKSTOCK
                {
                    MessageBox.Show("Relatório criado com sucesso! \nConsulte o sistema QuickStock");
                }
            }
            else
            {
                MessageBox.Show("Erro ao gerar relatório!");
            }
        }
        //MÉTODO QUE CALCULA O VALOR EM ESTOQUE
        private double calcularResultado(string cnpj)
        {
            Database db = new Database();
            try
            {
                string sql = "SELECT SUM(QUANTIDADE* PRECO)FROM PRODUTOS WHERE FORNECEDOR = '"+cnpj+"'"; //SELECT QUE REALIZA A MULTIPLICAÇÃO DE PREÇO POR QUANTIDADE E DPS SOMA
                db.Conectar();
                MySqlDataReader dr = db.RetDataReader(sql);
                dr.Read();
                return dr.GetDouble("SUM(QUANTIDADE* PRECO)");      //RETORNA O VALOR LIDO PELO DATAREADER COMO DOUBLE
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao calcular o resultado! Erro: " + e.Message);
                return 0;
            }
            finally
            {
                db = null;
            }
        }
    }
}