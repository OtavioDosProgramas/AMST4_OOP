namespace AMST4_Herança
{
    public class Person
    {
        public Person() 
        { 
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double CPF { get; set; }
        public double CNPJ { get; set; }
        public string? Agency { get; set; }
        public double WithDraw { get; set; }
        public double Saldo { get; set; }
        public double Deposit { get; set; }
        public int NumberAccount { get; set; }

        public virtual void Balance()
        {
            Saldo = Deposit - WithDraw;
        }

    }
}