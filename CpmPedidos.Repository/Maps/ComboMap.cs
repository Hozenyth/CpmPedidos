using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository.Maps
{
    public class ComboMap: BaseDomainMap<Combo>
    {
        ComboMap(): base("tb_combo") { }
       
        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);
        }
    }
}
