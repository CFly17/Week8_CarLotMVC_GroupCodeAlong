using System.ComponentModel.DataAnnotations;

namespace Week8_CarLot.Models
{
    public class Carowner
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}