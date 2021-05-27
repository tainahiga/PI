using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    class Relatorio : QuickStock
    {
        /*  TABLE DO BD
            COD_RELATORIO INT AUTO_INCREMENT NOT NULL,
            DESCRICAO VARCHAR(100) NOT NULL,
            DATA_REG DATE,
            RESULTADO DOUBLE NOT NULL,
         */
        #region "ATRIBUTOS"
        private int codRelatorio;
        private string descricao;
        private double resultado;

        //CONSTRUTORES DA CLASSE
        public Relatorio(int codRelatorio, string descricao, double resultado)
        {
            this.codRelatorio = codRelatorio;
            this.descricao = descricao;
            this.resultado = resultado;
        }
        public Relatorio(int codRelatorio)
        {
            this.codRelatorio = codRelatorio;
        }
        public Relatorio(string descricao, double resultado)
        {
            this.descricao = descricao;
            this.resultado = resultado;
        }
        #endregion

        #region "METODOS"
        //MÉTODOS DE ENCAPSULAMENTO
        public int getCodRelatorio()
        {
            return this.codRelatorio;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public double getResultado()
        {
            return this.resultado;
        }
        public void setDescricao(string valor)
        {
            this.descricao = valor;
        }
        public void setResultado(double valor)
        {
            this.resultado = valor;
        }
        //MÉTODO ESPECÍFICO PARA FAZER O INSERT DOS REGISTROS NO BD
        public override bool cadastrar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("INSERT INTO RELATORIOS(DESCRICAO, DATA_REG, RESULTADO) VALUES('"+this.descricao+"', curdate(), '"+this.resultado+"')", true);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar relatório! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }

        public override void excluir(int codRelatorio)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("DELETE FROM RELATORIOS WHERE COD_RELATORIO= '"+codRelatorio+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o relatorio! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO HERDADO PORÉM NÃO UTILIZADO
        public override void alterar(int valor)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}