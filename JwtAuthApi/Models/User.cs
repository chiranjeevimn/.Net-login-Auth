using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JwtAuthApi.Models
{
    public class User
    {
        [BsonId] // Marks this property as the MongoDB document ID
        [BsonRepresentation(BsonType.String)] // Treat ID as a string instead of ObjectId
        public string? Id { get; set; } // Allows custom string IDs

        [BsonElement("Username")]
        public string? Username { get; set; }

        [BsonElement("Password")]
        public string? Password { get; set; }
    }
}
