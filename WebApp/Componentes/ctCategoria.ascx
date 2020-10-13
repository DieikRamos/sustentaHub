<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctCategoria.ascx.cs" Inherits="WebApp.Componentes.ctCategoria" %>

<div class="col-lg-1 col-md-2 coluna-produto" runat="server" id="pnlCategoria" onclick="trocaCategoria(this);">
    <div class="produto top-products-item">
        <div class="products-image">
            <img runat="server" id="imgCategoria" />
        </div>
        <div class="products-content">
            <h3>
                <a href="shop-details.html">
                    <asp:Literal runat="server" ID="lblTitulo"></asp:Literal></a>
            </h3>
        </div>
    </div>
</div>
