using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProdutosEstoque
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public double quantidade;
        public double quantidadeSemanal;
        public double quantidadeMensal;

        public Produtos dadosProduto;
    }
}
