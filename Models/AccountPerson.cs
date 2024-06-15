namespace AMST4_Herança
{
    public class AccountPerson : Person
    {
        public AccountPerson(int accountnumber, string accountagency, string accountname, double accountcpf, double accountdeposit, double accountwithdraw)
        {
            NumberAccount = accountnumber;
            Agency = accountagency;
            Name = accountname;
            CPF= accountcpf;
            Deposit = accountdeposit;
            WithDraw = accountwithdraw;          

        }



        public double AccountDeposit { get; set; }
        public double AccountWithDraw { get; set; }
        public override void Balance()
        {
            
            Saldo = (Deposit - WithDraw) * 1.02;
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Número da Conta: {NumberAccount}");
            Console.WriteLine($"Agencia da Conta: {Agency}");
            Console.WriteLine($"Titular: {Name}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Valor do deposito: {Deposit}");
            Console.WriteLine($"Valor do saque: {WithDraw}");
            Console.WriteLine($"Saldo da Conta: {Saldo}");

        }

    }
}