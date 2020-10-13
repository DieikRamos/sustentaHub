using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctLista : System.Web.UI.UserControl
    {
        public List<Produtos> conteudo;
        public Categoria categoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            InicializaComponente();
        }

        public void InicializaComponente()
        {
            listaProdutos.Attributes.Add("Categoria", categoria.nome);


            listaProdutos.Attributes.Add("style", "display:none;");

            foreach (var item in conteudo)
            {
                var controleProduto = (WebApp.Componentes.ctProdutos)Page.LoadControl("~/Componentes/ctProdutos.ascx");
                controleProduto.produto = item;

                listaProdutos.Controls.Add(controleProduto);
            }
        }
    }
}