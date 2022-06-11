using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourseServices.Catalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        ///veri formatını id içi object idye dönüştürür.
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
