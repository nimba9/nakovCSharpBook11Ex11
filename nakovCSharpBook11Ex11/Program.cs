using System;

namespace RandomSentencesTask11
{
    public class RandomSentencesTask11
    {
        public static void Main(string[] args)
        {
            GenerateRandPhrase();
        }

        public static void GenerateRandPhrase()
        {
            string[] phrase = { "Great product", "Perfect product", "I use this product all the time", "The best product ever" };
            string[] thingsHappened = { "I feel good now", "I've changed myself", "It has done a miracle", "You should try too" };
            string[] firstName = { "Michail", "Oleg", "Ivan", "Vladimir", "Maxim" };
            string[] lastName = { "Tarasov", "Kaminskij", "Stroganov", "Molotov" };
            string[] city = { "Samara", "Tolyatti", "Vladivostok" };

            Random rndPhraseGen = new Random();
            int rndPhrase = rndPhraseGen.Next(0, phrase.Length);
            int rndHappened = rndPhraseGen.Next(0, thingsHappened.Length);
            int rndFirstName = rndPhraseGen.Next(0, firstName.Length);
            int rndlastName = rndPhraseGen.Next(0, lastName.Length);
            int rndCity = rndPhraseGen.Next(0, city.Length);
            Console.WriteLine("{0}.{1}--{2} {3},{4}", phrase[rndPhrase], thingsHappened[rndHappened], firstName[rndFirstName], lastName[rndlastName], city[rndCity]);

        }
    }
}
