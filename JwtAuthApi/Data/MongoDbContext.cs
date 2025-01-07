using JwtAuthApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;

namespace JwtAuthApi.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("JwtAuthDbColl");
        public IMongoCollection<University> Universities => _database.GetCollection<University>("USA");

        // Method to get all universities
        public List<University> GetAllUniversities()
        {
            return Universities.Find(university => true).ToList();
        }
    }

    public class MongoDbSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
    }
}
