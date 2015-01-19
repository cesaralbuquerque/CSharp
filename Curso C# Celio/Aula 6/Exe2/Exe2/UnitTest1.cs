using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Compras;

namespace Exe2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComDezPorcento()
        {
            //cenario
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("arroz", 50.00));
            carrinho.adiciona(new Produto("feijao", 20.00));
            carrinho.adiciona(new Produto("atum", 50.00));

            CalculaCompra calcula = new CalculaCompra();

            //acao
            double total = calcula.total(carrinho);

            //validacao
            Assert.AreEqual(108.00, total);

        }

        [TestMethod]
        public void ComVintePorcento()
        {
            //cenario
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("arroz", 50.00));
            carrinho.adiciona(new Produto("feijao", 20.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));

            CalculaCompra calcula = new CalculaCompra();

            //acao
            double total = calcula.total(carrinho);

            //validacao
            Assert.AreEqual(176.00, total);

        }
        [TestMethod]
        public void ComVinteECincoPorcento()
        {
            //cenario
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("arroz", 50.00));
            carrinho.adiciona(new Produto("feijao", 20.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));

            CalculaCompra calcula = new CalculaCompra();

            //acao
            double total = calcula.total(carrinho);

            //validacao
            Assert.AreEqual(240.00, total);

        }

        [TestMethod]
        public void ComTrintaPorcento()
        {
            //cenario
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("arroz", 50.00));
            carrinho.adiciona(new Produto("feijao", 20.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));
            carrinho.adiciona(new Produto("atum", 50.00));

            CalculaCompra calcula = new CalculaCompra();

            //acao
            double total = calcula.total(carrinho);

            //validacao
            Assert.AreEqual(294.00, total);

        }

        [TestMethod]
        public void SemPorcento()
        {
            //cenario
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.adiciona(new Produto("arroz", 50.00));
            carrinho.adiciona(new Produto("feijao", 20.00));
            

            CalculaCompra calcula = new CalculaCompra();

            //acao
            double total = calcula.total(carrinho);

            //validacao
            Assert.AreEqual(70.00, total);

        }
    }
}
