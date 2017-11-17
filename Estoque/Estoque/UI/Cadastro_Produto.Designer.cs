namespace Estoque
{
    partial class Cadastro_Produto
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
            this.lbl_codProduto = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_descrição = new System.Windows.Forms.Label();
            this.data_produto = new System.Windows.Forms.DateTimePicker();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.cmb_fornecedorList = new System.Windows.Forms.ComboBox();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Produto";
            // 
            // lbl_codProduto
            // 
            this.lbl_codProduto.AutoSize = true;
            this.lbl_codProduto.Location = new System.Drawing.Point(25, 138);
            this.lbl_codProduto.Name = "lbl_codProduto";
            this.lbl_codProduto.Size = new System.Drawing.Size(130, 17);
            this.lbl_codProduto.TabIndex = 1;
            this.lbl_codProduto.Text = "Código do Produto:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(25, 180);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(25, 219);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(49, 17);
            this.lbl_preco.TabIndex = 3;
            this.lbl_preco.Text = "Preço:";
            // 
            // lbl_descrição
            // 
            this.lbl_descrição.AutoSize = true;
            this.lbl_descrição.Location = new System.Drawing.Point(25, 254);
            this.lbl_descrição.Name = "lbl_descrição";
            this.lbl_descrição.Size = new System.Drawing.Size(73, 17);
            this.lbl_descrição.TabIndex = 4;
            this.lbl_descrição.Text = "descrição:";
            // 
            // data_produto
            // 
            this.data_produto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_produto.Location = new System.Drawing.Point(479, 138);
            this.data_produto.Name = "data_produto";
            this.data_produto.Size = new System.Drawing.Size(109, 22);
            this.data_produto.TabIndex = 5;
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(492, 207);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(81, 17);
            this.lbl_fornecedor.TabIndex = 6;
            this.lbl_fornecedor.Text = "Fornecedor";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Location = new System.Drawing.Point(161, 138);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.Size = new System.Drawing.Size(223, 22);
            this.txb_codigo.TabIndex = 7;
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(80, 180);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(304, 22);
            this.txb_nome.TabIndex = 8;
            // 
            // txb_preco
            // 
            this.txb_preco.Location = new System.Drawing.Point(80, 219);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(100, 22);
            this.txb_preco.TabIndex = 9;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(104, 254);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(280, 124);
            this.txb_descricao.TabIndex = 10;
            // 
            // cmb_fornecedorList
            // 
            this.cmb_fornecedorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fornecedorList.FormattingEnabled = true;
            this.cmb_fornecedorList.Location = new System.Drawing.Point(467, 227);
            this.cmb_fornecedorList.Name = "cmb_fornecedorList";
            this.cmb_fornecedorList.Size = new System.Drawing.Size(212, 24);
            this.cmb_fornecedorList.TabIndex = 11;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(704, 355);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(127, 58);
            this.btn_cadastro.TabIndex = 12;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 485);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.cmb_fornecedorList);
            this.Controls.Add(this.txb_descricao);
            this.Controls.Add(this.txb_preco);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.lbl_fornecedor);
            this.Controls.Add(this.data_produto);
            this.Controls.Add(this.lbl_descrição);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_codProduto);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Produto";
            this.Text = "Cadastro_Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_codProduto;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_descrição;
        private System.Windows.Forms.DateTimePicker data_produto;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_preco;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.ComboBox cmb_fornecedorList;
        private System.Windows.Forms.Button btn_cadastro;
    }
}