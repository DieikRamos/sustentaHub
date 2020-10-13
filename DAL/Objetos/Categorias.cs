using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objetos
{
    public class Categorias : Infra.MongoBase<DTO.Categoria>
    {
        public static List<DTO.Categoria> BuscarCategorias()
        {
            
            return criarDadosTeste();
            ///return Listar("Categorias");
        }
        public static void InserirCategorias(DTO.Categoria categoria)
        {
            Inserir("Categorias", categoria);
        }

        private static List<DTO.Categoria> criarDadosTeste() 
        {
            List<DTO.Categoria> categorias = new List<DTO.Categoria>();

            DTO.Categoria categoria = new DTO.Categoria();
            categoria.imagem = "laticinios.jpg";
            categoria.nome = "Laticínios";
            categorias.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "vegetais.jpg";
            categoria.nome = "Vegetais";
            categorias.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "carnes.jpg";
            categoria.nome = "Carnes";
            categorias.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "peixes.jpg";
            categoria.nome = "Peixes";
            categorias.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "moranga.jpg";
            categoria.nome = "Legumes";
            categorias.Add(categoria); 

            return categorias;
        }
    }
}
