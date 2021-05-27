
namespace PI
{
    partial class ConsultaGeral
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
            this.label1 = new System.Windows.Forms.Label();
            this.btProdutos = new System.Windows.Forms.Button();
            this.btFornecedores = new System.Windows.Forms.Button();
            this.btDepartamentos = new System.Windows.Forms.Button();
            this.btRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSULTA QUICKSTOCK";
            // 
            // btProdutos
            // 
            this.btProdutos.Location = new System.Drawing.Point(31, 154);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(120, 25);
            this.btProdutos.TabIndex = 7;
            this.btProdutos.Text = "PRODUTOS";
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // btFornecedores
            // 
            this.btFornecedores.Location = new System.Drawing.Point(164, 154);
            this.btFornecedores.Name = "btFornecedores";
            this.btFornecedores.Size = new System.Drawing.Size(120, 25);
            this.btFornecedores.TabIndex = 8;
            this.btFornecedores.Text = "FORNECEDORES";
            this.btFornecedores.UseVisualStyleBackColor = true;
            this.btFornecedores.Click += new System.EventHandler(this.btFornecedores_Click);
            // 
            // btDepartamentos
            // 
            this.btDepartamentos.Location = new System.Drawing.Point(297, 154);
            this.btDepartamentos.Name = "btDepartamentos";
            this.btDepartamentos.Size = new System.Drawing.Size(120, 25);
            this.btDepartamentos.TabIndex = 9;
            this.btDepartamentos.Text = "DEPARTAMENTOS";
            this.btDepartamentos.UseVisualStyleBackColor = true;
            this.btDepartamentos.Click += new System.EventHandler(this.btDepartamentos_Click);
            // 
            // btRelatorios
            // 
            this.btRelatorios.Location = new System.Drawing.Point(165, 105);
            this.btRelatorios.Name = "btRelatorios";
            this.btRelatorios.Size = new System.Drawing.Size(120, 25);
            this.btRelatorios.TabIndex = 10;
            this.btRelatorios.Text = "RELATÓRIOS";
            this.btRelatorios.UseVisualStyleBackColor = true;
            this.btRelatorios.Click += new System.EventHandler(this.btRelatorios_Click);
            // 
            // ConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 235);
            this.Controls.Add(this.btRelatorios);
            this.Controls.Add(this.btDepartamentos);
            this.Controls.Add(this.btFornecedores);
            this.Controls.Add(this.btProdutos);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaGeral";
            this.Text = "ConsultaGeral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btFornecedores;
        private System.Windows.Forms.Button btDepartamentos;
        private System.Windows.Forms.Button btRelatorios;
    }
}