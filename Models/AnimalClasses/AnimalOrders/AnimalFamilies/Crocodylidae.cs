namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Crocodylidae : Reptilia
    {
        private readonly ListOfCrocodylidae typeOfCrocodylidae;

        protected Crocodylidae(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfCrocodylidae typeOfCrocodylidae)
           : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
            this.typeOfCrocodylidae = typeOfCrocodylidae;
        }

        public ListOfCrocodylidae TypeOfCrocodylidae => this.typeOfCrocodylidae;
    }
}
