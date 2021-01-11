namespace Nanote.Logic.Model
{
    public class Note
    {
        public int Id { get; private set; }
        public Category Category { get; set; }
        public string Entry { get; set; }
        private int id_value = 0;
        public Note()
        {
            Id = id_value;
            id_value++;
        }
    }
}