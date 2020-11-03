namespace SingleReposibilityPrinciple
{
    public class ReglasDelNegocio
    {
        public double ObtenerBalanceADeducir(double balance)
        {
            if (balance < 500) return 100;
            return 0;
        }
        
        public double AbonarSiHaceDepositoGrande(double deposito)
        {
            if (deposito > 500) return 100;
            return 0;
        }
    }
}