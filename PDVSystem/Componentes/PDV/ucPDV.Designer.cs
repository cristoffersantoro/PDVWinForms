namespace PDVSystem.Componentes
{
    partial class ucPDV
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
            this.ucpdvProdutos1 = new PDVSystem.Componentes.PDV.ucPDVProdutos();
            this.ucpdvPedidoCliente1 = new PDVSystem.Componentes.PDV.ucPDVPedidoCliente();
            this.SuspendLayout();
            // 
            // ucpdvProdutos1
            // 
            this.ucpdvProdutos1.Location = new System.Drawing.Point(0, 0);
            this.ucpdvProdutos1.Name = "ucpdvProdutos1";
            this.ucpdvProdutos1.Size = new System.Drawing.Size(536, 476);
            this.ucpdvProdutos1.TabIndex = 0;
            // 
            // ucpdvPedidoCliente1
            // 
            this.ucpdvPedidoCliente1.Location = new System.Drawing.Point(542, 0);
            this.ucpdvPedidoCliente1.Name = "ucpdvPedidoCliente1";
            this.ucpdvPedidoCliente1.Size = new System.Drawing.Size(536, 476);
            this.ucpdvPedidoCliente1.TabIndex = 1;
            this.ucpdvPedidoCliente1.Load += new System.EventHandler(this.ucpdvPedidoCliente1_Load);
            // 
            // ucPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucpdvPedidoCliente1);
            this.Controls.Add(this.ucpdvProdutos1);
            this.Name = "ucPDV";
            this.Size = new System.Drawing.Size(1081, 476);
            this.ResumeLayout(false);

        }

        #endregion

        private PDV.ucPDVProdutos ucpdvProdutos1;
        private PDV.ucPDVPedidoCliente ucpdvPedidoCliente1;
    }
}
