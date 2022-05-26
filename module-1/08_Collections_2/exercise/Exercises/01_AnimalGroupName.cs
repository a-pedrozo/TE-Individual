﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "Herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         * will encounter many errors
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalGroups = new Dictionary<string, string>();
            animalGroups["rhino"] = "Crash";
            animalGroups["giraffe"] = "Tower";
            animalGroups["elephant"] = "Herd";
            animalGroups["lion"] = "Pride";
            animalGroups["crow"] = "Murder";
            animalGroups["pigeon"] = "Kit";
            animalGroups["flamingo"] = "Pat";
            animalGroups["deer"] = "Herd";
            animalGroups["dog"] = "Pack";
            animalGroups["crocodile"] = "Float";



            if (animalName == null || animalName == "")
            {
                return "unknown";
            }
            else
            {
                if (animalGroups.ContainsKey(animalName.ToLower()))
                    return animalGroups[animalName.ToLower()];
                else
                {
                    return "unknown";
                }
            }


        }
    }
}
