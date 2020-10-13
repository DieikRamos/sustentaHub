<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApp.Paginas.Dashboard" %>

<%@ Register Src="~/Componentes/ctItemDispensa.ascx" TagPrefix="uc1" TagName="ctItemDispensa" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style>
        .barra-pesquisa {
            display: none !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Corpo" runat="server">
    <!-- Fim icones categorias -->
    <div class="row conteudo-central prod-destaque">
        <h4>Dashboard
        </h4>
    </div>
    <div class="dashboard-quadro">
        <div class="row" style="padding-left: 20px; padding-top: 20px;">
            <div class="col-md-12">
                <span class="dashboard-titulo">Status geral da dispensa</span>
            </div>
        </div>
        <div class="row" style="padding-left: 20px; padding-top: 20px; height: 270px;">
            <div class="col-md-4 dashboard-quadro-pequeno">
                <div class="row dashboard-header">
                    <div class="col-md-12">
                        <h1 class="dashboard-titulo-pequeno">Produtos Acabando</h1>
                    </div>
                </div>
                <div class="row dashboard-line">
                    <div class="col-md-3">
                        <span class="dashboard-texto-grande">12</span>
                    </div>
                    <div class="col-md-9">
                        <h1 class="dashboard-texto-pequeno">Produtos com estoque 25% abaixo do uso semanal definido.</h1>
                    </div>
                </div>
                <div class="row dashboard-line-2">
                    <div class="col-md-3">
                        <span class="dashboard-texto-grande">10</span>
                    </div>
                    <div class="col-md-9">
                        <h1 class="dashboard-texto-pequeno">dos 12 produto não possuem compra automática ativada.</h1>
                    </div>
                </div>
            </div>
            <div class="col-md-4 dashboard-quadro-pequeno">
                <div class="row dashboard-header">
                    <div class="col-md-12">
                        <h1 class="dashboard-titulo-pequeno">Produtos próximos ao vencimento</h1>
                    </div>
                </div>
                <div class="row dashboard-line">
                    <div class="col-md-3">
                        <span class="dashboard-texto-grande">03</span>
                    </div>
                    <div class="col-md-9">
                        <h1 class="dashboard-texto-pequeno">Produtos coma  data de validade se aproximando. Dê prioridade de uso para evitar desperdícios.</h1>
                    </div>
                </div>
                <div class="row dashboard-line-2 ">
                    <div class="col-md-9">
                        <h1 class="dashboard-texto-pequeno">Confira o relatório de validade para saber mais sobre o estado de outros produtos.</h1>
                    </div>
                    <div class="col-md-3 alinharCentro">
                        <a href="#" class="dashboard-link"><i class="fa fa-arrow-right"></i></a>
                    </div>
                </div>
            </div>
            <div class="col-md-3 dashboard-quadro-pequeno">
                <div class="row dashboard-header">
                    <div class="col-md-12">
                        <h1 class="dashboard-titulo-pequeno">Verificar compras programadas</h1>
                    </div>
                </div>
                <div class="row dashboard-line" style="border: none;">
                    <div class="col-md-12" style="padding-right: 43px;">
                        <h1 class="dashboard-texto-pequeno" style="padding-top: 10px;">Para evitar compras desnecessárias, confirme as compras automáticas programadas para a próxima semana.</h1>
                    </div>
                </div>
                <div class="row dashboard-line-2 alinharCentro">
                    <div class="col-md-12">
                        <a href="#" class="dashboard-link" style="float: right; background: #3461FF;"><i class="fa fa-arrow-right"></i></a>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-8 float-right" style="display: inherit;">
            <div class="input-group mb-3" style="padding-top: 20px;">
                <i class="fas fa-search" style="position: absolute; top: 35px; color: #706D6D; font-size: 25px; left: 11px;"></i>
                <input type="text" placeholder="Busque por um produto" class="botaoPesquisa" aria-label="Busque por um produto">
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12" style="margin-left: 15px;padding-right: 40px;" runat="server" id="pnlItensEstoque">
            
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Lateral" runat="server">
</asp:Content>
