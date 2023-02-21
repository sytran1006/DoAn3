using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Interface
{
    public interface IListProductService
    {
        Task<IEnumerable<ListProduct>> GetAll();
        Task<ListProduct> GetItem(int id);
        Task<List<ListProduct>> Add(ListProduct listproduct);
        Task<ListProduct> Update([FromForm] ListProduct listproduct);
        Task<ListProduct> Delete(int Id);
    }
}
