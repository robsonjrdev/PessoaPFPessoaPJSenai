﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEncontroRemoto02BackEnd
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public bool EnderecoComercial { get; set; }

        public void PagarImposto()
        {

        }
    }
}
