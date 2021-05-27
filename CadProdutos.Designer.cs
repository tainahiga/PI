
namespace PI
{
    partial class CadProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.departamento = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.fornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO DE PRODUTOS NO ESTOQUE";
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(200, 89);
            this.quantidade.Name = "quantidade";
            this.quantidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantidade.Size = new System.Drawing.Size(174, 20);
            this.quantidade.TabIndex = 2;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(200, 127);
            this.preco.Name = "preco";
            this.preco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.preco.Size = new System.Drawing.Size(174, 20);
            this.preco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PREÇO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DEPARTAMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DESCRIÇÃO";
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(200, 165);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(174, 20);
            this.descricao.TabIndex = 4;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(299, 316);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // departamento
            // 
            this.departamento.FormattingEnabled = true;
            this.departamento.Items.AddRange(new object[] {
            "Higiene",
            "Açougue",
            "Bebidas",
            "Laticíneos",
            "Hortifruti",
            "Mercearia",
            "Padaria",
            "Rotisseria",
            "Bomboniere"});
            this.departamento.Location = new System.Drawing.Point(200, 203);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(174, 21);
            this.departamento.TabIndex = 4;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(200, 316);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // fornecedor
            // 
            this.fornecedor.FormattingEnabled = true;
            this.fornecedor.Items.AddRange(new object[] {
            "Higiene",
            "Açougue",
            "Bebidas",
            "Laticíneos",
            "Hortifruti",
            "Mercearia",
            "Padaria",
            "Rotisseria",
            "Bomboniere"});
            this.fornecedor.Location = new System.Drawing.Point(200, 242);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(174, 21);
            this.fornecedor.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "FORNECEDOR";
            // 
            // CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 369);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label1);
            this.Name = "CadProdutos";
            this.Text = "CadProdutos";
            this.Load += new System.EventHandler(this.CadProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ComboBox departamento;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ComboBox fornecedor;
        private System.Windows.Forms.Label label7;
    }
}

