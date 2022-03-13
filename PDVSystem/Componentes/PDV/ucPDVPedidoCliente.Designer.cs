namespace PDVSystem.Componentes.PDV
{
    partial class UcPdvPedidoCliente
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
            this.lblPedidoCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flwPedidoCliente = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLimparPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessarPedido = new System.Windows.Forms.Button();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.nmcValorPagamento = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcValorPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidoCliente
            // 
            this.lblPedidoCliente.AutoSize = true;
            this.lblPedidoCliente.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPedidoCliente.Location = new System.Drawing.Point(35, 27);
            this.lblPedidoCliente.Name = "lblPedidoCliente";
            this.lblPedidoCliente.Size = new System.Drawing.Size(211, 32);
            this.lblPedidoCliente.TabIndex = 0;
            this.lblPedidoCliente.Text = "Pedido do Cliente";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flwPedidoCliente);
            this.panel1.Location = new System.Drawing.Point(35, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 170);
            this.panel1.TabIndex = 2;
            // 
            // flwPedidoCliente
            // 
            this.flwPedidoCliente.AutoSize = true;
            this.flwPedidoCliente.Location = new System.Drawing.Point(-1, -1);
            this.flwPedidoCliente.MaximumSize = new System.Drawing.Size(460, 0);
            this.flwPedidoCliente.Name = "flwPedidoCliente";
            this.flwPedidoCliente.Size = new System.Drawing.Size(460, 0);
            this.flwPedidoCliente.TabIndex = 0;
            // 
            // btnLimparPedido
            // 
            this.btnLimparPedido.BackColor = System.Drawing.Color.Gold;
            this.btnLimparPedido.FlatAppearance.BorderSize = 0;
            this.btnLimparPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparPedido.Location = new System.Drawing.Point(35, 271);
            this.btnLimparPedido.Name = "btnLimparPedido";
            this.btnLimparPedido.Size = new System.Drawing.Size(465, 36);
            this.btnLimparPedido.TabIndex = 3;
            this.btnLimparPedido.Text = "Limpar Pedido";
            this.btnLimparPedido.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Total:";
            // 
            // btnProcessarPedido
            // 
            this.btnProcessarPedido.BackColor = System.Drawing.Color.OrangeRed;
            this.btnProcessarPedido.FlatAppearance.BorderSize = 0;
            this.btnProcessarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcessarPedido.Location = new System.Drawing.Point(35, 404);
            this.btnProcessarPedido.Name = "btnProcessarPedido";
            this.btnProcessarPedido.Size = new System.Drawing.Size(465, 36);
            this.btnProcessarPedido.TabIndex = 7;
            this.btnProcessarPedido.Text = "Processar Pedido";
            this.btnProcessarPedido.UseVisualStyleBackColor = false;
            this.btnProcessarPedido.Click += new System.EventHandler(this.btnProcessarPedido_Click);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPagamento.Location = new System.Drawing.Point(35, 360);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(102, 21);
            this.lblPagamento.TabIndex = 8;
            this.lblPagamento.Text = "Pagamento:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(143, 324);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(82, 21);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "R$ 200,00";
            // 
            // nmcValorPagamento
            // 
            this.nmcValorPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmcValorPagamento.Location = new System.Drawing.Point(143, 358);
            this.nmcValorPagamento.Name = "nmcValorPagamento";
            this.nmcValorPagamento.Size = new System.Drawing.Size(82, 29);
            this.nmcValorPagamento.TabIndex = 10;
            // 
            // UcPdvPedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nmcValorPagamento);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.btnProcessarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimparPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPedidoCliente);
            this.Name = "UcPdvPedidoCliente";
            this.Size = new System.Drawing.Size(536, 476);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcValorPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPedidoCliente;
        private Panel panel1;
        private Button btnLimparPedido;
        private Label label1;
        private Button btnProcessarPedido;
        private Label lblPagamento;
        private Label lblValorTotal;
        private NumericUpDown nmcValorPagamento;
        private FlowLayoutPanel flwPedidoCliente;
    }
}
