using System;
using System.Linq;
using Nanote.Logic;
using Nanote.Logic.Data;
using Nanote.Logic.Actions;
using Nanote.Logic.Model;
using System.Collections.Generic;

namespace Nanote.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Payload for testing
            string payload;
            string catList;

            Console.WriteLine("Console Application time!");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter your commands");
                Console.Write(">");
                payload = Console.ReadLine();
                Console.WriteLine($"Let's parse: {payload}");

                Catalog catalog = new Catalog(true);
                Parser parsed = new Parser(payload, catalog);

                var result = Act(parsed.Action, catalog, parsed.Categories, payload);

                if (parsed.Categories == null)
                {
                    catList = "No categories!";
                }
                else
                {
                    catList = string.Join(", ", parsed.Categories.Select(x => x.Name));
                }

                Console.WriteLine(result);
                //Console.WriteLine($"Action: {parsed.Action}");
                //Console.WriteLine($"Payload: {parsed.Payload}");
                //Console.WriteLine($"Categories: {catList}");
                //Console.WriteLine("Press any key to continue.");

                Console.ReadKey();
            }
        }

        public static string Act(string Action, Catalog catalog, List<Category> categories, string payload)
        {
            switch (Action.ToLower())
            {
                case "diary":
                    DiaryActions.AddDiary(catalog, categories, payload);
                    return "diary updated!";
                case "note":
                    return "note selected! Not yet implemented though.";
                case "reminder":
                    return "reminder! Not yet implemented though.";
                case "list":
                    return ListActions.List(catalog, payload).ToString();
                default:
                    return "Action not found!";
            }
        }



    }
}
