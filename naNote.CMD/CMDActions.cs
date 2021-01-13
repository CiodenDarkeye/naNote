using Nanote.Logic.Actions;
using Nanote.Logic.Data;
using System.Collections.Generic;

namespace Nanote.CMD
{
    internal class CMDActions
    {
        public static string Act(string Action, Catalog catalog, List<int> categories, string payload)
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
                    return ListActions.List(catalog, payload).ToString();
                case "save":
                    Access.Save(catalog);
                    return "Saved!";
                case "load":
                    catalog = Access.Load();
                    return "Load complete!";
                default:
                    return "Action not found!";
            }
        }
    }
}