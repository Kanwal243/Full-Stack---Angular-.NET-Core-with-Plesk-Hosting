using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Plesk.Model
{
    public class InsertRecordRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        [Required]
        [BsonElement("Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public double Salary { get; set; }
    }
    public class InsertRecordResponse {
        public bool Issuccess { get; set; }
        public string Message { get; set; }
    }
}
