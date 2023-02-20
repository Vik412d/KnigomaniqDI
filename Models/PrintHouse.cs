namespace Knigomaniq.Models
{
    public class PrintHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}