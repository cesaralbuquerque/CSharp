using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exe1;

namespace ValidaSalario
{
    [TestClass]
    public class CalculadoraDeSalarioTeste
    {
        [TestMethod]
        public void deveCalcularSalarioDesenvolvedorAcima()
        {
            //cenario
            Empresa geosapiens = new Empresa();
            geosapiens.adicionaFuncionario(new Funcionario("cesar", 3999.00, Funcionario.Cargo.DESENVOLVEDOR));

            CalculadoraDeSalario calculaGeo = new CalculadoraDeSalario();

            //açao
            foreach (Funcionario func in geosapiens.Funcionarios1)
            {
                Assert.AreEqual( 3599.1 ,calculaGeo.calculaSalario(func));
                
            }





        }


        [TestMethod]
        public void deveCalcularSalarioDesenvolvedorAbaixo()
        {
            //cenario
            Funcionario desenvolvedor = new Funcionario("Alan", 2000.00, Funcionario.Cargo.DESENVOLVEDOR);

            CalculadoraDeSalario calcula = new CalculadoraDeSalario();

            //acao
            double salario = calcula.calculaSalario(desenvolvedor);

            //validacao
            Assert.AreEqual(2000.00, salario);

        }



    }
}
