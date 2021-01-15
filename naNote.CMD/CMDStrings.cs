using System.Reflection;

namespace naNote.CMD
{
    public static class CMDStrings
    {
        public const string Helpnote =
            "Notes are a way to store information in quick way through categories.\n\n" +
            "Example: >note #categoryname note entry goes here\n\n" +
            "You can also interrupt your entry with categories, which will be stripped out later\n" +
            "Example: >note the quick brown #interrupt fox jumped #interrupt over the lazy dog";

        public const string Helpdiary = 
            "Diaries increment each day, and automatically append to the diary from the same day.";

        public const string Helpreminder = "";

        public const string Helplist = "";

        public const string Helpsave= "";

        public const string Helpload = "";

        public const string Help = 
            "The help command can return additional details on how to run commands.\n\n" +
            "Example: >help note\n" +
            "Example: >help diary\n\n" +
            "Available commands: Note, Diary, Reminder, List, Save, Load, Help, Exit.";

        public const string CommandNotFound = "Sorry, that command was not recognized.\n" +
            "Press any key to try again.";
    }
}
