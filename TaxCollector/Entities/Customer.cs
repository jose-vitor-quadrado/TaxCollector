namespace TaxCollector.Entities
{
    abstract class Customer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Customer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
    }
}
