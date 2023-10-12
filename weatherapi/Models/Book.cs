using System.ComponentModel.DataAnnotations;

namespace weatherapi.Models
{
    public class Book{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}