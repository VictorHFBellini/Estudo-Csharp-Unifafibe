using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO_Loja_Brinquedos_II
{
    public class Produto
    {
        public string Cod_Barras { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public Fabricante Fabricante { get; set; }

        public string CodDesc
        {
            get
            {
                return Cod_Barras + " - " + Descricao;
            }
        }
    }
}
