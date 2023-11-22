using BlazorApp.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorApp.Models
{

    public class Book : IBook
    {
        
        public ObjectId Id { get; set; }    
        public string _title { get; set; }
        public string _description { get; set; }
        public DateTime _created { get; set; }


        public Book()
        {
            Id = ObjectId.GenerateNewId();
        }
    }
}
