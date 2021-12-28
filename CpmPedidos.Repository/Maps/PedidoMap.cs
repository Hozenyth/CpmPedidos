using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository.Maps
{
    public class PedidoMap: BaseDomainMap<Pedido>
    {
        PedidoMap(): base("tb_pedido") { }
       
        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);
        }
    }
}
