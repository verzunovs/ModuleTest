namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Chevrotain : EvenToedUngulate
    {
        private readonly ListOfChevrotain typeOfChevrotain;

        protected Chevrotain(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfChevrotain typeOfChevrotain)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
            this.typeOfChevrotain = typeOfChevrotain;
        }

        public ListOfChevrotain TypeOfChevrotain => this.typeOfChevrotain;
    }
}
