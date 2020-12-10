namespace HomeWorkForModuleTest.Models
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Reptilia : Animal
    {
        public Reptilia(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
        }

        public abstract void LayEggs();
    }
}
