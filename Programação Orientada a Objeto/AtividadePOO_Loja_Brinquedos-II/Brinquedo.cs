using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO_Loja_Brinquedos_II
{
    public class Brinquedo
    {
        public Produto Produto { get; set; }
        public string Categoria { get; set; }
        public string IdadeMinima { get; set; }

        public string CodDescCat
        {
            get
            {
                return Produto.Cod_Barras + " - " + Produto.Descricao +
                    " - " + Categoria;
            }
        }

        public string CodDescCatFabri
        {
            get
            {
                return CodDescCat + " - " + Produto.Fabricante.Nome;
            }
        }
    }
}