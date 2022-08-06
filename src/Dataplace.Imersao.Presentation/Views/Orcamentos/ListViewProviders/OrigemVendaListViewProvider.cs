using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers;
using Dataplace.Imersao.Core.Application.OrigemVenda.Queries;
using Dataplace.Imersao.Core.Domain.OrigemVenda.ViewModels;
using System.Collections.Generic;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.ListViewProviders
{
    public class OrigemVendaListViewProvider : SelectableListViewProvider<OrigemVendaViewModel, OrigemVendaFilterViewModel>
    {
        public OrigemVendaListViewProvider() { }

        public override void Configure(ViewModelListBuilder<OrigemVendaViewModel> builder)
        {
            builder.View.Caption = 19166.ToMessage();

            builder.AllowSort();
            builder.AllowFilter();

            builder
                .Property(x => x.CdOrigemVda)
                .HasCaption(143.ToMessage());

            builder
                .Property(x => x.DsOrigemVda)
                .HasCaption(2802.ToMessage());
        }

        public override IEnumerable<OrigemVendaViewModel> GetDatasource(OrigemVendaFilterViewModel filter, IEnumerable<SortDescriptor> sortings)
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
