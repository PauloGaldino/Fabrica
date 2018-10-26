using System;
using System.Collections.Generic;

namespace Fabrica.Domain.Entities
{
    public partial class ClientePessoa
    {
        public int ClientePessoaId { get; set; }
        public DateTime DataCadatro { get; set; }

        public Pessoa ClientePessoaNavigation { get; set; }
    }
}
