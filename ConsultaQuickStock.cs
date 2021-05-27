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
    public partial class ConsultaQuickStock : Form
    {
        public ConsultaQuickStock()
        {
            InitializeComponent();
        }

        private void ConsultaQuickStock_Load(object sender, EventArgs e)            //AO CARREGAR O FORMS REALIZA UM SELECT ESPECIFICANDO AS COLUNAS DA DATAGRIDVIEW
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dt = db.RetDataTable("SELECT COD_RELATORIO AS 'Relatório', DESCRICAO AS 'Foco da pesquisa', DATA_REG AS 'Data da Consulta', RESULTADO AS 'Valor em Estoque' FROM RELATORIOS");
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;                //RETORNA A SELEÇÃO DO DATAGRIDVIEW
            //BASEADO NO NÚMERO DAS COLUNAS VAI FAZENDO AS CONVERSOES PARA CRIAR OS ATRIBUTOS DA CLASSE RELATORIO
            string temp = dataGridView1[0, indice].Value.ToString();
            int codRelatorio = int.Parse(temp);
            string descricao = dataGridView1[1, indice].Value.ToString();
            string temp3 = dataGridView1[3, indice].Value.ToString();
            double resultado = Double.Parse(temp3);

            Relatorio r = new Relatorio(codRelatorio, descricao, resultado);
            try
            {
                r.excluir(codRelatorio);                  //MÉTODO PARA FAZER O DELETE
                MessageBox.Show("Relatório Excluído");
                ConsultaQuickStock_Load(sender, e);       //RECARREGA O FORMS ATUAL PARA ATUALIZAR O DATAGRIDVIEW APÓS DELETE
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir o produto! \nConsulte informações");
            }
        }
    }
}