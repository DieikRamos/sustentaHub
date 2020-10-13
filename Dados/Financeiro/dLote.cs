using Objetos.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Financeiro
{
    public class dLote
    {
        public static List<Lote> CarregaLotes(string condicao, bool buscaMovimentos)
        {
            return Lote.carregaLista(condicao, buscaMovimentos);
        }
    }
}
