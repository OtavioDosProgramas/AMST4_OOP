using AMST4_Herança;
class Program
{
     static void Main(string[] args)
    {
        AccountPerson personaccount = new AccountPerson(5817, "Nubank", "Otávio", 50778653889, 1000, 500);
        BusingsPerson personbusing = new BusingsPerson(0252, "Santander", "Empresa Programers", 291924258, 1000, 420);

        string? opcao;

        Console.WriteLine($"Bem vindo(a), Deseja ver sua conta Pessoal ou Corporativa? ");
        opcao = Console.ReadLine();

        if (opcao == "Pessoal")
        {
            personaccount.Balance();
            Console.ReadKey();
        }
        else if (opcao == "Corporativa")
        {
            personbusing.Balance();
            Console.ReadKey();
        }
    }
}