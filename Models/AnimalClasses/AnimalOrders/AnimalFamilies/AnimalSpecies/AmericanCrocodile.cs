namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies.AnimalSpecies
{
    using System;
    using HomeWorkForModuleTest.Enums;

    public class AmericanCrocodile : Crocodylidae
    {
        public AmericanCrocodile(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfCrocodylidae typeOfCrocodylidae)
  : base(weight, amountOfFoodRequiredPerDay, age, sex, typeOfCrocodylidae)
        {
        }

        public override string Name => nameof(AmericanCrocodile);

        public override bool IsPregant => this.IsAbleToBePregant();

        public override void LayEggs()
        {
            Console.WriteLine("This animal is ready for lay aeggs.");
        }

        private bool IsAbleToBePregant()
        {
            var rnd = new Random();
            if (this.Sex == Sex.Female)
            {
                switch (rnd.Next(1, 11))
                {
                    case 1:
                        return true;
                    default: return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
