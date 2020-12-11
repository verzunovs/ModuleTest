namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies.AnimalSpecies
{
    using System;
    using HomeWorkForModuleTest.Enums;

    public class Cheetah : Felidae
    {
        public Cheetah(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfFelids felids)
           : base(weight, amountOfFoodRequiredPerDay, age, sex, felids)
        {
        }

        public override string Name => nameof(Cheetah);

        public override bool IsPregant => this.IsAbleToBePregant();

        public override void GiveBirth()
        {
            if (this.IsPregant)
            {
                Console.WriteLine("This animal ready to give a birth.");
            }
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
