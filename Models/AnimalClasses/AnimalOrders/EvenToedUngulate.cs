namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders
{
    using HomeWorkForModuleTest.Enums;

    public abstract class EvenToedUngulate : Mammal, IEat
    {
        protected EvenToedUngulate(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("This animal eats garas, fruits, seeds and other plant food.");
        }
    }
}
