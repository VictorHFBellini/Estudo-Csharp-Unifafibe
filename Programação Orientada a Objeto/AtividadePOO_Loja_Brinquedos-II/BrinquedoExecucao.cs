using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO_Loja_Brinquedos_II
{
    public class BrinquedoExecucao
    {
        private List<Brinquedo>
            listaBrinquedos = new List<Brinquedo>();

        public void Adicionar(Brinquedo brinquedo)
        {
            listaBrinquedos.Add(brinquedo);
        }

        public void Remover(Brinquedo brinquedo)
        {
            listaBrinquedos.Remove(brinquedo);
        }

        public List<Brinquedo> ListarBrinquedos()
        {
            return listaBrinquedos;
        }
    }
}
