using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppWinForm.Model;

namespace UnitTestAula6
{
    [TestClass]
    public class MaiorEMenorTest
    {
        [TestMethod]
        public void OrdemDecrescente()
        {
            //Cenário
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("Geladeira", 450.0));
            carrinho.adiciona(new Produto("Liquidificador", 250.0));
            carrinho.adiciona(new Produto("Jogo de pratos", 70.0));
            MaiorEMenor algoritmo = new MaiorEMenor();
            
            //Ação
            algoritmo.encontra(carrinho);

            //Validação
            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);

        }
    }
}
