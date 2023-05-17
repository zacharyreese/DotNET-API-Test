using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Models;

[Table("book")]
public class Book
{
    [Key]
    public int Id { get; set; }
    
    public string? Name { get; set; }
    public string? Author { get; set; }
    public decimal Price { get; set; }
    public int? NumberOfChapters { get; set; }
}