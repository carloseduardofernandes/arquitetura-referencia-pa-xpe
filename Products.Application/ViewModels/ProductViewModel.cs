using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.ViewModels
{
    internal class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
