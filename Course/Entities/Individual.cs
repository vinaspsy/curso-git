﻿namespace Course.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPaid()
        {
            if(AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

        }

    }
}
