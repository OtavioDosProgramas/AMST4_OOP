namespace AMST4_Herança
{
    public class BusingsPerson : Person
    {

         public BusingsPerson(int busingsnumber, string busingsagency, string busingsname, double busingscnpj, double busingsdeposit, double busingswithdraw)
         {
            NumberAccount = busingsnumber;
            Agency = busingsagency;
            Name = busingsname;
            CNPJ = busingscnpj;
            Deposit = busingsdeposit;
            WithDraw = busingswithdraw;

         }


        public override void Balance()
        {
            Saldo = (Deposit - WithDraw) * 1.16;

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Numero da Conta: {NumberAccount}");
            Console.WriteLine($"Agencia da Conta: {Agency}");
            Console.WriteLine($"Titular(Empresa): {Name}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Valor do deposito: {Deposit}");
            Console.WriteLine($"Valor do saque: {WithDraw}");
            Console.WriteLine($"Saldo da Conta: {Saldo}");

        }

    }

}