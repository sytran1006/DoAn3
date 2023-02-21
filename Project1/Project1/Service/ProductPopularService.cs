using Microsoft.AspNetCore.Hosting;
using Project1.DatabaseContext;
using Project1.Interface;
using Project1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Project1.Service
{
    public class ProductPopularService : IProductPopularService
    {
        private readonly ReactContext _context;
        public ProductPopularService(ReactContext reactContext)
        {
            _context = reactContext;
        }
        public async Task<IEnumerable<ProductPopular>> GetAll()
        {
            return await _context.ProductPopular.ToListAsync();
        }
        public async Task<ProductPopular> Delete(int id)
        {
            var result = await _context.ProductPopular.FindAsync(id);
            if (result == null)
                return null;

            _context.ProductPopular.Remove(result);
            await _context.SaveChangesAsync();

            return (result);
        }
        public async Task<List<ProductPopular>> Add( ProductPopular productpopular)
        {
            _context.ProductPopular.Add(productpopular);
            await _context.SaveChangesAsync();
            return (await _context.ProductPopular.ToListAsync());

        }
        public async Task<ProductPopular> GetItem(int id)
        {
            return await _context.ProductPopular
                .FirstOrDefaultAsync(n => n.id == id);
        }
        public async Task<ProductPopular> Update([FromForm] ProductPopular productpopular)
        {
            var result = await _context.ProductPopular
                .FirstOrDefaultAsync(n => n.id == productpopular.id);

            if (result != null)
            {
                result.title = productpopular.title;
                result.img = productpopular.img;
                result.color = productpopular.color;
                result.size = productpopular.size;
                result.createdAt = productpopular.createdAt;


                await _context.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
