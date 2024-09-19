using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class Person
    {
        [Key]
       public int PersonId { get; set; }
       public string  Fullname { get; set; }

       public string Address { get; set; }

       
    }
}