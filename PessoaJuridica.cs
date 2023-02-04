using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEncontroRemoto02BackEnd
{
    public class PessoaJuridica : Pessoa
    {
        public int? IdPessoaJuridica { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }

        public override void PagarImposto(float salario)
        {

        }
    }
}
