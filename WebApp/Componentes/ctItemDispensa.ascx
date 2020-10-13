<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctItemDispensa.ascx.cs" Inherits="WebApp.Componentes.ctItemDispensa" %>
<a runat="server" id="linkProduto">
    <div class="produtosEstoque row">
        <div class="col-md-2 iconeProdutoEstoque">
            <img runat="server" id="imgProduto" />
        </div>
        <div class="col-md-3 produto-estoque-desc">
            <span class="textoEstoque">
                <asp:Literal runat="server" ID="lblTexto"></asp:Literal></span>
            <br />
            <span class="textoCodigo">COD.
                <asp:Literal runat="server" ID="lblCodigo"></asp:Literal></span>
        </div>
        <div class="col-md-4">
            <span class="uso-semanal">Uso Semanal</span>
            <div class="progress" style="margin-top: 10px;">
                <div class="progress-bar bg-success" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100" id="progBUsoSem" runat="server"></div>
            </div>
            <asp:Label ID="lblQte1" runat="server" CssClass="label-uso"></asp:Label>
        </div>
        <div class="col-md-4">
            <span class="uso-semanal">Uso Mensal</span>
            <div class="progress" style="margin-top: 10px;">
                <div class="progress-bar bg-success" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100" id="progBUsoMes" runat="server"></div>
            </div>
            <asp:Label ID="lblQte2" runat="server" CssClass="label-uso"></asp:Label>
        </div>
    </div>

</a>