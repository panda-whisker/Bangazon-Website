using Bangazon.Models;
using System.Collections.Generic;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class ProductTypesViewModel
    {
        public IEnumerable<GroupedProducts> GroupedProducts { get; set; }
    }
}