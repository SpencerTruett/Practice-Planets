using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {

            //Planets and Spaceships Practice
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> lastPlanetsList = new List<string> () { "Uranus", "Neptune" };

            planetList.AddRange (lastPlanetsList);

            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");

            planetList.Add ("Pluto");

            List<string> rockyPlanets = new List<string> (planetList.GetRange (0, 4));

            planetList.Remove ("Pluto");

            foreach (string planets in planetList) {
                Console.WriteLine (planets);
            }

            foreach (string rocks in rockyPlanets) {
                Console.WriteLine (rocks);
            }

            //Random Numbers Practice
            Random random = new Random ();
            List<int> numbers = new List<int> {
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
            };

            for (int i = 0; i < numbers.Count; i++) {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                if (numbers.Contains (i)) {
                    Console.WriteLine ($"number list contains {i}!");
                } else if (!numbers.Contains (i)) {
                    Console.WriteLine ($"number list does not contain {i}!");
                }
            }

        }
    }
}