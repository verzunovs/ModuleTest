namespace HomeWorkForModuleTest.Models
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Carnivora : Mammal, IEat
    {
        public Carnivora(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
            : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("This animal eats meat.");
        }
    }
}
