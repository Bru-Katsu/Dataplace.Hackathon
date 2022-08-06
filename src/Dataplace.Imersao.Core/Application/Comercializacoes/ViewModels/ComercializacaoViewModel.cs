using Dataplace.Core.Application.ViewModels.Contracts;
using System;

namespace Dataplace.Imersao.Core.Application.Comercializacoes.ViewModels
{
    public class ComercializacaoViewModel : ISelectableViewModel, IEquatable<ComercializacaoViewModel>
    {
        public bool IsSelected { get; set; }

        public string CdComerc { get; set; }
        public decimal PercAcordo { get; set; }
        public decimal PercDiferencaICMS { get; set; }
        public decimal PercDistribuidora { get; set; }
        public decimal PercSemGarantia { get; set; }
        public decimal PercDesconto { get; set; }

        public bool Equals(ComercializacaoViewModel other)
        {
            return CdComerc == other.CdComerc;
        }
    }
}
