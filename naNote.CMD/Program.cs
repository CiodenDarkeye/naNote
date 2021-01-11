using System;
using System.Linq;
using Nanote.Logic;
using Nanote.Logic.Data;

namespace Nanote.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Payload for testing
            string payload = "diary #work I've come to a realization last night that I can separate this work out further. #what #is #this #help?";
            string catList;

            Console.WriteLine("Console Application time!");
            Console.WriteLine($"Let's parse: {payload}");

            Catalog catalog = new Catalog(true);
            Parser parsed = new Parser(payload, catalog.categoryList);

            if (parsed.Categories == null)
            {
                catList = "No categories!";
            }
            else
            {
                catList = string.Join(", ", parsed.Categories.Select(x => x.Name));
            }
            

            Console.WriteLine($"Action: {parsed.Action}");
            Console.WriteLine($"Payload: {parsed.Payload}");
            Console.WriteLine($"Categories: {catList}");
            Console.WriteLine($"What does the Parser think? {ActionParser.Select(parsed.Action)}");
        }
    }
}
