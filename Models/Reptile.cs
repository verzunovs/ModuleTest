namespace HomeWorkForModuleTest.Models
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Reptile : Animal
    {
        public Reptile(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
        }

        public abstract void LayEggs(bool isPregant);
    }
}
