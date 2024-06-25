using HeppssiAPi.Application.Bases;
using HeppssiAPi.Application.Features.Products.Exceptions;
using HeppssiAPi.Domain.Entities;

namespace HeppssiAPi.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x => x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}