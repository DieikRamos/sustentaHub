using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Paginas
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregaProdutos();
        }

        private void carregaProdutos()
        {
            List<DTO.ProdutosEstoque> produtosEstoque = DAL.Objetos.ProdutosEstoque.BuscarProdutosEstoque();
            pnlItensEstoque.Controls.Clear();
            foreach (var item in produtosEstoque)
            {
                var controleLista = (WebApp.Componentes.ctItemDispensa)Page.LoadControl("~/Componentes/ctItemDispensa.ascx");
                controleLista.produto = item;
                pnlItensEstoque.Controls.Add(controleLista);
            }
        }
    }
}