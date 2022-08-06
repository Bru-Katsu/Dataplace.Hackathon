using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers;
using Dataplace.Imersao.Core.Application.Comercializacoes.Queries;
using Dataplace.Imersao.Core.Application.Comercializacoes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.ListViewProviders
{
    public class ComercializacaoListViewProvider : SelectableListViewProvider<ComercializacaoViewModel, ComercializacaoFilterViewModel>
    {
        public override void Configure(ViewModelListBuilder<ComercializacaoViewModel> builder)
        {
            builder.View.Caption = 14044.ToMessage();

            builder.AllowSort();
            builder.AllowFilter();

            builder
                .Property(x => x.CdComerc)
                .HasCaption(143.ToMessage());

            builder
                .Property(x => x.PercAcordo)
                .HasCaption(3029.ToMessage());

            builder
                .Property(x => x.PercDiferencaICMS)
                .HasCaption(3030.ToMessage());

            builder
                .Property(x => x.PercDistribuidora)
                .HasCaption(3031.ToMessage());

            builder
                .Property(x => x.PercSemGarantia)
                .HasCaption(3032.ToMessage());

            builder
                .Property(x => x.PercDesconto)
                .HasCaption(4589.ToMessage());
        }

        public override IEnumerable<ComercializacaoViewModel> GetDatasource(ComercializacaoFilterViewModel filter, IEnumerable<SortDescriptor> sortings)
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
