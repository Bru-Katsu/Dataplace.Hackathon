using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Application.Comercializacoes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Comercializacoes.Queries
{
    public class ComercializacaoFilterViewModel : IQuery<IEnumerable<ComercializacaoViewModel>>
    {
        public IEnumerable<SortDescriptor> Sortings { get; set; }
    }
}
