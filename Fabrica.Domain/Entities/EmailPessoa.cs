﻿using System;
using System.Collections.Generic;

namespace Fabrica.Domain.Entities
{
    public partial class EmailPessoa
    {
        public int EmailPessoaId { get; set; }
        public string EnderecoEmail { get; set; }

        public Pessoa EmailPessoaNavigation { get; set; }
    }
}
