using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppWinForm.Model;

namespace UnitTestAula6
{
    [TestClass]
    public class ConversorDeNumeroRomanoTest
    {
        [TestMethod]
        public void DeveEntenderOSimboloI()
        {
            //Cenário
            string numeroRomano = "I";
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            //Ação
            int numero = romano.Converte(numeroRomano);
            //Validação
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloV()
        {
            //Cenário
            string numeroRomano = "V";
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            //Ação
            int numero = romano.Converte(numeroRomano);
            //Validação
            Assert.AreEqual(5, numero);
        }
        
        [TestMethod]
        public void DeveEntenderDoisSimbolosComoII()
        {
            //Cenário
            string numeroRomano = "II";
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            //Ação
            int numero = romano.Converte(numeroRomano);
            //Validação
            Assert.AreEqual(2, numero);
        }
    
        [TestMethod]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            //Cenário
            string numeroRomano = "XXII";
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            //Ação
            int numero = romano.Converte(numeroRomano);
            //Validação
            Assert.AreEqual(22, numero);
        }

        [TestMethod]
        public void DeveEntenderNumerosComoIX()
        {
            //Cenário
            string numeroRomano = "IX";
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            //Ação
            int numero = romano.Converte(numeroRomano);
            //Validação
            Assert.AreEqual(9, numero);
        }

        [TestMethod]
        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            //Cenário
            string numeroRomano = "XXIV";
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            //Ação
            int numero = romano.Converte(numeroRomano);
            //Validação
            Assert.AreEqual(24, numero);
        }
    }
}
