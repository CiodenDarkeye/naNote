namespace Nanote.Logic.Model
{
    public class Category : BaseEntry
    {
        private static int id_value = 0;
        public string Name { get; set; }

        public int Id { get; private set; }

        public Category()
        {
            Id = id_value;
            id_value++;
        }
    }
}