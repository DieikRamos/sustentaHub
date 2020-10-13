using DTO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pedidos
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string status;
        public string metodoPagamento;
        public double ValorTotal;
        public DateTime dataPedido;
        public DateTime dataEntrega;

        public List<ProdutosFornecedor> produtosPedido;
        
    }
}
