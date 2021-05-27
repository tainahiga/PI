using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    /*  TABLE DO DB
     *  COD_DEPARTAMENTO INT AUTO_INCREMENT NOT NULL,
        NOME VARCHAR(100) NOT NULL,
        DESCRICAO VARCHAR(100) NOT NULL,
        CONSTRAINT PK_DEPARTAMENTOS PRIMARY KEY (COD_DEPARTAMENTO))
    */
    public class Departamento : QuickStock
    {
        #region "ATRIBUTOS"
        private int codDepartamento;
        private string nome;
        private string descricao;

        //CONSTRUTORES DA CLASSE
        public Departamento(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }
        public Departamento(int codDepartamento)
        {
            this.codDepartamento = codDepartamento;
        }
        public Departamento(int codDepartamento, string nome, string descricao)
        {
            this.codDepartamento = codDepartamento;
            this.nome = nome;
            this.descricao = descricao;
        }
        #endregion

        #region "METODOS"
        //MÉTODO ESPECÍFICO PARA REALIZAR O INSERT NO DB
        public override bool cadastrar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("INSERT INTO DEPARTAMENTOS(NOME, DESCRICAO) VALUES('"+this.nome+"', '"+this.descricao+"')", true);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar o departamento! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO ESPECÍFICO PARA REALIZAR O DELETE NO DB
        public override void excluir(int codDepartamento)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("DELETE FROM DEPARTAMENTOS WHERE COD_DEPARTAMENTO= '"+codDepartamento+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o departamento! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO ESPECÍFICO PARA REALIZAR O UPDATE NO DB
        public override void alterar(int codDepartamento)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("UPDATE DEPARTAMENTOS SET NOME = '"+this.nome+"', DESCRICAO = '"+this.descricao+"' WHERE COD_DEPARTAMENTO = '"+codDepartamento+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar o departamento! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODOS DE ENCAPSULAMENTO
        public int getCodDepartamento()
        {
            return this.codDepartamento;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setNome(String valor)
        {
            this.nome = valor;
        }
        public void setDescricao(String valor)
        {
            this.descricao = valor;
        }
        #endregion
    }
}