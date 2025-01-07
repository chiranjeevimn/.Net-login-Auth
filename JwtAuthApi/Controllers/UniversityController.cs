using JwtAuthApi.Data;
using JwtAuthApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace JwtAuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public UniversityController(MongoDbContext context)
        {
            _context = context;
        }

        // GET api/university/universities
        [HttpGet("universities")]
        [Authorize]
        public List<University> GetAllUniversities()
        {
            // Use _context.Universities to get the collection
            return _context.Universities.Find(university => true).ToList();
        }
    }
}
