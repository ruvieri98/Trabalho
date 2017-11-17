namespace Estoque
{
    partial class Cadastro_Cliente
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
            this.lbl_cadastroCliente = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mask_ddd = new System.Windows.Forms.MaskedTextBox();
            this.mask_codCidade = new System.Windows.Forms.MaskedTextBox();
            this.txb_complementoFornecedor = new System.Windows.Forms.TextBox();
            this.txb_cidadeFornecedor = new System.Windows.Forms.TextBox();
            this.txb_ruaFornecedor = new System.Windows.Forms.TextBox();
            this.mask_cnjpFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txb_emailFornecedor = new System.Windows.Forms.TextBox();
            this.mask_numCasaFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txb_cepFornecedor = new System.Windows.Forms.TextBox();
            this.txb_bairroFornecedor = new System.Windows.Forms.TextBox();
            this.mask_dataFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txb_nomeFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipoTelefone = new System.Windows.Forms.ComboBox();
            this.lbl_telefoneFornecedor = new System.Windows.Forms.Label();
            this.lbl_ddd = new System.Windows.Forms.Label();
            this.lbl_codFornecedor = new System.Windows.Forms.Label();
            this.lbl_complementoFornecedor = new System.Windows.Forms.Label();
            this.lbl_numCasaFornecedor = new System.Windows.Forms.Label();
            this.lbl_ruaFornecedor = new System.Windows.Forms.Label();
            this.lbl_cepFornecedor = new System.Windows.Forms.Label();
            this.lbl_cidadeFornecedor = new System.Windows.Forms.Label();
            this.lbl_bairroFornecedor = new System.Windows.Forms.Label();
            this.lbl_cnjpFornecedor = new System.Windows.Forms.Label();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_emailFornecedor = new System.Windows.Forms.Label();
            this.lbl_nomeFornecedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cadastroCliente
            // 
            this.lbl_cadastroCliente.AutoSize = true;
            this.lbl_cadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastroCliente.Location = new System.Drawing.Point(415, 9);
            this.lbl_cadastroCliente.Name = "lbl_cadastroCliente";
            this.lbl_cadastroCliente.Size = new System.Drawing.Size(235, 36);
            this.lbl_cadastroCliente.TabIndex = 0;
            this.lbl_cadastroCliente.Text = "Cadastro Cliente";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(770, 329);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(141, 67);
            this.btn_cadastrar.TabIndex = 58;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // mask_telefone
            // 
            this.mask_telefone.Location = new System.Drawing.Point(770, 166);
            this.mask_telefone.Mask = "0000-000099";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(100, 22);
            this.mask_telefone.TabIndex = 57;
            this.mask_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mask_ddd
            // 
            this.mask_ddd.Location = new System.Drawing.Point(744, 124);
            this.mask_ddd.Mask = "00999";
            this.mask_ddd.Name = "mask_ddd";
            this.mask_ddd.Size = new System.Drawing.Size(100, 22);
            this.mask_ddd.TabIndex = 56;
            // 
            // mask_codCidade
            // 
            this.mask_codCidade.Location = new System.Drawing.Point(826, 70);
            this.mask_codCidade.Mask = "00999";
            this.mask_codCidade.Name = "mask_codCidade";
            this.mask_codCidade.Size = new System.Drawing.Size(100, 22);
            this.mask_codCidade.TabIndex = 55;
            // 
            // txb_complementoFornecedor
            // 
            this.txb_complementoFornecedor.Location = new System.Drawing.Point(432, 288);
            this.txb_complementoFornecedor.Name = "txb_complementoFornecedor";
            this.txb_complementoFornecedor.Size = new System.Drawing.Size(138, 22);
            this.txb_complementoFornecedor.TabIndex = 54;
            // 
            // txb_cidadeFornecedor
            // 
            this.txb_cidadeFornecedor.Location = new System.Drawing.Point(394, 245);
            this.txb_cidadeFornecedor.Name = "txb_cidadeFornecedor";
            this.txb_cidadeFornecedor.Size = new System.Drawing.Size(186, 22);
            this.txb_cidadeFornecedor.TabIndex = 53;
            // 
            // txb_ruaFornecedor
            // 
            this.txb_ruaFornecedor.Location = new System.Drawing.Point(376, 197);
            this.txb_ruaFornecedor.Name = "txb_ruaFornecedor";
            this.txb_ruaFornecedor.Size = new System.Drawing.Size(194, 22);
            this.txb_ruaFornecedor.TabIndex = 52;
            // 
            // mask_cnjpFornecedor
            // 
            this.mask_cnjpFornecedor.Location = new System.Drawing.Point(385, 124);
            this.mask_cnjpFornecedor.Mask = "000000000/00";
            this.mask_cnjpFornecedor.Name = "mask_cnjpFornecedor";
            this.mask_cnjpFornecedor.Size = new System.Drawing.Size(185, 22);
            this.mask_cnjpFornecedor.TabIndex = 51;
            this.mask_cnjpFornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txb_emailFornecedor
            // 
            this.txb_emailFornecedor.Location = new System.Drawing.Point(384, 68);
            this.txb_emailFornecedor.Name = "txb_emailFornecedor";
            this.txb_emailFornecedor.Size = new System.Drawing.Size(186, 22);
            this.txb_emailFornecedor.TabIndex = 50;
            // 
            // mask_numCasaFornecedor
            // 
            this.mask_numCasaFornecedor.Location = new System.Drawing.Point(120, 291);
            this.mask_numCasaFornecedor.Mask = "09999";
            this.mask_numCasaFornecedor.Name = "mask_numCasaFornecedor";
            this.mask_numCasaFornecedor.Size = new System.Drawing.Size(81, 22);
            this.mask_numCasaFornecedor.TabIndex = 49;
            this.mask_numCasaFornecedor.ValidatingType = typeof(int);
            // 
            // txb_cepFornecedor
            // 
            this.txb_cepFornecedor.Location = new System.Drawing.Point(97, 250);
            this.txb_cepFornecedor.Name = "txb_cepFornecedor";
            this.txb_cepFornecedor.Size = new System.Drawing.Size(104, 22);
            this.txb_cepFornecedor.TabIndex = 48;
            // 
            // txb_bairroFornecedor
            // 
            this.txb_bairroFornecedor.Location = new System.Drawing.Point(108, 197);
            this.txb_bairroFornecedor.Name = "txb_bairroFornecedor";
            this.txb_bairroFornecedor.Size = new System.Drawing.Size(186, 22);
            this.txb_bairroFornecedor.TabIndex = 47;
            // 
            // mask_dataFornecedor
            // 
            this.mask_dataFornecedor.Location = new System.Drawing.Point(127, 127);
            this.mask_dataFornecedor.Mask = "00/00/0000";
            this.mask_dataFornecedor.Name = "mask_dataFornecedor";
            this.mask_dataFornecedor.Size = new System.Drawing.Size(74, 22);
            this.mask_dataFornecedor.TabIndex = 46;
            this.mask_dataFornecedor.ValidatingType = typeof(System.DateTime);
            // 
            // txb_nomeFornecedor
            // 
            this.txb_nomeFornecedor.Location = new System.Drawing.Point(107, 73);
            this.txb_nomeFornecedor.Name = "txb_nomeFornecedor";
            this.txb_nomeFornecedor.Size = new System.Drawing.Size(204, 22);
            this.txb_nomeFornecedor.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(893, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tipo:";
            // 
            // cmb_tipoTelefone
            // 
            this.cmb_tipoTelefone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoTelefone.FormattingEnabled = true;
            this.cmb_tipoTelefone.Items.AddRange(new object[] {
            "Fixo",
            "Móvel",
            "Outros"});
            this.cmb_tipoTelefone.Location = new System.Drawing.Point(939, 127);
            this.cmb_tipoTelefone.Name = "cmb_tipoTelefone";
            this.cmb_tipoTelefone.Size = new System.Drawing.Size(121, 24);
            this.cmb_tipoTelefone.TabIndex = 43;
            // 
            // lbl_telefoneFornecedor
            // 
            this.lbl_telefoneFornecedor.AutoSize = true;
            this.lbl_telefoneFornecedor.Location = new System.Drawing.Point(696, 166);
            this.lbl_telefoneFornecedor.Name = "lbl_telefoneFornecedor";
            this.lbl_telefoneFornecedor.Size = new System.Drawing.Size(68, 17);
            this.lbl_telefoneFornecedor.TabIndex = 42;
            this.lbl_telefoneFornecedor.Text = "Telefone:";
            // 
            // lbl_ddd
            // 
            this.lbl_ddd.AutoSize = true;
            this.lbl_ddd.Location = new System.Drawing.Point(696, 127);
            this.lbl_ddd.Name = "lbl_ddd";
            this.lbl_ddd.Size = new System.Drawing.Size(42, 17);
            this.lbl_ddd.TabIndex = 41;
            this.lbl_ddd.Text = "DDD:";
            // 
            // lbl_codFornecedor
            // 
            this.lbl_codFornecedor.AutoSize = true;
            this.lbl_codFornecedor.Location = new System.Drawing.Point(696, 73);
            this.lbl_codFornecedor.Name = "lbl_codFornecedor";
            this.lbl_codFornecedor.Size = new System.Drawing.Size(124, 17);
            this.lbl_codFornecedor.TabIndex = 40;
            this.lbl_codFornecedor.Text = "Código da Cidade:";
            // 
            // lbl_complementoFornecedor
            // 
            this.lbl_complementoFornecedor.AutoSize = true;
            this.lbl_complementoFornecedor.Location = new System.Drawing.Point(332, 291);
            this.lbl_complementoFornecedor.Name = "lbl_complementoFornecedor";
            this.lbl_complementoFornecedor.Size = new System.Drawing.Size(94, 17);
            this.lbl_complementoFornecedor.TabIndex = 39;
            this.lbl_complementoFornecedor.Text = "Complemento";
            // 
            // lbl_numCasaFornecedor
            // 
            this.lbl_numCasaFornecedor.AutoSize = true;
            this.lbl_numCasaFornecedor.Location = new System.Drawing.Point(52, 291);
            this.lbl_numCasaFornecedor.Name = "lbl_numCasaFornecedor";
            this.lbl_numCasaFornecedor.Size = new System.Drawing.Size(62, 17);
            this.lbl_numCasaFornecedor.TabIndex = 38;
            this.lbl_numCasaFornecedor.Text = "Numero:";
            // 
            // lbl_ruaFornecedor
            // 
            this.lbl_ruaFornecedor.AutoSize = true;
            this.lbl_ruaFornecedor.Location = new System.Drawing.Point(332, 200);
            this.lbl_ruaFornecedor.Name = "lbl_ruaFornecedor";
            this.lbl_ruaFornecedor.Size = new System.Drawing.Size(38, 17);
            this.lbl_ruaFornecedor.TabIndex = 37;
            this.lbl_ruaFornecedor.Text = "Rua:";
            // 
            // lbl_cepFornecedor
            // 
            this.lbl_cepFornecedor.AutoSize = true;
            this.lbl_cepFornecedor.Location = new System.Drawing.Point(52, 250);
            this.lbl_cepFornecedor.Name = "lbl_cepFornecedor";
            this.lbl_cepFornecedor.Size = new System.Drawing.Size(39, 17);
            this.lbl_cepFornecedor.TabIndex = 36;
            this.lbl_cepFornecedor.Text = "CEP:";
            // 
            // lbl_cidadeFornecedor
            // 
            this.lbl_cidadeFornecedor.AutoSize = true;
            this.lbl_cidadeFornecedor.Location = new System.Drawing.Point(332, 250);
            this.lbl_cidadeFornecedor.Name = "lbl_cidadeFornecedor";
            this.lbl_cidadeFornecedor.Size = new System.Drawing.Size(56, 17);
            this.lbl_cidadeFornecedor.TabIndex = 35;
            this.lbl_cidadeFornecedor.Text = "Cidade:";
            // 
            // lbl_bairroFornecedor
            // 
            this.lbl_bairroFornecedor.AutoSize = true;
            this.lbl_bairroFornecedor.Location = new System.Drawing.Point(52, 200);
            this.lbl_bairroFornecedor.Name = "lbl_bairroFornecedor";
            this.lbl_bairroFornecedor.Size = new System.Drawing.Size(50, 17);
            this.lbl_bairroFornecedor.TabIndex = 34;
            this.lbl_bairroFornecedor.Text = "Bairro:";
            // 
            // lbl_cnjpFornecedor
            // 
            this.lbl_cnjpFornecedor.AutoSize = true;
            this.lbl_cnjpFornecedor.Location = new System.Drawing.Point(332, 127);
            this.lbl_cnjpFornecedor.Name = "lbl_cnjpFornecedor";
            this.lbl_cnjpFornecedor.Size = new System.Drawing.Size(38, 17);
            this.lbl_cnjpFornecedor.TabIndex = 33;
            this.lbl_cnjpFornecedor.Text = "CPF:";
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Location = new System.Drawing.Point(52, 127);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(69, 17);
            this.lbl_dataNasc.TabIndex = 32;
            this.lbl_dataNasc.Text = "Data nas:";
            // 
            // lbl_emailFornecedor
            // 
            this.lbl_emailFornecedor.AutoSize = true;
            this.lbl_emailFornecedor.Location = new System.Drawing.Point(332, 73);
            this.lbl_emailFornecedor.Name = "lbl_emailFornecedor";
            this.lbl_emailFornecedor.Size = new System.Drawing.Size(46, 17);
            this.lbl_emailFornecedor.TabIndex = 31;
            this.lbl_emailFornecedor.Text = "Email:";
            // 
            // lbl_nomeFornecedor
            // 
            this.lbl_nomeFornecedor.AutoSize = true;
            this.lbl_nomeFornecedor.Location = new System.Drawing.Point(52, 73);
            this.lbl_nomeFornecedor.Name = "lbl_nomeFornecedor";
            this.lbl_nomeFornecedor.Size = new System.Drawing.Size(49, 17);
            this.lbl_nomeFornecedor.TabIndex = 30;
            this.lbl_nomeFornecedor.Text = "Nome:";
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 464);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.mask_telefone);
            this.Controls.Add(this.mask_ddd);
            this.Controls.Add(this.mask_codCidade);
            this.Controls.Add(this.txb_complementoFornecedor);
            this.Controls.Add(this.txb_cidadeFornecedor);
            this.Controls.Add(this.txb_ruaFornecedor);
            this.Controls.Add(this.mask_cnjpFornecedor);
            this.Controls.Add(this.txb_emailFornecedor);
            this.Controls.Add(this.mask_numCasaFornecedor);
            this.Controls.Add(this.txb_cepFornecedor);
            this.Controls.Add(this.txb_bairroFornecedor);
            this.Controls.Add(this.mask_dataFornecedor);
            this.Controls.Add(this.txb_nomeFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipoTelefone);
            this.Controls.Add(this.lbl_telefoneFornecedor);
            this.Controls.Add(this.lbl_ddd);
            this.Controls.Add(this.lbl_codFornecedor);
            this.Controls.Add(this.lbl_complementoFornecedor);
            this.Controls.Add(this.lbl_numCasaFornecedor);
            this.Controls.Add(this.lbl_ruaFornecedor);
            this.Controls.Add(this.lbl_cepFornecedor);
            this.Controls.Add(this.lbl_cidadeFornecedor);
            this.Controls.Add(this.lbl_bairroFornecedor);
            this.Controls.Add(this.lbl_cnjpFornecedor);
            this.Controls.Add(this.lbl_dataNasc);
            this.Controls.Add(this.lbl_emailFornecedor);
            this.Controls.Add(this.lbl_nomeFornecedor);
            this.Controls.Add(this.lbl_cadastroCliente);
            this.Name = "Cadastro_Cliente";
            this.Text = "Cadastro_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cadastroCliente;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
        private System.Windows.Forms.MaskedTextBox mask_ddd;
        private System.Windows.Forms.MaskedTextBox mask_codCidade;
        private System.Windows.Forms.TextBox txb_complementoFornecedor;
        private System.Windows.Forms.TextBox txb_cidadeFornecedor;
        private System.Windows.Forms.TextBox txb_ruaFornecedor;
        private System.Windows.Forms.MaskedTextBox mask_cnjpFornecedor;
        private System.Windows.Forms.TextBox txb_emailFornecedor;
        private System.Windows.Forms.MaskedTextBox mask_numCasaFornecedor;
        private System.Windows.Forms.TextBox txb_cepFornecedor;
        private System.Windows.Forms.TextBox txb_bairroFornecedor;
        private System.Windows.Forms.MaskedTextBox mask_dataFornecedor;
        private System.Windows.Forms.TextBox txb_nomeFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tipoTelefone;
        private System.Windows.Forms.Label lbl_telefoneFornecedor;
        private System.Windows.Forms.Label lbl_ddd;
        private System.Windows.Forms.Label lbl_codFornecedor;
        private System.Windows.Forms.Label lbl_complementoFornecedor;
        private System.Windows.Forms.Label lbl_numCasaFornecedor;
        private System.Windows.Forms.Label lbl_ruaFornecedor;
        private System.Windows.Forms.Label lbl_cepFornecedor;
        private System.Windows.Forms.Label lbl_cidadeFornecedor;
        private System.Windows.Forms.Label lbl_bairroFornecedor;
        private System.Windows.Forms.Label lbl_cnjpFornecedor;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_emailFornecedor;
        private System.Windows.Forms.Label lbl_nomeFornecedor;
    }
}