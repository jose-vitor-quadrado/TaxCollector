namespace TaxCollector.Entities
{
    class Company : Customer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Taxes()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            return AnualIncome * 0.16;
        }
    }
}
