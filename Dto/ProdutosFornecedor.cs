using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProdutosFornecedor
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public Produtos produto;

        public string nomeFornecedor;
        public string foto;
        public string distancia;
        public double valorFrete;
        public double estoque;
        public double valorUnitario;
    }
}
