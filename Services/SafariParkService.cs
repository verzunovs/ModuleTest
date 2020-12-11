namespace HomeWorkForModuleTest
{
    using System;
    using HomeWorkForModuleTest.Entities;
    using HomeWorkForModuleTest.Enums;
    using HomeWorkForModuleTest.Models.AnimalClasses.AnimalOrders.AnimalFamilies.AnimalSpecies;
    using HomeWorkForModuleTest.Services;

    public class SafariParkService : ISafariParkService
    {
        public SafariPark CreateSafariParkSection()
        {
            var animals = new Animal[]
            {
                new Lion(200, 20, 5, Sex.Female, ListOfFelids.Panthera),
                new Lion(250, 25, 7, Sex.Male, ListOfFelids.Panthera),
                new Alligator(150, 20, 12, Sex.Male, ListOfAlligatoridae.Aligator),
                new AmericanCrocodile(120, 10, 4, Sex.Female, ListOfCrocodylidae.Crocodylus),
                new Cheetah(90, 7, 3, Sex.Male, ListOfFelids.Panthera),
                new JavaMouseDeer(15, 2, 4, Sex.Male, ListOfChevrotain.Hyemoschus),
                new IndianSpottedChevrotain(13, 900, 1, Sex.Female, ListOfChevrotain.Tragulus),
            };

            var amountOfSpecies = 0;
            string[] species = new string[1];
            for (var i = 0; i < animals.Length; i++)
            {
                species[species.Length - 1] = animals[i].Name;
                if (i > 0 && i < animals.Length)
                {
                    if (species[species.Length - 1] == species[species.Length - 2])
                    {
                        species[i] = null;
                    }
                    else
                    {
                        Array.Resize(ref species, species.Length + 1);
                    }
                }
                else
                {
                    Array.Resize(ref species, species.Length + 1);
                }
            }

            amountOfSpecies = species.Length - 1;

            return new SafariPark { Animals = animals, AmountOfSpecies = amountOfSpecies };
        }
    }
}
