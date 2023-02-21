using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.DatabaseContext;
using Project1.Interface;
using Project1.Models;

namespace Project1.Service
{
    public class ListProductService : IListProductService
    {
        private readonly ReactContext _context;
        public ListProductService(ReactContext reactContext)
        {
            _context = reactContext;
        }
        public async Task<IEnumerable<ListProduct>> GetAll()
        {
            return await _context.ListProducts.ToListAsync();
        }
        public async Task<ListProduct> Delete(int id)
        {
            var result = await _context.ListProducts.FindAsync(id);
            if (result == null)
                return null;

            _context.ListProducts.Remove(result);
            await _context.SaveChangesAsync();

            return (result);
        }
        public async Task<List<ListProduct>> Add(ListProduct listproduct)
        {
            _context.ListProducts.Add(listproduct);
            await _context.SaveChangesAsync();
            return (await _context.ListProducts.ToListAsync());

        }
        public async Task<ListProduct> GetItem(int id)
        {
            return await _context.ListProducts
                .FirstOrDefaultAsync(n => n.id == id);
        }
        public async Task<ListProduct> Update([FromForm] ListProduct listproduct)
        {
            var result = await _context.ListProducts
                .FirstOrDefaultAsync(n => n.id == listproduct.id);

            if (result != null)
            {
                result.title = listproduct.title;
                result.img = listproduct.img;
                result.color = listproduct.color;
                result.size = listproduct.size;
                result.createdAt = listproduct.createdAt;
                result.price = listproduct.price;
                result.category = listproduct.category;

                await _context.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
