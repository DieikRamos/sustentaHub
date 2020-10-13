function salvaCookie(nome, valor, expira) {//expira em minutos    
    $.cookie(nome, valor, {
        expires: expira,
        path: '/',
        secure: false
    });
}

document.addEventListener('ScriptsCarregados', function (e) {

    barraLateral();

    $(":input").inputmask();

    $('select').selectpicker();

});

function barraLateral() {
    $(".sidebar-dropdown > a").click(function () {
        $(".sidebar-submenu").slideUp(200);
        if (
            $(this)
                .parent()
                .hasClass("active")
        ) {
            $(".sidebar-dropdown").removeClass("active");
            $(this)
                .parent()
                .removeClass("active");
        } else {
            $(".sidebar-dropdown").removeClass("active");
            $(this)
                .next(".sidebar-submenu")
                .slideDown(200);
            $(this)
                .parent()
                .addClass("active");
        }
    });

    $("#close-sidebar").click(function () {
        $(".page-wrapper").removeClass("toggled");
    });
    $("#show-sidebar").click(function () {
        $(".page-wrapper").addClass("toggled");
    });
}

//document.addEventListener('ScriptsCarregados', function (e) {
//    $("table").DataTable({ "scrollX": true, scrollY: "400px", "searching": false });
//}, false);


function trocaAba(element, id) {
    Swal.fire({
        title: 'Carregando',
        timer: 1000,
        timerProgressBar: true,
        onBeforeOpen: () => {
            Swal.showLoading()
        }
    });
    setTimeout(function () { $("table").DataTable().columns.adjust().draw(); }, 500);
}

function inicializaTabela(listagem, scrollX, scrollY) {
    var elementos = $("#" + listagem + " > table > thead > tr > th[tamanho]");

    var columnDefs = [];

    for (var i = 0; i < elementos.length; i++) {
        var tamCol = elementos[i].getAttribute("tamanho");
        var coluna = { "width": tamCol, "targets": i };
        columnDefs[i] = coluna;
    }

    var atributosTabela = { "searching": false, "lengthChange": false, "scrollX": scrollX, "scrollY": scrollY, "columnDefs": columnDefs };

    $("#" + listagem + " > table").DataTable(atributosTabela);
    //$("#listagem").DataTable({ "scrollX": true, scrollY: "500px", "columnDefs": [{ 'width': '10%', 'targets': 0 }, { 'width': '25%', 'targets': 1 }, { 'width': '10%', 'targets': 2 }, { 'width': 80, 'targets': 3 }, { 'width': 100, 'targets': 4 }, { 'width': 100, 'targets': 5 }, { 'width': '10%', 'targets': 6 }] });
}

function trocaCategoria(element) {

    $('[id*="_listaProdutos"]').hide();
    $('[id*="_listaProdutos"][categoria="' + element.attributes.categoria.value + '"]').show();

    location.href = "#" + element.attributes.categoria.value;
}



function mostraPainel(nome, element) {

    if (nome == "pedidos-notificacao") {
        $('[class="carrinho-notificacao"]').hide();
        $('[class="pedidos-notificacao"]').show();
           
    }
    else {
        $('[class="pedidos-notificacao"]').hide();
        $('[class="carrinho-notificacao"]').show();
    }


    $('[class*="div-icone-notif ativa"]').removeClass("ativa");
    $(element).addClass("ativa")

    
}

function validaCategoria()
{
    var aba = location.href.split("#")[1];
    $('[id*="_listaProdutos"]').hide();
    $('[id*="_listaProdutos"][categoria="' + aba + '"]').show();
    
}


function adicionarCarrinho(produto) {
    $('[class="action-invisivel"][produto="' + produto + '"]').click();
}