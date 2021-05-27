
namespace PI
{
    partial class AltProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.departamento = new System.Windows.Forms.ComboBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fornecedor
            // 
            this.fornecedor.FormattingEnabled = true;
            this.fornecedor.Location = new System.Drawing.Point(199, 236);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(174, 21);
            this.fornecedor.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "FORNECEDOR";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(199, 310);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // departamento
            // 
            this.departamento.FormattingEnabled = true;
            this.departamento.Location = new System.Drawing.Point(199, 197);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(174, 21);
            this.departamento.TabIndex = 17;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(298, 310);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 19;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(199, 159);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(174, 20);
            this.descricao.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DESCRIÇÃO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DEPARTAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PREÇO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "QUANTIDADE";
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(199, 121);
            this.preco.Name = "preco";
            this.preco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.preco.Size = new System.Drawing.Size(174, 20);
            this.preco.TabIndex = 16;
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(199, 83);
            this.quantidade.Name = "quantidade";
            this.quantidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantidade.Size = new System.Drawing.Size(174, 20);
            this.quantidade.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "ALTERAÇÃO DE PRODUTO";
            // 
            // AltProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 366);
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
            this.Name = "AltProduto";
            this.Text = "AltProduto";
            this.Load += new System.EventHandler(this.AltProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ComboBox departamento;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Label label1;
    }
}