namespace Estoque
{
    partial class Form1
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
            this.lbl_cadastro_de_produto = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txb_desc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cadastro_de_produto
            // 
            this.lbl_cadastro_de_produto.AutoSize = true;
            this.lbl_cadastro_de_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro_de_produto.Location = new System.Drawing.Point(224, 22);
            this.lbl_cadastro_de_produto.Name = "lbl_cadastro_de_produto";
            this.lbl_cadastro_de_produto.Size = new System.Drawing.Size(330, 39);
            this.lbl_cadastro_de_produto.TabIndex = 0;
            this.lbl_cadastro_de_produto.Text = "Cadastro de Produto";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(27, 135);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(82, 135);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(212, 22);
            this.txb_nome.TabIndex = 2;
            this.txb_nome.TextChanged += new System.EventHandler(this.txb_nome_TextChanged);
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(27, 188);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(49, 17);
            this.lbl_preco.TabIndex = 3;
            this.lbl_preco.Text = "Preço:";
            // 
            // txb_desc
            // 
            this.txb_desc.Location = new System.Drawing.Point(82, 188);
            this.txb_desc.Name = "txb_desc";
            this.txb_desc.Size = new System.Drawing.Size(92, 22);
            this.txb_desc.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_desc);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cadastro_de_produto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cadastro_de_produto;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txb_desc;
        private System.Windows.Forms.Button button1;
    }
}

