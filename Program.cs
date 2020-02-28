using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
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
        }
    }
}