using AppWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void btnTestarMaiorEMenor_Click(object sender, EventArgs e)
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("Liquidificador", 250.0));
            carrinho.adiciona(new Produto("Geladeira", 450.0));
            carrinho.adiciona(new Produto("Jogo de pratos", 70.0));
            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.encontra(carrinho);
            MessageBox.Show("O menor produto: " + algoritmo.Menor.Nome);
            MessageBox.Show("O maior produto: " + algoritmo.Maior.Nome);
        }

        private void btnTestarMaiorEMenorOrdemTrocada_Click(object sender, EventArgs e)
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("Geladeira", 450.0));
            carrinho.adiciona(new Produto("Liquidificador", 250.0));
            carrinho.adiciona(new Produto("Jogo de pratos", 70.0));
            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.encontra(carrinho);
            MessageBox.Show("O menor produto: " + algoritmo.Menor.Nome);
            MessageBox.Show("O maior produto: " + algoritmo.Maior.Nome);

        }

        private void btnTeste1Reflection_Click(object sender, EventArgs e)
        {
            int inteiro = 10; string texto = "Curso C#"; 
            float Flutuante = 10.2f; 
            System.Type Tipo = null; 
            Tipo = inteiro.GetType();

            MessageBox.Show(Tipo.Name);
            MessageBox.Show(texto.GetType().Name);
            MessageBox.Show(Flutuante.GetType().Name);
        }

        private void btnTeste2Reflection_Click(object sender, EventArgs e)
        {
            Humano humano = new Humano();

            foreach (var propriedades  in humano.GetType().GetProperties())
            {
                MessageBox.Show(propriedades.Name);
            }

        }

        private void btnTeste3Reflection_Click(object sender, EventArgs e)
        {
            Humano humano = new Humano { Idade = 39 };

            PropertyInfo pf = humano.GetType().GetProperty("Idade");
            MessageBox.Show("A idade atual é: " + pf.GetValue(humano).ToString());
            pf.SetValue(humano, 50);
            MessageBox.Show("A idade foi modificada para: " + pf.GetValue(humano).ToString());
        }

        private void btnTeste4Reflection_Click(object sender, EventArgs e)
        {
            var humano = Activator.CreateInstance<Humano>();
            humano.Nome = "Fulano";
            MessageBox.Show("Foi criado uma instância de humano de nome: " + humano.Nome);
        }
    }
}
