using System;

namespace CpmPedidos.Domain.Entities
{
    public abstract class BaseDomain
    {
        public int BaseDomainId { get; set; }
        public DateTime CriadoEm { get; set; }       
    }
}
