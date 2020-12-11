namespace HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies.AnimalSpecies
{
    using System;
    using HomeWorkForModuleTest.Enums;

    public class IndianSpottedChevrotain : Chevrotain
    {
        public IndianSpottedChevrotain(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfChevrotain typeOfChevrotain)
            : base(weight, amountOfFoodRequiredPerDay, age, sex, typeOfChevrotain)
        {
        }

        public string Name => nameof(IndianSpottedChevrotain);

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
