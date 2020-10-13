using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Produtos
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string nome;
        public string imagem;
        public string unidade;
        public string tipo;
        public string imagemBanner;

        public Categoria categoria;
        

    }
}
