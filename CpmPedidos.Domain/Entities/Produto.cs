

using CpmPedidos.Domain.Interfaces;
using System.Collections.Generic;

namespace CpmPedidos.Domain.Entities
{
    public class Produto : BaseDomain, IExebivel
    {           
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }

        public int CategoriaId { get; set; }
        public virtual CategoriaProduto Categoria { get; set; }

        public virtual List<Combo> Combos { get; set; }
        public virtual List<Imagem> Imagens { get; set; }
        public virtual List<PromocaoProduto> Promocoes { get; set; }
    }
}
