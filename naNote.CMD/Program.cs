using System;
using System.Linq;
using Nanote.Logic;
using Nanote.Logic.Data;
using Nanote.Logic.Actions;
using Nanote.Logic.Model;
using System.Collections.Generic;

namespace Nanote.CMD
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
