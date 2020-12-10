namespace HomeWorkForModuleTest
{
    using HomeWorkForModuleTest.Enums;

    public abstract class Animal : ICreature
    {
        private readonly double weight;
        private readonly double amountOfFoodRequiredPerDay;
        private readonly int age;
        private readonly Sex sex;

        protected Animal(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex)
        {
            this.weight = weight;
            this.amountOfFoodRequiredPerDay = amountOfFoodRequiredPerDay;
            this.age = age;
            this.sex = sex;
        }

        public double Weight => this.weight;

        public double AmountOfFoodRequiredPerDay => this.amountOfFoodRequiredPerDay;

        public int Age => this.age;

        public Sex Sex => this.sex;

        public abstract bool IsPregant { get; }
    }
}
