namespace PDVSystem
{
    partial class frmPrincipal
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
            this.ucpdv1 = new PDVSystem.Componentes.ucPDV();
            this.SuspendLayout();
            // 
            // ucpdv1
            // 
            this.ucpdv1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucpdv1.BackColor = System.Drawing.Color.LightGray;
            this.ucpdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucpdv1.Location = new System.Drawing.Point(12, 12);
            this.ucpdv1.Name = "ucpdv1";
            this.ucpdv1.Size = new System.Drawing.Size(1081, 479);
            this.ucpdv1.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 504);
            this.Controls.Add(this.ucpdv1);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.ucPDV ucpdv1;
    }
}