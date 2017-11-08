namespace Estoque
{
    partial class Estoque_pricipal
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
            this.lbl_Sistema_Estoque_Principal = new System.Windows.Forms.Label();
            this.Create_Client = new System.Windows.Forms.Button();
            this.Del_Client = new System.Windows.Forms.Button();
            this.Search_Client = new System.Windows.Forms.Button();
            this.Cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Sistema_Estoque_Principal
            // 
            this.lbl_Sistema_Estoque_Principal.AutoSize = true;
            this.lbl_Sistema_Estoque_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sistema_Estoque_Principal.Location = new System.Drawing.Point(261, 24);
            this.lbl_Sistema_Estoque_Principal.Name = "lbl_Sistema_Estoque_Principal";
            this.lbl_Sistema_Estoque_Principal.Size = new System.Drawing.Size(263, 39);
            this.lbl_Sistema_Estoque_Principal.TabIndex = 1;
            this.lbl_Sistema_Estoque_Principal.Text = "OPT ESTOQUE";
            // 
            // Create_Client
            // 
            this.Create_Client.Location = new System.Drawing.Point(40, 338);
            this.Create_Client.Name = "Create_Client";
            this.Create_Client.Size = new System.Drawing.Size(119, 79);
            this.Create_Client.TabIndex = 2;
            this.Create_Client.Text = "Criar Cliente";
            this.Create_Client.UseVisualStyleBackColor = true;
            this.Create_Client.Click += new System.EventHandler(this.Create_Client_Click);
            // 
            // Del_Client
            // 
            this.Del_Client.Location = new System.Drawing.Point(305, 338);
            this.Del_Client.Name = "Del_Client";
            this.Del_Client.Size = new System.Drawing.Size(116, 79);
            this.Del_Client.TabIndex = 3;
            this.Del_Client.Text = "Deleta Cliente";
            this.Del_Client.UseVisualStyleBackColor = true;
            this.Del_Client.Click += new System.EventHandler(this.Del_Client_Click);
            // 
            // Search_Client
            // 
            this.Search_Client.Location = new System.Drawing.Point(612, 338);
            this.Search_Client.Name = "Search_Client";
            this.Search_Client.Size = new System.Drawing.Size(124, 79);
            this.Search_Client.TabIndex = 4;
            this.Search_Client.Text = "Procurar Cliente";
            this.Search_Client.UseVisualStyleBackColor = true;
            this.Search_Client.Click += new System.EventHandler(this.Search_Client_Click);
            // 
            // Cmb_Cliente
            // 
            this.Cmb_Cliente.FormattingEnabled = true;
            this.Cmb_Cliente.Location = new System.Drawing.Point(225, 85);
            this.Cmb_Cliente.Name = "Cmb_Cliente";
            this.Cmb_Cliente.Size = new System.Drawing.Size(215, 24);
            this.Cmb_Cliente.TabIndex = 5;
            this.Cmb_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cmb_Cliente_SelectedIndexChanged);
            // 
            // Estoque_pricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 493);
            this.Controls.Add(this.Cmb_Cliente);
            this.Controls.Add(this.Search_Client);
            this.Controls.Add(this.Del_Client);
            this.Controls.Add(this.Create_Client);
            this.Controls.Add(this.lbl_Sistema_Estoque_Principal);
            this.Name = "Estoque_pricipal";
            this.Text = "Sistema de Estoque";
            this.Load += new System.EventHandler(this.Estoque_pricipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sistema_Estoque_Principal;
        private System.Windows.Forms.Button Create_Client;
        private System.Windows.Forms.Button Del_Client;
        private System.Windows.Forms.Button Search_Client;
        private System.Windows.Forms.ComboBox Cmb_Cliente;
    }
}

