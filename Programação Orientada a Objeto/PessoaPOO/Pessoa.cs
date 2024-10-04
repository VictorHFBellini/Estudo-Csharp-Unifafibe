using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaPOO
{
    // Primeiro passo tornar a Classe Publica
    public class Pessoa
    {
        // Definir atributos
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }

        public string CPFNome
        {
            get
            {
                return CPF + " - " + Nome;
            }
        }

        // Atributo para retornar a idade
        public int Idade
        {
            get
            {
                // Recuperar a data atual 
                DateTime dtAtual = DateTime.Now;
                int Idade = dtAtual.Year - DtNascimento.Year;

                if(dtAtual.Month < DtNascimento.Month ||
                    (dtAtual.Month == DtNascimento.Month &&
                    dtAtual.Day < DtNascimento.Day))
                {
                    Idade--;
                }

                return Idade;
            }
        }
    }
}
