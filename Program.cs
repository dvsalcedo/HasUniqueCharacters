using System;

namespace HasUniqueCharacters
{
    class Program
    {
        const int LIMITCHARS = 128; //128 o 256 ASCCI
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Word");
            var sentence = Console.ReadLine();
            System.Console.WriteLine(HasUniqueCharacter(sentence) ? "Has Unique Char" : "Has not Unique Char");
        }

        private static bool HasUniqueCharacter(string sentence){
            bool[] hasValue = new bool[LIMITCHARS]; 
            char[] characters;

            if(sentence.Length > LIMITCHARS) //Exceed the limit, thus we assume that has at least one repeated.
                return false;

            characters = sentence.ToCharArray();

            for (int i = 0; i < sentence.Length; i++)
            {
                if(!hasValue[(int)characters[i]]){
                    hasValue[(int)characters[i]] = true;
                }else{
                    return false;
                }
            }
            return true;
        }
    }   
}
