namespace Nanote.Logic
{
    public static class ActionPicker
    {
        public static string Select(string Action)
        {
            switch (Action.ToLower())
            {
                case "diary":
                    return "diary selected!";
                case "note":
                    return "note selected!";
                case "reminder":
                    return "reminder selected!";
                case "list":
                    return "You want to get a list!";
                default:
                    return "Action not found!";
            }
        }
    }
}
