using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Application.CondicaoPagamento.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.CondicaoPagamento.Queries
{
    public class CondicaoPagamentoFilterViewModel : IQuery<IEnumerable<CondicaoPagamentoViewModel>>
    {
        public IEnumerable<SortDescriptor> Sortings { get; set; }
    }
}
