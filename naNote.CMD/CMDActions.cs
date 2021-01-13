using Nanote.Logic.Actions;
using Nanote.Logic.Data;
using System;
using System.Collections.Generic;

namespace Nanote.CMD
{
    internal class CMDActions
    {
        public static string Act(string Action, Catalog catalog, HashSet<int> categories, string payload)
        {
            switch (Action.ToLower())
            {
                case "diary":
                    DiaryActions.AddDiary(catalog, categories, payload);
                    return "diary updated!";
                case "note":
                    NoteActions.AddNote(catalog, categories, payload);
                    return "note added!";
                case "reminder":
                    return "reminder! Not yet implemented though.";
                case "list":
                    var retString = "";
                    foreach (var entry in ListActions.List(catalog, payload))
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
                case "exit":
                    Environment.Exit(0);
                    return "You won't see this!";
                default:
                    return "Action not found!";
            }
        }
    }
}