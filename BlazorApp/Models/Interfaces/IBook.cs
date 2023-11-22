using MongoDB.Bson;

namespace BlazorApp.Models.Interfaces
{
    public interface IBook
    {
        ObjectId Id { get; set; }
    }
}
