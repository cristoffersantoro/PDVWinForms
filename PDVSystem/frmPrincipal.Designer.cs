namespace PDVSystem
{
    partial class FrmPrincipal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.ucPdvProdutos = new PDVSystem.Componentes.PDV.UcPdvProdutos();
            this.ucPdvPedidoCliente = new PDVSystem.Componentes.PDV.UcPdvPedidoCliente();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlPrincipal.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlPrincipal.Controls.Add(this.ucPdvPedidoCliente);
            this.pnlPrincipal.Controls.Add(this.ucPdvProdutos);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 1);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1081, 479);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // ucPdvProdutos
            // 
            this.ucPdvProdutos.Location = new System.Drawing.Point(3, 3);
            this.ucPdvProdutos.Name = "ucPdvProdutos";
            this.ucPdvProdutos.Size = new System.Drawing.Size(536, 476);
            this.ucPdvProdutos.TabIndex = 0;
            // 
            // ucPdvPedidoCliente
            // 
            this.ucPdvPedidoCliente.Location = new System.Drawing.Point(545, 3);
            this.ucPdvPedidoCliente.Name = "ucPdvPedidoCliente";
            this.ucPdvPedidoCliente.Size = new System.Drawing.Size(536, 476);
            this.ucPdvPedidoCliente.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1108, 504);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlPrincipal;
        private Componentes.PDV.UcPdvProdutos ucPdvProdutos;
        private Componentes.PDV.UcPdvPedidoCliente ucPdvPedidoCliente;
    }
}