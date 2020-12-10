namespace HomeWorkForModuleTest.Models
{
    using HomeWorkForModuleTest.Enums;

    public abstract class EvenToedUngulate : Mammal
    {
        public EvenToedUngulate(double weight, double amountOfFoodRequiredPerDay, int age, Sex sex, ListOfFelids felids)
           : base(weight, amountOfFoodRequiredPerDay, age, sex)
        {
            this.felids = felids;
        }
}
}
