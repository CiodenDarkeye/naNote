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
            Catalog catalog = new Catalog();

            Console.WriteLine("Console Application time!");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter your commands");
                Console.Write(">");
                payload = Console.ReadLine();
                
                Parser parsed = new Parser(payload, catalog);

                var result = Act(parsed.Action, catalog, parsed.Categories, parsed.Payload);

                Console.WriteLine(result);
                Console.WriteLine("Press any key to continue!");

                Console.ReadKey();
            }
        }

        public static string Act(string Action, Catalog catalog, List<int> categories, string payload)
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
                case "save":
                    Access.Save(catalog);
                    return "Saved!";
                default:
                    return "Action not found!";
            }
        }



    }
}
