using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsCollection = new WordsCollection();
            wordsCollection.AddItem("First");
            wordsCollection.AddItem("Seccond");
            wordsCollection.AddItem("Third");

            Console.WriteLine("Traverse collection");

            foreach (var word in wordsCollection)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Reverse traversal");

            wordsCollection.ReverseDirection();

            foreach (var word in wordsCollection)
            {
                Console.WriteLine(word);
            }
        }
    }
}
