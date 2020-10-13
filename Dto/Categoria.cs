using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DTO
{
    public class Categoria
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string nome;
        public string imagem;
    }
}
