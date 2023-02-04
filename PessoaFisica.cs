using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEncontroRemoto02BackEnd
{
    public class PessoaFisica : Pessoa
    {
        public int? IdPessoalFisica { get; set; }
        public string? CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public override void PagarImposto(float salario)
        {

        }
        public bool VerificarDataNascimento(DateTime dataNascimento) 
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            if (anos >= 18) {
                return true;
            } else {
                return false;
            }
                
        }
    }
}
