

using CpmPedidos.Domain.Interfaces;

namespace CpmPedidos.Domain.Entities
{
    public class CategoriaProduto : BaseDomain, IExebivel
    {            
        public string Nome { get; set; }     
        public bool Ativo { get; set; }
    }
}
