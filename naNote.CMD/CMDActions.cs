using naNote.Logic.Data;
using System;
using System.Collections.Generic;
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
                    var retString = "";
                    foreach (var entry in catalog.ListText(action))
                    {
                        retString += entry;
                    }
                    return retString;

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