using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    public class Fornecedores : QuickStock
    {
        /*  TABLE DO DB
         *  CNPJ VARCHAR(14) NOT NULL,
            RAZAO_SOCIAL VARCHAR(100) NOT NULL,
            CONSTRAINT PK_FORNECEDORES PRIMARY KEY (CNPJ)); 
        */

        #region "ATRIBUTOS"
        private string cnpj;
        private string razaoSocial;

        //CONSTRUTORES DA CLASSE
        public Fornecedores(string cnpj, string razaoSocial)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
        }
        public Fornecedores(string cnpj)
        {
            this.cnpj = cnpj;
        }
        #endregion

        #region "MÉTODOS"
        //MÉTODO ESPECÍFICO PARA REALIZAR O INSERT NO DB
        public override bool cadastrar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("INSERT INTO FORNECEDORES VALUES('"+this.cnpj+"','"+this.razaoSocial+"')" ,true);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar o fornecedor! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO ESPECÍFICO PARA REALIZAR O DELETE NO DB
        public  void excluirFornecedor(string cnpj)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("DELETE FROM FORNECEDORES WHERE CNPJ= '"+cnpj+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o fornecedor! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO ESPECÍFICO PARA REALIZAR O UPDATE NO DB
        public void alterarFornecedor(string cnpj)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("UPDATE FORNECEDORES SET RAZAO_SOCIAL = '"+this.razaoSocial+"' WHERE CNPJ= '"+cnpj+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar o fornecedor! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODOS DE ENCAPSULAMENTO
        public string getRazaoSocial()
        {
            return this.razaoSocial;
        }
        public string getCnpj()
        {
            return this.cnpj;
        }
        public void setRazaoSocial(string valor)
        {
            this.razaoSocial = valor;
        }
        public void setCnpj(string valor)
        {
            this.cnpj = valor;
        }
        //MÉTODOS HERDADOS PORÉM NÃO UTILIZADOS
        public override void excluir(int valor)
        {
            throw new NotImplementedException();
        }

        public override void alterar(int valor)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}