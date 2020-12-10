namespace HomeWorkForModuleTest
{
    using HomeWorkForModuleTest.Enums;

    public interface ICreature
    {
        int Age { get; }

        double Weight { get; }

        double AmountOfFoodRequiredPerDay { get; }

        Sex Sex { get; }
    }
}
