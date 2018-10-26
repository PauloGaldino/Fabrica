using System;
using System.Collections.Generic;

namespace Fabrica.Domain.Entities
{
    public partial class PessoaTipo
    {
        public PessoaTipo()
        {
            Pessoa = new HashSet<Pessoa>();
        }

        public int PessoaTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoa { get; set; }
    }
}
