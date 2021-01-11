namespace Nanote.Logic.Model
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        private int id_value = 0;

        public Category()
        {
            Id = id_value;
            id_value++;
        }
    }
}