namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies.AnimalSpecies
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Alligatoridae : Reptilia
    {
        private readonly ListOfAlligatoridae typeOfAlligatoridae;

        protected Alligatoridae(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfAlligatoridae typeOfAlligatoridae)
           : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
            this.typeOfAlligatoridae = typeOfAlligatoridae;
        }

        public ListOfAlligatoridae TypeOfAlligatoridae => this.typeOfAlligatoridae;
    }
}
