using BookWebAPI.Models;

namespace BookWebAPI.Repositories
{
    public interface IBookRepositorie
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int Id);
        Task<Book> Create(Book book);
        Task Update (Book book);
        Task Delete(int Id);
    }
}
