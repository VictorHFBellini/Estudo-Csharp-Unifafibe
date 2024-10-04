using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO_Loja_Brinquedos_II
{
    public class Fabricante
    {
        public string CNPJOTO { get; set; }
        public string Nome { get; set; }

        public string CnpjNome
        {
            get
            {
                return CNPJOTO + " - " + Nome;
            }
        }
    }
}