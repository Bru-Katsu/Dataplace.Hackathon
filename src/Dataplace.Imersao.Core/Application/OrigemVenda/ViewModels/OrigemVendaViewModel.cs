using Dataplace.Core.Application.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Domain.OrigemVenda.ViewModels
{
    public class OrigemVendaViewModel : ISelectableViewModel, IEquatable<OrigemVendaViewModel>
    {
        public bool IsSelected { get; set; }

        public string CdOrigemVda { get; set; }
        public string DsOrigemVda { get; set; }

        public bool Equals(OrigemVendaViewModel other)
        {
            return CdOrigemVda == other.CdOrigemVda;
        }
    }
}
