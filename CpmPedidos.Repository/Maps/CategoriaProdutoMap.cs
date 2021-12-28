using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository.Maps
{
    public class CategoriaProdutoMap: BaseDomainMap<CategoriaProduto>
    {
        CategoriaProdutoMap(): base("tb_categoria_produto") { }
       
        public override void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            base.Configure(builder);
        }
    }
}
