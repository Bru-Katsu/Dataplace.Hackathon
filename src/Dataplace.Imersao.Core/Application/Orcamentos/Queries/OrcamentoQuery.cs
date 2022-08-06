using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using Dataplace.Imersao.Core.Domain.Orcamentos.Enums;
using System;
using System.Collections.Generic;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Queries
{
    public class OrcamentoQuery : QuerySort<IEnumerable<OrcamentoViewModel>>, IQuerySort<IEnumerable<OrcamentoViewModel>>
    {
        public string CdCliente { get; set; }
        public OrcamentoStatusEnum? Situacao { get; set; }
        public IList<OrcamentoStatusEnum> SituacaoList { get; set; }

        public TipoPeriodoEnum TipoPeriodo { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }

        public IEnumerable<string> OrigensVenda { get; set; }
        public IEnumerable<string> Vendedores { get; set; }
        public IEnumerable<string> CondicoesPagto { get; set; }
        public IEnumerable<string> Comercializacoes { get; set; }

        public string CdTabela { get; set; }
        public short? SqTabela { get; set; }
    }

    public enum TipoPeriodoEnum
    {
        Abertura,
        PrevisaoFechamento,
        Fechamento,
        Validade
    }
}
