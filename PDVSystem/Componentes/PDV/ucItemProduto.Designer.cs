namespace PDVSystem.Componentes.PDV
{
    partial class ucItemProduto
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIndisponivel = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.ptbImagemProduto = new System.Windows.Forms.PictureBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndisponivel
            // 
            this.btnIndisponivel.BackColor = System.Drawing.Color.DarkGray;
            this.btnIndisponivel.FlatAppearance.BorderSize = 0;
            this.btnIndisponivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndisponivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIndisponivel.Location = new System.Drawing.Point(3, 82);
            this.btnIndisponivel.Name = "btnIndisponivel";
            this.btnIndisponivel.Size = new System.Drawing.Size(219, 36);
            this.btnIndisponivel.TabIndex = 8;
            this.btnIndisponivel.Text = "Indisponível";
            this.btnIndisponivel.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionarProduto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(3, 82);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(219, 36);
            this.btnAdicionarProduto.TabIndex = 9;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            // 
            // ptbImagemProduto
            // 
            this.ptbImagemProduto.Location = new System.Drawing.Point(3, 4);
            this.ptbImagemProduto.Name = "ptbImagemProduto";
            this.ptbImagemProduto.Size = new System.Drawing.Size(73, 73);
            this.ptbImagemProduto.TabIndex = 10;
            this.ptbImagemProduto.TabStop = false;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeProduto.Location = new System.Drawing.Point(82, 4);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(135, 28);
            this.lblNomeProduto.TabIndex = 11;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoProduto.Location = new System.Drawing.Point(82, 51);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(135, 28);
            this.lblPrecoProduto.TabIndex = 12;
            this.lblPrecoProduto.Text = "R$ 200,00";
            // 
            // ucItemProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.ptbImagemProduto);
            this.Controls.Add(this.btnIndisponivel);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Name = "ucItemProduto";
            this.Size = new System.Drawing.Size(227, 121);
            this.Load += new System.EventHandler(this.ucItemProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIndisponivel;
        private Button btnAdicionarProduto;
        private PictureBox ptbImagemProduto;
        private Label lblNomeProduto;
        private Label lblPrecoProduto;
    }
}
