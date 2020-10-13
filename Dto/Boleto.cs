using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Pagamentos
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Order
    {
        public string order_id { get; set; }
    }

    public class Boleto
    {
    }

    public class BillingAddress
    {
        public string street { get; set; }
        public string number { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
    }

    public class Customer
    {
        public string name { get; set; }
        public string document_type { get; set; }
        public string document_number { get; set; }
        public BillingAddress billing_address { get; set; }
    }

    public class Pagamento
    {
        public string seller_id { get; set; }
        public string amount { get; set; }
        public Order order { get; set; }
        public Boleto boleto { get; set; }
        public Customer customer { get; set; }
    }


}
