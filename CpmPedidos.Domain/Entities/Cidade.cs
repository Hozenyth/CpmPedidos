

using CpmPedidos.Domain.Interfaces;

namespace CpmPedidos.Domain.Entities
{
    public class Cidade : BaseDomain, IExebivel
    {
        public int CidadeId { get; set; }      
        public string Nome { get; set; }
        public string Uf { get; set; }
        public bool Ativo { get; set; }
    }
}
