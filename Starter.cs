namespace HomeWorkForModuleTest
{
    using HomeWorkForModuleTest.Helper;
    using HomeWorkForModuleTest.Services;

    public class Starter
    {
        private readonly ISafariParkService safariParkService;

        public Starter()
        {
            this.safariParkService = new SafariParkService();
        }

        public void Run()
        {
            var safariPark = this.safariParkService.CreateSafariParkSection();
            System.Array.Sort(safariPark.Animals, new AnimalComparer());
            safariPark.Search(4);
            System.Console.WriteLine($"In safari park {safariPark.AmountOfSpecies} species.");
        }
    }
}
