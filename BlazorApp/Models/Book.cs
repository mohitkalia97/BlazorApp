using BlazorApp.Models.Interfaces;
using MongoDB.Bson;

namespace BlazorApp.Models
{

    public class Book : IBook
    {
        public ObjectId _id {  get; set; }
        public string _title { get; set; }
        public string _description { get; set; }
        public DateTime _created;
    }
}
