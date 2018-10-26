using System;
using System.Collections.Generic;

namespace Fabrica.Domain.Entities
{
    public partial class Preco
    {
        public int ProdutoId { get; set; }
        public decimal Preco1 { get; set; }

        public Produto Produto { get; set; }
    }
}
