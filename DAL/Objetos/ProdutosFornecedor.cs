using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace DAL.Objetos
{
    public class ProdutosFornecedor : Infra.MongoBase<DTO.ProdutosFornecedor>
    {

        public static List<DTO.ProdutosFornecedor> BuscarProdutosFornecedor()
        {
            List<DTO.ProdutosFornecedor> produtos = new List<DTO.ProdutosFornecedor>();
            //return Listar("ProdutosFornecedor");
            return criarDadosTeste();
        }


        public static void InserirProdutoFornecedor(DTO.ProdutosFornecedor oObjeto)
        {
            Inserir("ProdutosFornecedor", oObjeto);
        }

        private static List<DTO.ProdutosFornecedor> criarDadosTeste()
        {
            List<DTO.ProdutosFornecedor> produtos = new List<DTO.ProdutosFornecedor>();

            DTO.ProdutosFornecedor produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 3.25;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Leite")).FirstOrDefault();
            
            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "2";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "maria.jpg";
            produtosFornecedor.nomeFornecedor = "Maria da Silva";
            produtosFornecedor.valorFrete = 1.2;
            produtosFornecedor.valorUnitario = 25.99;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Queijo")).FirstOrDefault();

            produtos.Add(produtosFornecedor);


            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "2";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "maria.jpg";
            produtosFornecedor.nomeFornecedor = "Maria da Silva";
            produtosFornecedor.valorFrete = 5;
            produtosFornecedor.valorUnitario = 3.12;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Leite")).FirstOrDefault();

            produtos.Add(produtosFornecedor);



            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 3.19;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Cenoura")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 2.25;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Abobora")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 3.50;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Cebola")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 2.69;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Batata")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "perfil";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 5.60;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Brócolis")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 3.19;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Agrião")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 4.39;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Couve-flor")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 2.15;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Couve")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 4.99;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Beterraba")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 7.89;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Pimentão")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 3.19;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Rúcula")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            produtosFornecedor = new DTO.ProdutosFornecedor();
            produtosFornecedor.Id = "1";
            produtosFornecedor.distancia = "2.5";
            produtosFornecedor.estoque = 10;
            produtosFornecedor.foto = "joao.jpg";
            produtosFornecedor.nomeFornecedor = "João da Silva";
            produtosFornecedor.valorFrete = 10;
            produtosFornecedor.valorUnitario = 1.09;
            produtosFornecedor.produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Alface")).FirstOrDefault();

            produtos.Add(produtosFornecedor);

            return produtos;
        }
    }
}
