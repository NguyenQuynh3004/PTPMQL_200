using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models.Entities
{
    public class Customer
    {
        [Key]
       public string CustomerID { get; set; }
       public string HoTen { get; set; }
       public string QueQuan { get; set; }


    }
}