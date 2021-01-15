namespace naNote.CMD
{
    public static class CMDStrings
    {
        public const string Helpnote =
            "Notes are a way to store information in quick way through categories.\n\n" +
            "Example: > note #categoryname note entry goes here\n\n" +
            "You can also interrupt your entry with categories, which will be stripped out later\n" +
            "Example: > note the quick brown #interrupt fox jumped #interrupt over the lazy dog";

        public const string Helpdiary = 
            "Diaries increment each day, and automatically append to the diary from the same day.\n\n" +
            "Example: > diary #categorygoeshere I just had a good coding session!\n\n" +
            "As with notes, categories will be stripped out of your diary entry.\n" +
            "Example: > diary writing is #life life\n" +
            "The above entry will read as 'writing is life' with a category #life";

        public const string Helpreminder = 
            "Reminders are not yet implemented.";

        public const string Helplist = 
            "The list command will list various previously entered values.\n\n" +
            "Example: > list diary\n" +
            "Example: > list note";

        public const string Helpsave= 
            "The save command saves the database to file.\n" +
            "No arguments are expected or considered.";

        public const string Helpload = 
            "The load command loads the database from file.\n" +
            "No arguments are expected or considered.";

        public const string Help = 
            "The help command can return additional details on how to run commands.\n\n" +
            "Example: > help note\n" +
            "Example: > help diary\n\n" +
            "Available commands: Note, Diary, Reminder, List, Save, Load, Help, Exit.";

        public const string CommandNotFound = 
            "Sorry, that command was not recognized.\n" +
            "Press any key to try again.";
    }
}
