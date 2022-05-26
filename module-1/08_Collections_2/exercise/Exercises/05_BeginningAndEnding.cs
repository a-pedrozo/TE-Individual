﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {// will create dictionary and use substring 
            Dictionary<string, string> wordDictionary = new Dictionary<string, string>();

            for (int i = 0; i < words.Length; i++)
            {
                string startOfWord = words[i].Substring(0, 1);

                string endofWord = words[i].Substring(words[i].Length - 1, 1);

                wordDictionary[startOfWord] = endofWord;

            }

            
            



            return wordDictionary;
        }
    }
}
