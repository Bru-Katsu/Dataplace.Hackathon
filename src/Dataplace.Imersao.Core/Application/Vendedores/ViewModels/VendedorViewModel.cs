using Dataplace.Core.Application.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Vendedores.ViewModels
{
    public class VendedorViewModel : ISelectableViewModel, IEquatable<VendedorViewModel>
    {
        public bool IsSelected { get; set; }

        public string CdVendedor { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public string NumIdentificacao { get; set; }

        public bool Equals(VendedorViewModel other)
        {
            return CdVendedor == other.CdVendedor;
        }
    }
}
