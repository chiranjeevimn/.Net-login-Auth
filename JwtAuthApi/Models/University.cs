using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace JwtAuthApi.Models
{
    public class University
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // Ensures MongoDB stores it as an ObjectId but serializes it as a string
        public string? Id { get; set; }

        [BsonElement("state-province")]
        public string? StateProvince { get; set; }

        [BsonElement("alpha_two_code")]
        public string? AlphaTwoCode { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("domains")]
        public List<string>? Domains { get; set; }

        [BsonElement("web_pages")]
        public List<string>? WebPages { get; set; }

        [BsonElement("country")]
        public string? Country { get; set; }
    }
}
