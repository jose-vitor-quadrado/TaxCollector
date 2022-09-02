namespace TaxCollector.Entities
{
    class Individual : Customer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if (AnualIncome > 20000.0)
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
            return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
        }
    }
}
