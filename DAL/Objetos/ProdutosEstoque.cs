using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace DAL.Objetos
{
    public class ProdutosEstoque : Infra.MongoBase<DTO.ProdutosEstoque>
    {

        public static List<DTO.ProdutosEstoque> BuscarProdutosEstoque()
        {
            List<DTO.ProdutosEstoque> produtos = new List<DTO.ProdutosEstoque>();
            //return Listar("ProdutosEstoque");
            return criarDadosTeste();
        }

        public static void InserirProdutoEstoque(DTO.ProdutosEstoque oObjeto)
        {
            Inserir("ProdutosEstoque", oObjeto);
        }

        private static List<DTO.ProdutosEstoque> criarDadosTeste()
        {
            List<DTO.ProdutosEstoque> produtos = new List<DTO.ProdutosEstoque>();

            DTO.ProdutosEstoque produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Leite")).FirstOrDefault();
            produto.quantidade = 10;
            produto.quantidadeMensal = 30;
            produto.quantidadeSemanal = 7;
            
            produtos.Add(produto);

            produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Queijo")).FirstOrDefault();
            produto.quantidade = 8;
            produto.quantidadeMensal = 80;
            produto.quantidadeSemanal = 20;

            produtos.Add(produto);


            produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Cenoura")).FirstOrDefault();
            produto.quantidade = 5;
            produto.quantidadeMensal = 40;
            produto.quantidadeSemanal = 10;

            produtos.Add(produto);

            produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Batata")).FirstOrDefault();
            produto.quantidade = 40;
            produto.quantidadeMensal = 70;
            produto.quantidadeSemanal = 20;

            produtos.Add(produto);

            produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Alface")).FirstOrDefault();
            produto.quantidade = 1;
            produto.quantidadeMensal = 40;
            produto.quantidadeSemanal = 8;

            produtos.Add(produto);

            produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Cebola")).FirstOrDefault();
            produto.quantidade = 7;
            produto.quantidadeMensal = 50;
            produto.quantidadeSemanal = 10;

            produtos.Add(produto);

            produto = new DTO.ProdutosEstoque();
            produto.dadosProduto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.nome.Equals("Chuchu")).FirstOrDefault();
            produto.quantidade = 10;
            produto.quantidadeMensal = 30;
            produto.quantidadeSemanal = 5;

            produtos.Add(produto);


            return produtos;
        }
    }
}
