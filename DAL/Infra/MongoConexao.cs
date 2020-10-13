using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infra
{
    public class MongoConexao
    {
        private static string url = "mongodb+srv://sustentaHub:k3qa2hrXiUZw6FW@cluster0.3uxzs.gcp.mongodb.net/bancodados?retryWrites=true&w=majority";
        private static string banco = "bancodados";


        public IMongoDatabase dados;

        private static MongoConexao instance;

        private MongoConexao()
        {

            IMongoClient cliente = new MongoClient(url);
            dados = cliente.GetDatabase(banco);
        }

        public static MongoConexao getInstance()
        {

            //if (instance == null)
            //{
                instance = new MongoConexao();
            //}

            return instance;
        }
    }
}
