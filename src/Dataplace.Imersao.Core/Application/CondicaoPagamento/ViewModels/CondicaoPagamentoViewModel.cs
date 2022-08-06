using Dataplace.Core.Application.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.CondicaoPagamento.ViewModels
{
    public class CondicaoPagamentoViewModel : ISelectableViewModel, IEquatable<CondicaoPagamentoViewModel>
    {
        public bool IsSelected { get; set; }

        public string CdCondPgto { get; set; }
        public string Descricao { get; set; }
        public short NumParcelas { get; set; }
        public string Observacao { get; set; }
        public int PrazoMedio { get; set; }

        public bool Equals(CondicaoPagamentoViewModel other)
        {
            throw new NotImplementedException();
        }
    }
}
