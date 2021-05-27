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
    public partial class ConsultaProduto : Form
    {
        public ConsultaProduto()
        {
            InitializeComponent();
        }

        private void ConsultaProduto_Load(object sender, EventArgs e)   //AO CARREGAR O FORMS FAZ UM SELECT ESPECIFICANDO O NOME DAS COLUNAS DO DATAGRIDVIEW
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT COD_PRODUTO AS Código, QUANTIDADE AS Quantidade, " +
                    "PRECO AS Preço, DESCRICAO AS Descrição, FORNECEDOR AS 'CNPJ do Fornecedor', DEPARTAMENTO AS 'Código do Departamento' " +
                    "FROM PRODUTOS");
                dataGridView1.DataSource = dt; //PASSA O SELECT COMO FONTE DO DATAGRIDVIEW
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
            int indice = dataGridView1.CurrentRow.Index;                //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE PRODUTO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codProduto = int.Parse(temp);
            string temp2 = dataGridView1[1, indice].Value.ToString();
            int quantidade = int.Parse(temp2);
            string temp3 = dataGridView1[2, indice].Value.ToString();
            double preco = Double.Parse(temp3);
            string descricao = dataGridView1[3, indice].Value.ToString();
            string cnpj = dataGridView1[4, indice].Value.ToString();
            string temp4 = dataGridView1[5, indice].Value.ToString();
            int codDepartamento = int.Parse(temp4);

            Produto p = new Produto(codProduto, quantidade, preco, descricao, new Departamento(codDepartamento), new Fornecedores(cnpj));

            //PASSA O OBJETO SELECIONADO COMO PARAMETRO PARA O FORMS QUE REALIZA O UPDATE
            AltProduto form1 = new AltProduto(p);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;                //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE PRODUTO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codProduto = int.Parse(temp);
            string temp2 = dataGridView1[1, indice].Value.ToString();
            int quantidade = int.Parse(temp2);
            string temp3 = dataGridView1[2, indice].Value.ToString();
            double preco = Double.Parse(temp3);
            string descricao = dataGridView1[3, indice].Value.ToString();
            string cnpj = dataGridView1[4, indice].Value.ToString();
            string temp4 = dataGridView1[5, indice].Value.ToString();
            int codDepartamento = int.Parse(temp4);

            Produto p = new Produto(codProduto, quantidade, preco, descricao, new Departamento(codDepartamento), new Fornecedores(cnpj));
            try
            {
                p.excluir(codProduto);                 //MÉTODO PARA FAZER O DELETE
                MessageBox.Show("Produto Excluído");
                ConsultaProduto_Load(sender, e);       //RECARREGA O FORMS ATUAL PARA ATUALIZAR O DATAGRIDVIEW APÓS DELETE
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir o produto! \nConsulte informações");
            }
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;                //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE PRODUTO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codProduto = int.Parse(temp);
            string temp2 = dataGridView1[1, indice].Value.ToString();
            int quantidade = int.Parse(temp2);
            string temp3 = dataGridView1[2, indice].Value.ToString();
            double preco = Double.Parse(temp3);
            string descricao = dataGridView1[3, indice].Value.ToString();
            string cnpj = dataGridView1[4, indice].Value.ToString();
            string temp4 = dataGridView1[5, indice].Value.ToString();
            int codDepartamento = int.Parse(temp4);

            Produto p = new Produto(codProduto, quantidade, preco, descricao, new Departamento(codDepartamento), new Fornecedores(cnpj));
            //CRIANDO OS ATRIBUTOS DA CLASSE QUICKSTOCK
            string desc = "Produto: " + descricao;
            double resultado = quantidade * preco;
            if (resultado != 0) //CONDIÇÃO PARA QUANDO NÃO TEM VALOR EM ESTOQUE NÃO CRIAR RELATÓRIO
            {
                Relatorio r = new Relatorio(desc, resultado);
                if (r.cadastrar()) //MÉTODO QUE REGISTRA O RELATORIO NA QUICKSTOCK
                {
                    MessageBox.Show("Relatório criado com sucesso! \nConsulte o sistema QuickStock");
                }
            }
            else
            {
                MessageBox.Show("Erro ao gerar relatório!");
            }
        }
    }
}