using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Domain.NaturezaOperacoes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.NaturezaOperacoes.Queries
{
    public class NaturezaOperacaoFilterViewModel : IQuery<IEnumerable<NaturezaOperacaoViewModel>>
    {
        public IEnumerable<SortDescriptor> Sortings { get; set; }
    }
}
