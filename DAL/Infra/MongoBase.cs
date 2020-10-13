using Firebase.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infra
{
    public class MongoBase<Tipo>
    {
        

        public static void Inserir(string colecao, Tipo oObjeto)
        {

            MongoConexao conexao = MongoConexao.getInstance();

            IMongoCollection<Tipo> Lista = conexao.dados.GetCollection<Tipo>(colecao);

            Lista.InsertOne(oObjeto);
        }

        public static List<Tipo> Listar(string colecao)
        {
            MongoConexao conexao = MongoConexao.getInstance();

            IMongoCollection<Tipo> Lista = conexao.dados.GetCollection<Tipo>(colecao);

            return Lista.AsQueryable<Tipo>().ToList();
        }

        public static void Delete(string colecao, Tipo oObjeto)
        {
            
            MongoConexao conexao = MongoConexao.getInstance();
            IMongoCollection<Tipo> Lista = conexao.dados.GetCollection<Tipo>(colecao);
            Expression<Func<Tipo, bool>> filter = x => x.Equals(oObjeto);

            DeleteResult delresult = Lista.DeleteOne(filter);
        }

    }
}
