
namespace PI
{
    partial class CadGeral
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
            this.btDepartamentos = new System.Windows.Forms.Button();
            this.btFornecedores = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDepartamentos
            // 
            this.btDepartamentos.Location = new System.Drawing.Point(301, 135);
            this.btDepartamentos.Name = "btDepartamentos";
            this.btDepartamentos.Size = new System.Drawing.Size(120, 25);
            this.btDepartamentos.TabIndex = 13;
            this.btDepartamentos.Text = "DEPARTAMENTOS";
            this.btDepartamentos.UseVisualStyleBackColor = true;
            this.btDepartamentos.Click += new System.EventHandler(this.btDepartamentos_Click);
            // 
            // btFornecedores
            // 
            this.btFornecedores.Location = new System.Drawing.Point(168, 135);
            this.btFornecedores.Name = "btFornecedores";
            this.btFornecedores.Size = new System.Drawing.Size(120, 25);
            this.btFornecedores.TabIndex = 12;
            this.btFornecedores.Text = "FORNECEDORES";
            this.btFornecedores.UseVisualStyleBackColor = true;
            this.btFornecedores.Click += new System.EventHandler(this.btFornecedores_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.Location = new System.Drawing.Point(35, 135);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(120, 25);
            this.btProdutos.TabIndex = 11;
            this.btProdutos.Text = "PRODUTOS";
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "CADASTRO QUICKSTOCK";
            // 
            // CadGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 215);
            this.Controls.Add(this.btDepartamentos);
            this.Controls.Add(this.btFornecedores);
            this.Controls.Add(this.btProdutos);
            this.Controls.Add(this.label1);
            this.Name = "CadGeral";
            this.Text = "CadGeral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDepartamentos;
        private System.Windows.Forms.Button btFornecedores;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Label label1;
    }
}