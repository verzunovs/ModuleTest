namespace HomeWorkForModuleTest.Models
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Mammal : Animal
    {
        protected Mammal(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
        }

        public abstract void GiveBirth();
    }
}
