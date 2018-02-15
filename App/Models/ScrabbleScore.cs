using System;

namespace Application.Models
{
    public static class ScrabbleScore
    {

        private static bool contains(string list, char character)
        {
            char[] characters = list.ToCharArray();
            return Array.IndexOf(characters, character) != -1;
        }

        public static int GetScore(char c)
        {
            c = char.ToLower(c);
            if(contains("aeioulnrst", c))
            {
                return 1;
            } else if(contains("dg", c))
            {
                return 2;
            } else if(contains("bcmp", c))
            {
                return 3;
            } else if(contains("fhvwy", c))
            {
                return 4;
            } else if(contains("k", c))
            {
                return 5;
            } else if(contains("jx", c))
            {
                return 8;
            } else if(contains("qz", c))
            {
                return 10;
            } else {
                return 0;
            }
        }

        public static int GetWordScore(string word)
        {
            return 3;
        }
    }
}
