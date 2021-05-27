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
    public partial class ConsultaDepartamento : Form
    {
        public ConsultaDepartamento()
        {
            InitializeComponent();
        }

        private void ConsultaDepartamento_Load(object sender, EventArgs e)              //AO CARREGAR O FORMS FAZ UM SELECT ESPECIFICANDO O NOME DAS COLUNAS DO DATAGRIDVIEW
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT COD_DEPARTAMENTO AS Código, NOME AS Nome, DESCRICAO AS Descrição FROM DEPARTAMENTOS");
                dataGridView1.DataSource = dt;              //PASSA O SELECT COMO FONTE DO DATAGRIDVIEW
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum registro no banco de dados!");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();                //INSTANCIA O FORMS MAIN
            this.Hide();
            form1.ShowDialog();                     //MOSTRA O MAIN
            this.Close();
        }
        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;            //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE DEPARTAMENTO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codDepartamento = int.Parse(temp);
            string nome = dataGridView1[1, indice].Value.ToString();
            string descricao = dataGridView1[2, indice].Value.ToString();

            Departamento d = new Departamento(nome, descricao);
            try
            {
                d.excluir(codDepartamento);                         //MÉTODO PARA FAZER O DELETE
                MessageBox.Show("Departamento Excluído");
                ConsultaDepartamento_Load(sender,e);                //RECARREGA O FORMS ATUAL PARA ATUALIZAR O DATAGRIDVIEW APÓS DELETE
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir o departamento! \nConsulte informações");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;            //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE DEPARTAMENTO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codDepartamento = int.Parse(temp);
            string nome = dataGridView1[1, indice].Value.ToString();
            string descricao = dataGridView1[2, indice].Value.ToString();

            Departamento d = new Departamento(nome, descricao);
            //PASSA O OBJETO SELECIONADO COMO PARAMETRO PARA O FORMS QUE REALIZA O UPDATE
            AltDepartamentos form1 = new AltDepartamentos(d, codDepartamento);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;            //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE DEPARTAMENTO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codDepartamento = int.Parse(temp);
            string nome = dataGridView1[1, indice].Value.ToString();
            //CRIANDO OS ATRIBUTOS DA CLASSE QUICKSTOCK
            string desc = "Departamento: " + nome;
            double resultado = calcularResultado(codDepartamento);
            if (resultado != 0)                 //CONDIÇÃO PARA QUANDO NÃO TEM VALOR EM ESTOQUE NÃO CRIAR RELATÓRIO
            {
                Relatorio r = new Relatorio(desc, resultado);
                if (r.cadastrar())              //MÉTODO QUE REGISTRA O RELATORIO NA QUICKSTOCK
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
        private double calcularResultado(int codDepartamento)
        {
            Database db = new Database();
            try
            {
                string sql = "SELECT SUM(QUANTIDADE* PRECO)FROM PRODUTOS WHERE DEPARTAMENTO = '" + codDepartamento + "'"; //SELECT QUE REALIZA A MULTIPLICAÇÃO DE PREÇO POR QUANTIDADE E DPS SOMA
                db.Conectar();
                MySqlDataReader dr = db.RetDataReader(sql);
                dr.Read();
                return dr.GetDouble("SUM(QUANTIDADE* PRECO)");          //RETORNA O VALOR LIDO PELO DATAREADER COMO DOUBLE
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