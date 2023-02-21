using Microsoft.AspNetCore.Mvc;
using Project1.Models;
namespace Project1.Interface
{
    public interface IProductPopularService
    {
        Task<IEnumerable<ProductPopular>> GetAll();
        Task<ProductPopular> GetItem(int id);
        Task<List<ProductPopular>> Add( ProductPopular productpopular);
        Task<ProductPopular> Update([FromForm] ProductPopular productpopular);
        Task<ProductPopular> Delete(int Id);
        //Task<string> Upload([FromForm] imgAnouncement obj);
    }
}
