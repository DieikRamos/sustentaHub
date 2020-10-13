<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctCarrinho.ascx.cs" Inherits="WebApp.Componentes.ctCarrinho" %>
<%@ Register Src="~/Componentes/ctCarrinhoProduto.ascx" TagPrefix="uc1" TagName="ctCarrinhoProduto" %>
<%@ Register Src="~/Componentes/ctCarrinhoRodape.ascx" TagPrefix="uc1" TagName="ctCarrinhoRodape" %>
<%@ Register Src="~/Componentes/ctProdutosPedido.ascx" TagPrefix="uc1" TagName="ctProdutosPedido" %>


<div class="carrinho-notificacao" runat="server" id="pnlCarrinho">
    <div class="row flow-pedidos-lateral">
        <h2>Cesta de Compras</h2>
    </div>
    <!--Topo produtos -->
    <div class="row item-carrinho-row-top">
        <div class="col-md-2 item-carrinho">
        </div>
        <div class="col-md-4 item-carrinho">
            <span class="item">Produto e valor</span>
        </div>
        <div class="col-md-2 item-carrinho qtd">
            <span>Qtd</span>
        </div>
        <div class="col-md-3 item-carrinho total-item">
            <span>Total</span>
        </div>
        <div class="col-md-1 item-carrinho total-item">
            <span>Ação</span>
        </div>
    </div>
    <!-- Fim topo -->

    <div class="col-md-12 item-carrinho" id="carrinhoVzio" runat="server" style="text-align:center; padding:20px 0px;">
        <h5>Sua cesta está vazia!</h5>
    </div>
    <div class="carrinho" runat="server" id="produtosCarrinho">
    </div>

    <div class="row item-carrinho-row-separador">
    </div>

    <uc1:ctCarrinhoRodape runat="server" ID="carrinhoRodape" />
</div>

<div class="carrinho-notificacao" runat="server" visible="false" id="pnlCheckout">
    <div class="row flow-pedidos-lateral">
        <h2>Checkout</h2>
    </div>

    <div class="row checkout">
        <div class="row checkout-item-top">
            <div class="col-md-1 checkout-icone-mapa">
                <i class="fa fa-map-marker-alt" aria-hidden="true"></i>
            </div>
            <div class="col-md-9">
                <span class="checkout-endereco-label">Endereço Entrega</span>
                <span class="checkout-endereco">Av. Pernambuco, 1483 - São Geraldo - Porto Alegre - RS, 90240-004</span>
            </div>
            <div class="col-md-2 checkout-icone-editar">
                <i class="fa fa-pencil-alt" aria-hidden="true"></i>
            </div>
        </div>
        <div class="row checkout-item">
            <div class="col-md-1">
                <span class="checkout-pagamento-label"></span>
            </div>
            <div class="col-md-9">
                <span class="checkout-pagamento-label">Método de Pagamento</span>
            </div>
            <div class="col-md-2 checkout-icone-editar-pgto">
                <i class="fa fa-pencil-alt" aria-hidden="true"></i>
            </div>
        </div>
        <div class="row checkout-item-pagamento">
            <div class="col-md-1 checkout-radio">
                <input type="radio" class="form-control" />
            </div>
            <div class="col-md-1">
                <i class="fa fa-credit-card" aria-hidden="true"></i>
            </div>
            <div class="col-md-8">
                <span class="checkout-produto-cartao-credito">Cartão de Crédito</span>
            </div>
        </div>
        <div class="row checkout-item-pagamento">
            <div class="col-md-1 checkout-radio">
                <input type="radio" class="form-control" />
            </div>
            <div class="col-md-1">
                <i class="fa fa-barcode" aria-hidden="true"></i>
            </div>
            <div class="col-md-8">
                <span class="checkout-produto-cartao-credito">Boleto</span>
            </div>
        </div>
        <div class="row checkout-item checkout-fornecedor-titulo">
            <div class="col-md-1">
                <span class="checkout-pagamento-label"></span>
            </div>
            <div class="col-md-9">
                <span class="checkout-pagamento-label">Fornecedor</span>
            </div>
            <div class="col-md-2 checkout-icone-editar-pgto">
            </div>
        </div>
        <div class="row checkout-item">
            <div class="col-md-1">
            </div>
            <div class="col-md-2">
                <img src="../Resources/images/profile-image.jpg" class="profile-thumbnail" />
            </div>
            <div class="col-md-7 checkout-fornecedor-labels">
                <span class="checkout-fornecedor-nome">João Pedro da Silva</span>
                <span class="checkout-fornecedor-doc">CPF: 123.456.789.01</span>
                <span class="checkout-fornecedor-fone">Telefone: (51) 9 9999 9999</span>
            </div>
            <div class="col-md-2 checkout-icone-editar-pgto">
                <i class="fa fa-phone" aria-hidden="true"></i>
            </div>
        </div>
        <div class="row checkout-item checkout-fornecedor-titulo">
            <div class="col-md-1">
                <span class="checkout-pagamento-label"></span>
            </div>
            <div class="col-md-9">
                <span class="checkout-pagamento-label">Descrição</span>
            </div>
            <div class="col-md-2 checkout-icone-editar-pgto">
            </div>
        </div>
        <div class="row checkout-item-top-desc" runat="server" id="produtosPedido">
        </div>
        <div class="row checkout-item">
            <div class="col-md-1">
            </div>
            <div class="col-md-7 checkout-produtos-labels">
                <span class="checkout-valor-final-label">Valor Final</span>
                <span class="checkout-produto-valor">(Taxa de Entrega <asp:Literal runat="server" ID="lblFrete"></asp:Literal>)</span>
            </div>
            <div class="col-md-4 checkout-produtos-valores">
                <span class="checkout-valor-final-label">
                    <asp:Literal runat="server" ID="lblFinal"></asp:Literal></span>
            </div>
        </div>
        <div class="row checkout-item">
            <div class="form-finalizar">
                <asp:Button ID="btnFinalizar" runat="server" CssClass="form-control btn btn-danger mb-2 cesta" Text="Finalizar Compra" OnClick="btnFinalizar_Click" />
            </div>
        </div>
    </div>
</div>
