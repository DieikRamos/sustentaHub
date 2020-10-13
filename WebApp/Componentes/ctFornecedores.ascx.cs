using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctFornecedores : System.Web.UI.UserControl
    {
        public List<DTO.ProdutosFornecedor> produtos;
        protected void Page_Load(object sender, EventArgs e)
        {
            InicializaComponente();
        }

        private void InicializaComponente()
        {
            foreach (var item in produtos)
            {
                var controleProduto = (WebApp.Componentes.ctFornecedoresProduto)Page.LoadControl("~/Componentes/ctFornecedoresProduto.ascx");
                controleProduto.ProdutosFornecedor = item;
                pnlPedidos.Controls.Add(controleProduto);
            }
        }
    }
}