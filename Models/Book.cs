using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Knigomaniq.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public int PrintHouseId { get; set; }
        public PrintHouse PrintHouses { get; set; }

        public string Cover { get; set; }
        public string Language { get; set; }

        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        public string Stoke { get; set; }
        public string ShortExplenation { get; set; }
        public string Picture { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SinglePrice { get; set; }
        public int DateOFBookInrolled { get; set; }
        public ICollection<Shopping> Shoppings { get; set; }
    }
}
