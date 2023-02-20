namespace Knigomaniq.Models
{
    public class Shopping
    {
        public int UserId { get; set; }
        public User Users { get; set; }
        public int Book { get; set; }
        public Book Books { get; set; }
    }
}
