namespace AppWinForm
{
    partial class Form1
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
            this.btnTestarMaiorEMenor = new System.Windows.Forms.Button();
            this.btnTestarMaiorEMenorOrdemTrocada = new System.Windows.Forms.Button();
            this.btnTeste1Reflection = new System.Windows.Forms.Button();
            this.btnTeste2Reflection = new System.Windows.Forms.Button();
            this.btnTeste3Reflection = new System.Windows.Forms.Button();
            this.btnTeste4Reflection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestarMaiorEMenor
            // 
            this.btnTestarMaiorEMenor.Location = new System.Drawing.Point(12, 12);
            this.btnTestarMaiorEMenor.Name = "btnTestarMaiorEMenor";
            this.btnTestarMaiorEMenor.Size = new System.Drawing.Size(229, 23);
            this.btnTestarMaiorEMenor.TabIndex = 0;
            this.btnTestarMaiorEMenor.Text = "Testar Maior E Menor";
            this.btnTestarMaiorEMenor.UseVisualStyleBackColor = true;
            this.btnTestarMaiorEMenor.Click += new System.EventHandler(this.btnTestarMaiorEMenor_Click);
            // 
            // btnTestarMaiorEMenorOrdemTrocada
            // 
            this.btnTestarMaiorEMenorOrdemTrocada.Location = new System.Drawing.Point(12, 41);
            this.btnTestarMaiorEMenorOrdemTrocada.Name = "btnTestarMaiorEMenorOrdemTrocada";
            this.btnTestarMaiorEMenorOrdemTrocada.Size = new System.Drawing.Size(229, 23);
            this.btnTestarMaiorEMenorOrdemTrocada.TabIndex = 1;
            this.btnTestarMaiorEMenorOrdemTrocada.Text = "Testar Maior E Menor Ordem Trocada";
            this.btnTestarMaiorEMenorOrdemTrocada.UseVisualStyleBackColor = true;
            this.btnTestarMaiorEMenorOrdemTrocada.Click += new System.EventHandler(this.btnTestarMaiorEMenorOrdemTrocada_Click);
            // 
            // btnTeste1Reflection
            // 
            this.btnTeste1Reflection.Location = new System.Drawing.Point(12, 70);
            this.btnTeste1Reflection.Name = "btnTeste1Reflection";
            this.btnTeste1Reflection.Size = new System.Drawing.Size(229, 23);
            this.btnTeste1Reflection.TabIndex = 2;
            this.btnTeste1Reflection.Text = "Teste 1 de  Reflection";
            this.btnTeste1Reflection.UseVisualStyleBackColor = true;
            this.btnTeste1Reflection.Click += new System.EventHandler(this.btnTeste1Reflection_Click);
            // 
            // btnTeste2Reflection
            // 
            this.btnTeste2Reflection.Location = new System.Drawing.Point(12, 99);
            this.btnTeste2Reflection.Name = "btnTeste2Reflection";
            this.btnTeste2Reflection.Size = new System.Drawing.Size(229, 23);
            this.btnTeste2Reflection.TabIndex = 3;
            this.btnTeste2Reflection.Text = "Teste 2 de  Reflection";
            this.btnTeste2Reflection.UseVisualStyleBackColor = true;
            this.btnTeste2Reflection.Click += new System.EventHandler(this.btnTeste2Reflection_Click);
            // 
            // btnTeste3Reflection
            // 
            this.btnTeste3Reflection.Location = new System.Drawing.Point(10, 128);
            this.btnTeste3Reflection.Name = "btnTeste3Reflection";
            this.btnTeste3Reflection.Size = new System.Drawing.Size(229, 23);
            this.btnTeste3Reflection.TabIndex = 4;
            this.btnTeste3Reflection.Text = "Teste 3 de  Reflection";
            this.btnTeste3Reflection.UseVisualStyleBackColor = true;
            this.btnTeste3Reflection.Click += new System.EventHandler(this.btnTeste3Reflection_Click);
            // 
            // btnTeste4Reflection
            // 
            this.btnTeste4Reflection.Location = new System.Drawing.Point(10, 157);
            this.btnTeste4Reflection.Name = "btnTeste4Reflection";
            this.btnTeste4Reflection.Size = new System.Drawing.Size(229, 23);
            this.btnTeste4Reflection.TabIndex = 5;
            this.btnTeste4Reflection.Text = "Teste 4 de  Reflection";
            this.btnTeste4Reflection.UseVisualStyleBackColor = true;
            this.btnTeste4Reflection.Click += new System.EventHandler(this.btnTeste4Reflection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 262);
            this.Controls.Add(this.btnTeste4Reflection);
            this.Controls.Add(this.btnTeste3Reflection);
            this.Controls.Add(this.btnTeste2Reflection);
            this.Controls.Add(this.btnTeste1Reflection);
            this.Controls.Add(this.btnTestarMaiorEMenorOrdemTrocada);
            this.Controls.Add(this.btnTestarMaiorEMenor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestarMaiorEMenor;
        private System.Windows.Forms.Button btnTestarMaiorEMenorOrdemTrocada;
        private System.Windows.Forms.Button btnTeste1Reflection;
        private System.Windows.Forms.Button btnTeste2Reflection;
        private System.Windows.Forms.Button btnTeste3Reflection;
        private System.Windows.Forms.Button btnTeste4Reflection;
    }
}

