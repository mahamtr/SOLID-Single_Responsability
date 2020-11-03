namespace SingleReposibilityPrinciple
{
    public class CuentaBancaria
    {
        public double Balance { get;  private set; }
        public ReglasDelNegocio ReglasDelNegocio { get; set; }
        public CuentaBancaria(double balance)
        {
            Balance = balance;
            ReglasDelNegocio = new ReglasDelNegocio();
            
        }

        public double Retirar(double valorARetirar)
        {
            Balance -= valorARetirar;
            Balance -= ReglasDelNegocio.ObtenerBalanceADeducir(Balance);
            return Balance;
        }
        
        public double Depositar(double valorADepositar)
        {
            Balance += valorADepositar;
            Balance += ReglasDelNegocio.AbonarSiHaceDepositoGrande(valorADepositar);
            return Balance;
        }

  
        
    }
}