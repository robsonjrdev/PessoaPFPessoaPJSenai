using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEncontroRemoto02BackEnd
{
    public class PessoaJuridica : Pessoa
    {
        private string? _CNPJ;
        public int? IdPessoaJuridica { get; set; }
        public string? CNPJ { get;  set;}
        
        public string? RazaoSocial { get; set; }

        public override void PagarImposto(float salario)
        {

        }
        public bool ValidarCNPJ(string cnpj)
        {
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length -6, 4) == "0001") {

                return true;

            } else {

                return false;
                
            }
        }
    }
}
