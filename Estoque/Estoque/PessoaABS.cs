﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
       abstract class PessoaABS
    {
        protected int codigo;
        protected string nome;
        protected string email;
        protected Endereco endereco;


        //Definindo propriedade Get e Set.
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        internal Endereco Endereco { get => endereco; set => endereco = value; }

      



    }
}
