using naNote.Logic.Data;
using naNote.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using LoremGenerator;
using System.Diagnostics;
using System.Reflection;

namespace naNote.CMD
{
    internal class CMDActions
    {
        //TODO: Add a tab-completion helper thing here.
        public static string Act(string action, Catalog catalog, HashSet<int> categories, string payload)
        {
            switch (action.ToLower())
            {
                case "diary":
                    catalog.AddDiary(categories, payload);
                    return "diary updated!";

                case "note":
                    catalog.AddNote(categories, payload);
                    return "note added!";

                case "reminder":
                    return "reminder! Not yet implemented though.";

                case "list":
                    // TODO: Can I replace this with a yield return statement instead of using Linq?
                    // Seems like it would be more effective but I'd need to figure it out.

                    var returnTake = 10;
                    var returnSkip = 0;
                    var _catalogList = catalog.ListText(payload);
                    while (true)
                    {
                        foreach (var item in _catalogList.Skip(returnSkip).Take(returnTake))
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Press n to continue, or any other key to return.");
                        if (Console.ReadKey(true).KeyChar != 'n')
                        {
                            return "Returning to main menu.";
                        }
                        returnSkip += returnTake;
                    }

                case "debug":
                    var watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 10000; i++)
                    {
                        Parser _parser = new Parser(Generator.GenerateEntry("note", 2, 10, 2, 10), catalog);
                        catalog.AddNote(_parser.Categories, _parser.Payload);
                    }
                    watch.Stop();
                    return $"Creation of 10,000 notes completed in {watch.ElapsedMilliseconds} ms";

                case "save":
                    Access.Save(catalog);
                    return "Saved!";

                case "load":
                    catalog = Access.Load();
                    return "Load complete!";
                case "quit":
                case "exit":
                    Environment.Exit(0);
                    return "You won't see this!";

                case "help":
                    var type = Type.GetType("naNote.CMD.CMDStrings");
                    var field = type?.GetField("Help"+payload);
                    var value = field?.GetValue(null);
                    if (value != null)
                    {
                        return value.ToString();
                    }
                    else
                    {
                        return CMDStrings.CommandNotFound;
                    }
                    
                default:
                    return CMDStrings.CommandNotFound;
            }
        }
    }
}