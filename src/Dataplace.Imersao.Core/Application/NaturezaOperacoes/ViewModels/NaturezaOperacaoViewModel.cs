using Dataplace.Core.Application.ViewModels.Contracts;
using System;

namespace Dataplace.Imersao.Core.Domain.NaturezaOperacoes.ViewModels
{
    public class NaturezaOperacaoViewModel : ISelectableViewModel, IEquatable<NaturezaOperacaoViewModel>
    {
        public bool IsSelected { get; set; }

        public string CdNatOperacao { get; set; }
        public string Descricao { get; set; }
        public string Descricao2 { get; set; }

        public char StEntradaSaida { get; set; }
        public char StGeraDDFinanceiro { get; set; }
        public char StUpdEstoque { get; set; }

        public bool Equals(NaturezaOperacaoViewModel other)
        {
            return CdNatOperacao == other.CdNatOperacao;
        }
    }
}
