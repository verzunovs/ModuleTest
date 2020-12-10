namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Crocodilia : Reptilia, IEat
    {
        protected Crocodilia(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("This animal eats fuits, seeds, grass or other plant food.");
        }
    }
}
