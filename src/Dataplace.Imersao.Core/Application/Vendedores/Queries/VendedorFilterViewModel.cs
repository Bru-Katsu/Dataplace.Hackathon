using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Application.Vendedores.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Vendedores.Queries
{
    public class VendedorFilterViewModel : IQuery<IEnumerable<VendedorViewModel>>
    {
        public IEnumerable<SortDescriptor> Sortings { get; set; }
    }
}
