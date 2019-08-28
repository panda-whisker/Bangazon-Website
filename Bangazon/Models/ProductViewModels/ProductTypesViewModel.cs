using System.Collections.Generic;
using Bangazon.Models;

namespace Bangazon.Models.ProductTypeViewModel
{
    internal class ProductTypesViewModel
    {
        public ProductTypesViewModel()
        {
        }

        public List<GroupedProducts> GroupedProducts { get; internal set; }
    }
}