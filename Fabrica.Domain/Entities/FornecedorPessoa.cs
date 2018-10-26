using System;
using System.Collections.Generic;

namespace Fabrica.Domain.Entities
{
    public partial class FornecedorPessoa
    {
        public int FornecedorPessoaId { get; set; }

        public Pessoa FornecedorPessoaNavigation { get; set; }
    }
}
