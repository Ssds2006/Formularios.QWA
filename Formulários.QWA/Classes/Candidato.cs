using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulários.QWA.Classes
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string DtNascimento { get; set; }

        public Candidato(string Nome, string Sobrenome, string CPF, string DtNascimento) 
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.CPF = CPF;
            this.DtNascimento = DtNascimento;
        }

        public Candidato() { }
    }
}
