namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies.AnimalSpecies
{
    using System;
    using HomeWorkForModuleTest.Enums;

    public class Alligator : Alligatoridae
    {
        public Alligator(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfAlligatoridae typeOfAlligatoridae)
   : base(weight, amountOfFoodRequiredPerDay, age, sex, typeOfAlligatoridae)
        {
        }

        public string Name => nameof(Alligator);

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
