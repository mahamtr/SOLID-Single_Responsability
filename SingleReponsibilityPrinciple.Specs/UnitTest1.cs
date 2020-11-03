using NUnit.Framework;
using SingleReposibilityPrinciple;

namespace SingleReponsibilityPrinciple.Specs
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        
        }

        [Test]
        public void DeberiaRestarBalanceAlRetirar()
        {
            //arrange
            var valorInicial = 600.0;
            var valorARetirar = 50.0;
            var cuenta = new CuentaBancaria(valorInicial);
            
            //act
            cuenta.Retirar(valorARetirar);

            //assert
            Assert.AreEqual(cuenta.Balance,valorInicial - valorARetirar);
        }
        

        

        [Test]
        public void DeberiaSumarBalanceAlDepositar()
        {
            //arrange
            var valorInicial = 500.0;
            var valorADepositar = 50.0;
            var cuenta = new CuentaBancaria(valorInicial);
            
            //act
            cuenta.Depositar(valorADepositar);

            //assert
            Assert.AreEqual(cuenta.Balance,valorInicial + (valorADepositar));
        }
        
        [Test]
        public void DeberiaAbonarSiDepositoEsGrande()
        {
            //arrange
            var valorInicial = 500.0;
            var valorADepositar = 600.0;
            var cuenta = new CuentaBancaria(valorInicial);
            
            //act
            cuenta.Depositar(valorADepositar);
        
            //assert
            Assert.AreEqual(cuenta.Balance,valorInicial + (valorADepositar + 100));
        }
        
        [Test]
        public void DeberiaDeducirCuandoBalanceFinalEsMenorAlMinimo()
        {
            //arrange
            var valorInicial = 500.0;
            var valorARetirar = 50.0;
            var cuenta = new CuentaBancaria(valorInicial);
            
            //act
            cuenta.Retirar(valorARetirar);
        
            //assert
            Assert.AreEqual(cuenta.Balance,valorInicial - (valorARetirar + 100));
        }

    }
}