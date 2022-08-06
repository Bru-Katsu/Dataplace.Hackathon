using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers;
using Dataplace.Imersao.Core.Application.CondicaoPagamento.Queries;
using Dataplace.Imersao.Core.Application.CondicaoPagamento.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.ListViewProviders
{
    public class CondicaoPagamentoListViewProvider : SelectableListViewProvider<CondicaoPagamentoViewModel, CondicaoPagamentoFilterViewModel>
    {
        public override void Configure(ViewModelListBuilder<CondicaoPagamentoViewModel> builder)
        {
            builder.View.Caption = 5897.ToMessage();

            builder.AllowSort();
            builder.AllowFilter();

            builder
                .Property(x => x.CdCondPgto)
                .HasCaption(143.ToMessage());

            builder
                .Property(x => x.Descricao)
                .HasCaption(2802.ToMessage());

            builder
                .Property(x => x.NumParcelas)
                .HasCaption(4721.ToMessage());

            builder
                .Property(x => x.Observacao)
                .HasCaption(3941.ToMessage());

            builder
                .Property(x => x.PrazoMedio)
                .HasCaption(4861.ToMessage());
        }

        public override IEnumerable<CondicaoPagamentoViewModel> GetDatasource(CondicaoPagamentoFilterViewModel filter, IEnumerable<SortDescriptor> sortings)
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
