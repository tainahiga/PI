
namespace PI
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codFunc = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.btAcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTROLE DE ACESSO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "COD. FUNC.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "SENHA";
            // 
            // codFunc
            // 
            this.codFunc.Location = new System.Drawing.Point(95, 139);
            this.codFunc.Name = "codFunc";
            this.codFunc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.codFunc.Size = new System.Drawing.Size(174, 20);
            this.codFunc.TabIndex = 6;
            this.codFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(95, 203);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.senha.Size = new System.Drawing.Size(174, 20);
            this.senha.TabIndex = 7;
            this.senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAcessar.Location = new System.Drawing.Point(145, 255);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(75, 23);
            this.btAcessar.TabIndex = 8;
            this.btAcessar.Text = "ACESSAR";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 301);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.codFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codFunc;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button btAcessar;
    }
}