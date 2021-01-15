using System;
using System.Linq;
using naNote.Logic;
using naNote.Logic.Data;
using naNote.Logic.Model;
using System.Collections.Generic;

namespace naNote.CMD
{
    class Program : CMDActions
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            Console.WriteLine("Console Application time!");
            Console.WriteLine("Enter your commands");
            while (true)
            {
                //Console.Clear();
                Console.Write("> ");
                string payload = Console.ReadLine();
                
                Parser parsed = new Parser(payload, catalog);

                var result = Act(parsed.Action, catalog, parsed.Categories, parsed.Payload);

                Console.WriteLine(result+"\n");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
