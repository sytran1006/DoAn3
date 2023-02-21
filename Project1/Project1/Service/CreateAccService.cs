using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.DatabaseContext;
using Project1.Interface;
using Project1.Models;

namespace Project1.Service
{
    public class CreateAccService : ICreateAccService
    {
        private readonly ReactContext _context;
        public CreateAccService(ReactContext reactContext)
        {
            _context = reactContext;
        }
        public async Task<IEnumerable<CreateAcc>> GetAll()
        {
            return await _context.CreateAcc.ToListAsync();
        }
        public async Task<List<CreateAcc>> Add([FromForm] CreateAcc createacc)
        {
            _context.CreateAcc.Add(createacc);
            await _context.SaveChangesAsync();
            return (await _context.CreateAcc.ToListAsync());

        }
        public async Task<CreateAcc> GetItem(int id)
        {
            return await _context.CreateAcc
                .FirstOrDefaultAsync(n => n.id == id);
        }
    }
}
