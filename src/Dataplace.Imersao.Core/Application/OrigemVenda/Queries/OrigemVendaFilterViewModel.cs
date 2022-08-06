using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Domain.OrigemVenda.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.OrigemVenda.Queries
{
    public class OrigemVendaFilterViewModel : IQuery<IEnumerable<OrigemVendaViewModel>>
    {
        public IEnumerable<SortDescriptor> Sortings { get; set; }
    }
}
