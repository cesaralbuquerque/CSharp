namespace AppWinForm
{
    partial class frmDelegacao
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
            this.btnFecharDelegacaoDireta = new System.Windows.Forms.Button();
            this.btnFecharPedidoPorDelegate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFecharDelegacaoDireta
            // 
            this.btnFecharDelegacaoDireta.Location = new System.Drawing.Point(12, 132);
            this.btnFecharDelegacaoDireta.Name = "btnFecharDelegacaoDireta";
            this.btnFecharDelegacaoDireta.Size = new System.Drawing.Size(260, 23);
            this.btnFecharDelegacaoDireta.TabIndex = 0;
            this.btnFecharDelegacaoDireta.Text = "Fechar Pedido com Delegação Direta";
            this.btnFecharDelegacaoDireta.UseVisualStyleBackColor = true;
            this.btnFecharDelegacaoDireta.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFecharPedidoPorDelegate
            // 
            this.btnFecharPedidoPorDelegate.Location = new System.Drawing.Point(12, 180);
            this.btnFecharPedidoPorDelegate.Name = "btnFecharPedidoPorDelegate";
            this.btnFecharPedidoPorDelegate.Size = new System.Drawing.Size(260, 23);
            this.btnFecharPedidoPorDelegate.TabIndex = 1;
            this.btnFecharPedidoPorDelegate.Text = "Fechar Pedido Com Delegação por delegate";
            this.btnFecharPedidoPorDelegate.UseVisualStyleBackColor = true;
            this.btnFecharPedidoPorDelegate.Click += new System.EventHandler(this.btnFecharPedidoPorDelegate_Click);
            // 
            // frmDelegacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFecharPedidoPorDelegate);
            this.Controls.Add(this.btnFecharDelegacaoDireta);
            this.Name = "frmDelegacao";
            this.Text = "Delegacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFecharDelegacaoDireta;
        private System.Windows.Forms.Button btnFecharPedidoPorDelegate;

    }
}

