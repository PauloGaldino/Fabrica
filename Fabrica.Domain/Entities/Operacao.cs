using System;
using System.Collections.Generic;

namespace Fabrica.Domain.Entities
{
    public partial class Operacao
    {
        public Operacao()
        {
            Pedido = new HashSet<Pedido>();
            Situacao = new HashSet<Situacao>();
        }

        public int OperacaoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
        public ICollection<Situacao> Situacao { get; set; }
    }
}
