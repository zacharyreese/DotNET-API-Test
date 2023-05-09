using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Models;

[Table("book")]
public class Book
{
    [Key]
    public int id { get; set; }
    
    public string name { get; set; }
    public string author { get; set; }
    public decimal price { get; set; }
}