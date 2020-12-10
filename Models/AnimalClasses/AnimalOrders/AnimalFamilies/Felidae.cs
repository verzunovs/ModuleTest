namespace HomeWorkForModuleTest.Models
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Felidae : Carnivora
    {
        private readonly ListOfFelids felids;

        protected Felidae(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfFelids felids)
           : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
            this.felids = felids;
        }

        public ListOfFelids Felids => this.felids;
    }
}
