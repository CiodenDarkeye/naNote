namespace Nanote.Logic.Model
{
    public class Diary
    {
        public int Id { get; private set; }
        public Category Category { get; set; }
        public string Entry { get; set; }
        private int id_value = 0;
        public Diary()
        {
            Id = id_value;
            id_value++;
        }
    }
}