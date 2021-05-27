using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public class Produto : QuickStock
    {
        /*  TABLE DO DB
         *  COD_PRODUTO INT AUTO_INCREMENT NOT NULL,
            QUANTIDADE DOUBLE NOT NULL,
            PRECO DOUBLE NOT NULL,
            DESCRICAO VARCHAR(100) NOT NULL,
            FORNECEDOR VARCHAR(14) NOT NULL,
            DEPARTAMENTO INT NOT NULL, 
        */

        #region "ATRIBUTOS"
        private int codProduto;
        private int quantidade;
        private double preco;
        private string descricao;
        private Fornecedores fornecedor;
        private Departamento departamento;

        //CONSTRUTORES DA CLASSE
        public Produto(int codProduto, int quantidade, double preco, string descricao, Departamento departamento, Fornecedores fornecedor)
        {
            this.codProduto = codProduto;
            this.quantidade = quantidade;
            this.preco = preco;
            this.descricao = descricao;
            this.departamento = departamento;
            this.fornecedor = fornecedor;
        }
        public Produto(int codProduto)
        {
            this.codProduto = codProduto;
        }
        public Produto(int quantidade, double preco, string descricao, Fornecedores fornecedor, Departamento departamento)
        {
            this.quantidade = quantidade;
            this.preco = preco;
            this.descricao = descricao;
            this.fornecedor = fornecedor;
            this.departamento = departamento;
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
                db.ExecutarComandoSQL("INSERT INTO PRODUTOS(QUANTIDADE,PRECO,DESCRICAO,FORNECEDOR,DEPARTAMENTO) " +
                    "VALUES('"+this.quantidade+"','"+this.preco+"','"+this.descricao+"','"+this.fornecedor.getCnpj()+"','"+this.departamento.getCodDepartamento()+"')", true);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar o produto! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO ESPECÍFICO PARA REALIZAR O DELETE NO DB
        public override void excluir(int codProduto)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("DELETE FROM PRODUTOS WHERE COD_PRODUTO= '"+codProduto+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o produto! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODO ESPECÍFICO PARA REALIZAR O UPDATE NO DB
        public override void alterar(int codProduto)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL("UPDATE PRODUTOS SET QUANTIDADE = '"+this.quantidade+"', PRECO = '"+this.preco+"', DESCRICAO = '"+this.descricao+"', " +
                    "FORNECEDOR = '"+this.fornecedor.getCnpj() + "', DEPARTAMENTO = '"+this.departamento.getCodDepartamento()+ "' " +
                    "WHERE COD_PRODUTO= '"+codProduto+"'", true);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar o produto! Erro: " + e.Message);
            }
            finally
            {
                db = null;
            }
        }
        //MÉTODOS DE ENCAPSULAMENTO
        public int getCodProduto()
        {
            return this.codProduto;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public double getPreco()
        {
            return this.preco;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public Departamento getDepartamento()
        {
            return this.departamento;
        }
        public Fornecedores getFornecedor()
        {
            return this.fornecedor;
        }
        public void setQuantidade(int valor)
        {
            this.quantidade = valor;
        }
        public void setPreco(double valor)
        {
            this.preco = valor;
        }
        public void setDescricao(string valor)
        {
            this.descricao = valor;
        }
        public void setDepartamento(Departamento valor)
        {
            this.departamento = valor;
        }
        public void setFornecedor(Fornecedores valor)
        {
            this.fornecedor = valor;
        }
        #endregion
    }
}