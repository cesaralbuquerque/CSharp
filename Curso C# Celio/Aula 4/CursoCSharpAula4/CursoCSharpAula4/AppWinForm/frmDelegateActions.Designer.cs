namespace AppWinForm
{
    partial class frmDelegateActions
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
            this.btnAction = new System.Windows.Forms.Button();
            this.btnPredicate = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(60, 93);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(153, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Action<T>";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnPredicate
            // 
            this.btnPredicate.Location = new System.Drawing.Point(60, 133);
            this.btnPredicate.Name = "btnPredicate";
            this.btnPredicate.Size = new System.Drawing.Size(153, 23);
            this.btnPredicate.TabIndex = 1;
            this.btnPredicate.Text = "Predicate<T>";
            this.btnPredicate.UseVisualStyleBackColor = true;
            this.btnPredicate.Click += new System.EventHandler(this.btnPredicate_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(60, 172);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(153, 23);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = "Func<T,TResult>";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // frmDelegateActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnPredicate);
            this.Controls.Add(this.btnAction);
            this.Name = "frmDelegateActions";
            this.Text = "frmDelegateActions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnPredicate;
        private System.Windows.Forms.Button btnFunc;
    }
}