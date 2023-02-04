using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AtividadeEncontroRemoto02BackEnd
{
    public class Endereco
    {
        public int TipoEndereco { get; set; }
        public string CFP { get; set; }
        public string Logradouro{ get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

    }
}