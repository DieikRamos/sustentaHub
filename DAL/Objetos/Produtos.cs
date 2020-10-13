using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace DAL.Objetos
{
    public class Produtos : Infra.MongoBase<DTO.Produtos>
    {

        public static List<DTO.Produtos> BuscarProdutos()
        {
            List<DTO.Produtos> produtos = new List<DTO.Produtos>();
            //return Listar("Produtos");
            return criarDadosTeste();

        }
        public static void InserirProduto(DTO.Produtos produto)
        {
            Inserir("Produtos", produto);
        }

        private static List<DTO.Produtos> criarDadosTeste()
        {
            List<DTO.Produtos> produtos = new List<DTO.Produtos>();

            DTO.Produtos produtos1 = new DTO.Produtos();
            produtos1.imagem = "laticinios.jpg";
            produtos1.imagemBanner = "bannerLeite.jpg";
            produtos1.nome = "Leite";
            produtos1.tipo = "Desnatado";
            produtos1.unidade = "Litros";
            produtos1.Id = "123323124234";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Laticínios")).FirstOrDefault();
            
            produtos.Add(produtos1);
            
            produtos1 = new DTO.Produtos();
            produtos1.imagem = "queijo.jpg";
            produtos1.imagemBanner = "bannerQueijo.jpg";
            produtos1.nome = "Queijo";
            produtos1.tipo = "Suiço";
            produtos1.unidade = "Kg";
            produtos1.Id = "2321321312";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Laticínios")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "batata.jpg";
            produtos1.imagemBanner = "bannerBatata.jpg";
            produtos1.tipo = "Rosa";
            produtos1.nome = "Batata";
            produtos1.unidade = "Kg";
            produtos1.Id = "4545454545";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Legumes")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "cebola.jpg";
            produtos1.imagemBanner = "bannerCebola.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Cebola";
            produtos1.unidade = "Kg";
            produtos1.Id = "5454545454";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Legumes")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "beterraba.jpg";
            produtos1.imagemBanner = "bannerBeterraba.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Beterraba";
            produtos1.unidade = "Kg";
            produtos1.Id = "1010124548";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Legumes")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "chuchu.jpg";
            produtos1.imagemBanner = "bannerChuchu.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Chuchu";
            produtos1.unidade = "Kg";
            produtos1.Id = "1010124549";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Legumes")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "abobora.jpg";
            produtos1.imagemBanner = "bannerAbobora.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Abobora";
            produtos1.unidade = "Kg";
            produtos1.Id = "1010124800";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Legumes")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "couve-flor.jpg";
            produtos1.imagemBanner = "bannerCouve-flor.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Couve-flor";
            produtos1.unidade = "Kg";
            produtos1.Id = "1010124550";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "alface.jpg";
            produtos1.imagemBanner = "bannerAlface.jpg";
            produtos1.tipo = "Americana";
            produtos1.nome = "Alface";
            produtos1.unidade = "Un";
            produtos1.Id = "1010124551";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "couve.jpg";
            produtos1.imagemBanner = "bannerCouve.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Couve";
            produtos1.unidade = "Un";
            produtos1.Id = "1010124552";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "espinafre.jpg";
            produtos1.imagemBanner = "bannerEspinafre.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Espinafre";
            produtos1.unidade = "Un";
            produtos1.Id = "1010124553";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "pepino-japones.jpg";
            produtos1.imagemBanner = "bannerPepino-japones.jpg";
            produtos1.tipo = "Japones";
            produtos1.nome = "Pepino";
            produtos1.unidade = "Un";
            produtos1.Id = "1010124554";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "rucula.jpg";
            produtos1.imagemBanner = "bannerRucula.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Rúcula";
            produtos1.unidade = "Un";
            produtos1.Id = "1010124555";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "cenoura.jpg";
            produtos1.imagemBanner = "bannerCenoura.jpg";
            produtos1.tipo = "Comum";
            produtos1.nome = "Cenoura";
            produtos1.unidade = "Kg";
            produtos1.Id = "34342353543";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Legumes")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "brocolis.jpg";
            produtos1.imagemBanner = "bannerBrocolis.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Brócolis";
            produtos1.unidade = "Kg";
            produtos1.Id = "34342353901";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "repolho.jpg";
            produtos1.imagemBanner = "bannerRepolho.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Repolho";
            produtos1.unidade = "Kg";
            produtos1.Id = "34342353902";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "Agriao.jpg";
            produtos1.imagemBanner = "bannerAgriao.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Agrião";
            produtos1.unidade = "Un";
            produtos1.Id = "34342353903";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);

            produtos1 = new DTO.Produtos();
            produtos1.imagem = "pimentao.jpg";
            produtos1.imagemBanner = "bannerPimentao.jpg";
            produtos1.tipo = "";
            produtos1.nome = "Pimentão";
            produtos1.unidade = "Kg";
            produtos1.Id = "34342353904";
            produtos1.categoria = DAL.Objetos.Categorias.BuscarCategorias().Where(x => x.nome.Equals("Vegetais")).FirstOrDefault();

            produtos.Add(produtos1);


            return produtos;
        }
    }
}
