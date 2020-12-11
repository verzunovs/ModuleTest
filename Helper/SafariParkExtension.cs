namespace HomeWorkForModuleTest.Helper
{
    using HomeWorkForModuleTest.Entities;

    public static class SafariParkExtension
    {
        public static void Search(this SafariPark safariPark, int age)
        {
            for (var i = 0; i < safariPark.Animals.Length; i++)
            {
                if (safariPark.Animals[i].Age == age)
                {
                    System.Console.WriteLine($"This animal exist. It is {safariPark.Animals[i].Name}, {safariPark.Animals[i].Sex}. It is {safariPark.Animals[i].Age} years old.");
                }
            }
        }
    }
}
