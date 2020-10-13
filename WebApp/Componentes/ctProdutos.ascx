<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctProdutos.ascx.cs" Inherits="WebApp.Componentes.ctProdutos" %>

<div class="col-lg-1 col-md-2 coluna-produto">
    <div class="produto top-products-item">
        <div class="products-image">
            <a runat="server" id="linkProduto" >
                <img runat="server" id="imgProduto" alt="image"></a>
        </div>
        <div class="products-content">
            <h3>
                <a href="shop-details.html">
                    <asp:Literal runat="server" ID="lblTitulo"></asp:Literal></a>
            </h3>
            <div class="price" style="display: none;">
                Estoque: <span class="new-price">
                    <asp:Literal runat="server" ID="lblEstoque" />
                    / Estoque Ideal:
                    <asp:Literal runat="server" ID="lblEstoqueIdeal" /></span>
            </div>
        </div>


    </div>

</div>
