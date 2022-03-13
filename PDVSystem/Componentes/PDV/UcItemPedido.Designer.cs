namespace PDVSystem.Componentes.PDV
{
    partial class UcItemPedido
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
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.numQtdeItems = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(9, 5);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(86, 15);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Produto Item 1";
            // 
            // numQtdeItems
            // 
            this.numQtdeItems.Location = new System.Drawing.Point(335, 1);
            this.numQtdeItems.Name = "numQtdeItems";
            this.numQtdeItems.Size = new System.Drawing.Size(120, 23);
            this.numQtdeItems.TabIndex = 1;
            this.numQtdeItems.ValueChanged += new System.EventHandler(this.numQtdeItems_ValueChanged);
            // 
            // UcItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numQtdeItems);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "UcItemPedido";
            this.Size = new System.Drawing.Size(460, 25);
            this.Load += new System.EventHandler(this.UcItemPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeProduto;
        private NumericUpDown numQtdeItems;
    }
}
