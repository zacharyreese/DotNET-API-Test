using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Models;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    //TODO: Put into service
    private readonly MyDataContext _context;
    
    // Data instance used for DB calls, disposed after each request
    public BookController(MyDataContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetBook")]
    public IEnumerable<Book> Get()
    {
        return _context.Book.ToArray();
    }
    
    [HttpGet]
    [Route("id/{id}")]
    public Book? GetBookById(int id)
    {
        return _context.Book.FirstOrDefault(b => b.Id == id);
    }
    
    [HttpGet]
    [Route("author/{author}")]
    public IEnumerable<Book>? GetBookByAuthor(String author)
    {
        return _context.Book
            .Where(b => b.Author.ToLower().Contains(author.ToLower()))
            .ToArray();
    }

    
}