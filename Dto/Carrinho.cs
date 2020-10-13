using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Carrinho
    {
        
        public List<ProdutosCarrinho> itensCarrinho;

        public Carrinho() 
        {
            itensCarrinho = new List<ProdutosCarrinho>();
        }
        public double getTotalItens()
        {
            double total = 0;
            foreach (var item in itensCarrinho)
            {
                total = total + item.quantidade * item.dadosItem.valorUnitario;
            }
            return total;
        }


        public double getFrete()
        {
            string idFornecedorAnt = "";
            double total = 0;
            foreach (var item in itensCarrinho)
            {
                if(idFornecedorAnt != item.dadosItem.Id)
                {
                    //total = total + item.quantidade * item.dadosItem.valorFrete;
                    total = total + item.dadosItem.valorFrete;                    
                }
                idFornecedorAnt = item.dadosItem.Id;

            }

            return total;
        }
    }
}