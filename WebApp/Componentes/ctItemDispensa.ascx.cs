using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctItemDispensa : System.Web.UI.UserControl
    {

        public DTO.ProdutosEstoque produto;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = produto.dadosProduto.Id;
            lblTexto.Text = produto.dadosProduto.nome;
            imgProduto.Src = "../Resources/images/" + produto.dadosProduto.imagem;
            linkProduto.HRef = "../Paginas/Produto.aspx?Id=" + produto.dadosProduto.Id;
            progBUsoSem.Attributes.Add("style","width:" + produto.quantidadeSemanal.ToString() + "%");
            lblQte1.Text = produto.quantidade.ToString() + " " + produto.dadosProduto.unidade + " / " + produto.quantidadeSemanal.ToString() + " " + produto.dadosProduto.unidade;
            progBUsoMes.Attributes.Add("style", "width:" + produto.quantidadeMensal.ToString() + "%");
            lblQte2.Text = produto.quantidade.ToString() + " " + produto.dadosProduto.unidade + " / " + produto.quantidadeMensal.ToString() + " " + produto.dadosProduto.unidade;
        }
    }
}