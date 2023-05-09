using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Models;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    // TODO: Put into service
    private readonly MyDataContext _context;

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
        return _context.Book.FirstOrDefault(b => b.id == id);
    }

    [HttpGet]
    [Route("author/{author}")]
    public IEnumerable<Book>? GetBookByAuthor(String author)
    {
        return _context.Book.Where(b => b.author.ToLower().Contains(author.ToLower())).ToArray();
    }

    // [HttpGet(Name = "GetBook")]
    // public IEnumerable<Book> Get()
    // {
    //     using (var context = new MyDataContext())
    //     {
    //         return context.Book.ToArray();
    //     }
    // }
    //
    // [HttpGet]
    // [Route("id/{id}")]
    // public Book? GetBookById(int id)
    // {
    //     using (var context = new MyDataContext())
    //     {
    //         return context.Book.FirstOrDefault(b => b.id == id);
    //     }
    // }
    //
    // [HttpGet]
    // [Route("author/{author}")]
    // public IEnumerable<Book>? GetBookByAuthor(String author)
    // {
    //     using (var context = new MyDataContext())
    //     {
    //         return context.Book.Where(b => b.author.ToLower().Contains(author.ToLower())).ToArray();
    //     }
    // }
}