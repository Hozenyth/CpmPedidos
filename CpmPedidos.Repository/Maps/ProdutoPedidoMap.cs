﻿using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository.Maps
{
    public class ProdutoPedidoMap: BaseDomainMap<ProdutoPedido>
    {
        ProdutoPedidoMap(): base("tb_produto_pedido") { }
       
        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);
        }
    }
}
