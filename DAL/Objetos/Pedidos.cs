using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objetos
{
    public class Pedidos : Infra.MongoBase<DTO.Pedidos>
    {
        public static List<DTO.Pedidos> BuscarCategorias()
        {
            List<DTO.Pedidos> produtos = new List<DTO.Pedidos>();
            return Listar("Pedidos");
        }
        public static void InserirPedidos(DTO.Pedidos produto)
        {
            Inserir("Pedidos", produto);
        }

        private static List<DTO.Categoria> criarDadosTeste()
        {
            List<DTO.Categoria> produtos = new List<DTO.Categoria>();

            DTO.Categoria categoria = new DTO.Categoria();
            categoria.imagem = "laticinios";
            categoria.nome = "Laticínios";
            produtos.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "vegetais";
            categoria.nome = "Vegetais";
            produtos.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "carnes";
            categoria.nome = "Carnes";
            produtos.Add(categoria);

            categoria = new DTO.Categoria();
            categoria.imagem = "peixes";
            categoria.nome = "Peixes";

            produtos.Add(categoria);

            return produtos;
        }

        public static string GeraBoletos(string valor, string nomecliente)
        {
            var client = new RestClient("https://api-sandbox.getnet.com.br/auth/oauth/v2/token");
            RestRequest request = new RestRequest() { Method = Method.POST };

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");

            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("scope", "oob");

            client.Authenticator = new HttpBasicAuthenticator("717cdcec-975e-4c24-bd0e-2f9de8237091", "1f046144-8626-4f67-9a82-15409e9f88d3");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            IRestResponse response = client.Execute(request);


            string token = JObject.Parse(response.Content)["access_token"].ToString();

            DTO.Pagamentos.Pagamento pagamento = new DTO.Pagamentos.Pagamento();
            pagamento.seller_id = "02e695b9-cf4d-400c-bf68-7eb5c2eb65db";
            pagamento.amount = valor;

            pagamento.order = new DTO.Pagamentos.Order();
            pagamento.order.order_id = "150";

            pagamento.boleto = new DTO.Pagamentos.Boleto();
            pagamento.customer = new DTO.Pagamentos.Customer();
            pagamento.customer.name = nomecliente;
            pagamento.customer.document_type = "CPF";
            pagamento.customer.document_number = "99999999999";
            pagamento.customer.billing_address = new DTO.Pagamentos.BillingAddress();
            pagamento.customer.billing_address.street = "Nações Unidades";
            pagamento.customer.billing_address.number = "105";
            pagamento.customer.billing_address.district = "Centro";
            pagamento.customer.billing_address.city = "Porto Alegre";
            pagamento.customer.billing_address.state = "RS";
            pagamento.customer.billing_address.postal_code = "90020006";

            string json = JsonConvert.SerializeObject(pagamento);

            client = new RestClient("https://api-sandbox.getnet.com.br/v1/payments/boleto");
            request = new RestRequest(Method.POST);

            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("accept", "application/json, text/plain, */*");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", "Bearer " + token);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            response = client.Execute(request);

            string link = JObject.Parse(response.Content)["boleto"]["_links"][0]["href"].ToString();

            return "https://api-sandbox.getnet.com.br" + link;

        }
    }


}
