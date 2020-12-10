namespace HomeWorkForModuleTest.Models
{
    using System;
    using HomeWorkForModuleTest.Enums;

    public class Lion : Felidae
    {
        private readonly int id;

        public Lion(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfFelids felids, int id)
           : base(weight, amountOfFoodRequiredPerDay, age, sex, felids)
        {
            this.id = id;
        }

        public int Id => this.id;

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
