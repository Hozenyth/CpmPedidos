﻿using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository.Maps
{
    public class PromocaoProdutoMap: BaseDomainMap<PromocaoProduto>
    {
        PromocaoProdutoMap(): base("tb_promocao_produto") { }
       
        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);
        }
    }
}