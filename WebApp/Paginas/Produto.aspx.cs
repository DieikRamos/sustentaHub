using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Paginas
{
    public partial class Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
            {
                DTO.Produtos produto = DAL.Objetos.Produtos.BuscarProdutos().Where(x => x.Id.Equals(Request.QueryString["Id"])).FirstOrDefault();

                lblTipo.Text = produto.tipo;
                lblTitulo.Text = produto.nome;
                lblCodigo.Text = produto.Id;

                detallhesProduto.Attributes.Add("style", "background-image:url('../Resources/images/" + produto.imagemBanner + "');");
            }
            else
            {
                Response.Redirect("./Dashboard.aspx");
            }

            if (Request.QueryString["Loja"] != null)
            {
                var controleLista = (WebApp.Componentes.ctFornecedores)Page.LoadControl("~/Componentes/ctFornecedores.ascx");

                if (DAL.Objetos.ProdutosFornecedor.BuscarProdutosFornecedor().Where(x => x.produto.Id.Equals(Request.QueryString["Id"])) != null)
                {
                    controleLista.produtos = DAL.Objetos.ProdutosFornecedor.BuscarProdutosFornecedor().Where(x => x.produto.Id.Equals(Request.QueryString["Id"])).ToList();
                }

                pnlHistoricos.Controls.Add(controleLista);

            }
            else
            {
                var controleLista = (WebApp.Componentes.ctHistoricoPedidos)Page.LoadControl("~/Componentes/ctHistoricoPedidos.ascx");

                pnlHistoricos.Controls.Add(controleLista);
                divComprar.Visible = true;

            }


        }

        protected void btnComprarProduto_Click(object sender, EventArgs e)
        {
            string url = "/Paginas//Produto.aspx?Id=" + lblCodigo.Text + "&Loja=S";
            Response.Redirect(url);
        }
    }
}