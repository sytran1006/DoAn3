using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Interface
{
    public interface ICreateAccService
    {
        Task<IEnumerable<CreateAcc>> GetAll();
        Task<CreateAcc> GetItem(int id);
        Task<List<CreateAcc>> Add([FromForm] CreateAcc createacc);
    }
}
