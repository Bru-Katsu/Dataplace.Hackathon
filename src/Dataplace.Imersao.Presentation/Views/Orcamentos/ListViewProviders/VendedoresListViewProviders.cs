using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers;
using Dataplace.Imersao.Core.Application.Vendedores.Queries;
using Dataplace.Imersao.Core.Application.Vendedores.ViewModels;
using System.Collections.Generic;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.ListViewProviders
{
    public class VendedorListViewProvider : SelectableListViewProvider<VendedorViewModel, VendedorFilterViewModel>
    {
        public override void Configure(ViewModelListBuilder<VendedorViewModel> builder)
        {
            builder.View.Caption = 4147.ToMessage();

            builder.AllowSort();
            builder.AllowFilter();

            builder
                .Property(x => x.CdVendedor)
                .HasCaption(143.ToMessage());

            builder
                .Property(x => x.Apelido)
                .HasCaption(4141.ToMessage());

            builder
                .Property(x => x.Nome)
                .HasCaption(2804.ToMessage());

            builder
                .Property(x => x.NumIdentificacao)
                .HasCaption(30861.ToMessage());
        }

        public override IEnumerable<VendedorViewModel> GetDatasource(VendedorFilterViewModel filter, IEnumerable<SortDescriptor> sortings)
        {
            filter.Sortings = sortings;

            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {
                var m = scope.Container.GetInstance<IMediatorHandler>();
                return m.Query(filter).Result;
            }
        }
    }
}
