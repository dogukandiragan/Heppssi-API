﻿using MediatR;
using HeppssiAPi.Application.Interfaces.RedisCache;

namespace HeppssiAPi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllProducts";

        public double CacheTime => 60;
    }
}


 