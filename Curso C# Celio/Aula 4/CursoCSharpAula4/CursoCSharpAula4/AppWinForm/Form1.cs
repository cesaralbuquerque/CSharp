using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O botão de Testes foi Clicado");
            
            Button mBotao = new Button { 
                Text = "Clique Aqui", 
                Parent = this, 
                Left = button1.Left, 
                Top = (button1.Top + button1.Height + 10) 
            };
            /*
            mBotao.Click += mBotao_Click;
            
            mBotao.Click += delegate(object s, EventArgs ea)
            {
                MessageBox.Show("O evento foi delegado para um método anonimo.");
            };
            
            mBotao.Click += (s, ea) => MessageBox.Show("O evento foi delegado para uma expressão lambda");
             * */
        }

        void mBotao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O botão clique aqui foi clicado");
        }
    }
}
