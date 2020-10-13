using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Paginas
{
    public partial class Itens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          
            carregaCategorias();

        }


        private void carregaCategorias()
        {



            List<DTO.Categoria> listaCategorias = DAL.Objetos.Categorias.BuscarCategorias();
            List<DTO.Produtos> produtos = DAL.Objetos.Produtos.BuscarProdutos();
            
            pnlCategorias.Controls.Clear();
            divConteudo.Controls.Clear();

            foreach (var categoria in listaCategorias)
            {
                var controle = (WebApp.Componentes.ctCategoria)Page.LoadControl("~/Componentes/ctCategoria.ascx");

                controle.categoria = categoria;

                pnlCategorias.Controls.Add(controle);

                var controleLista = (WebApp.Componentes.ctLista)Page.LoadControl("~/Componentes/ctLista.ascx");

                controleLista.Attributes.Add("Categoria", categoria.nome);

                controleLista.categoria = categoria;
                controleLista.conteudo = produtos.Where(x => x.categoria.nome.Equals(categoria.nome)).ToList();
                
                divConteudo.Controls.Add(controleLista);
            }

        }




    }
}