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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Estoque_pricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Sistema_Estoque_Principal);
            this.Name = "Estoque_pricipal";
            this.Text = "Sistema de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sistema_Estoque_Principal;
        private System.Windows.Forms.Button button1;
    }
}

