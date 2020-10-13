<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctCarrinhoProduto.ascx.cs" Inherits="WebApp.Componentes.ctCarrinhoProduto" %>


<div class="row item-carrinho-row">
    <div class="col-md-2 item-carrinho">
        <img runat="server" id="imgProdutos" class="produto-thumbnail" />
    </div>
    <div class="col-md-4 item-carrinho">
        <span class="item">
            <asp:Literal runat="server" ID="lblDescricao" /></span>
        <span class="valor-unitario">
            <asp:Literal runat="server" ID="lblValor" /></span>
    </div>
    <div class="col-md-2 item-carrinho">
        <!--<span>2 Kg</span>-->
        <div class="product-quantity">
            <div class="input-counter">
                <span class="minus-btn">
                    <asp:LinkButton ID="lkbAtualizaQtdeMenos" runat="server" OnClick="lkbAtualizaQtdeMenos_Click"><i class="fa fa-chevron-down"></i></asp:LinkButton>
                </span>
                <input type="text" runat="server" id="inputQuantidade" value="1" disabled="disabled">
                <span class="plus-btn">
                    <asp:LinkButton ID="lkbAtualizaQtdeMais" runat="server" OnClick="lkbAtualizaQtdeMais_Click"><i class="fa fa-chevron-up"></i></asp:LinkButton>
                </span>
            </div>
        </div>
    </div>
    <div class="col-md-3 item-carrinho total-item">
        <span>
            <asp:Literal runat="server" ID="lblValorTotal" /></span>

    </div>
    <div class="col-md-1 item-carrinho total-item">
        <asp:LinkButton runat="server" ID="btnExcluir" OnClick="btnExcluir_Click"><i class="fa fa-trash" aria-hidden="true"></i></asp:LinkButton>
    </div>
</div>
