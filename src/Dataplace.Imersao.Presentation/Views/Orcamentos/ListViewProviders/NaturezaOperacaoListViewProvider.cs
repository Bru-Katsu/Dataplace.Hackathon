using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers;
using Dataplace.Imersao.Core.Application.NaturezaOperacoes.Queries;
using Dataplace.Imersao.Core.Domain.NaturezaOperacoes.ViewModels;
using System.Collections.Generic;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.ListViewProviders
{
    public class NaturezaOperacaoListViewProvider : SelectableListViewProvider<NaturezaOperacaoViewModel, NaturezaOperacaoFilterViewModel>
    {
        private readonly IMediatorHandler _mediatr;
        public NaturezaOperacaoListViewProvider(IMediatorHandler mediatr)
        {
            _mediatr = mediatr;
        }

        public override void Configure(ViewModelListBuilder<NaturezaOperacaoViewModel> builder)
        {
            builder.View.Caption = 4828.ToMessage();

            builder.AllowSort();
            builder.AllowFilter();

            builder
                .Property(x => x.CdNatOperacao)
                .HasCaption(64031.ToMessage());

            builder
                .Property(x => x.Descricao)
                .HasCaption(2802.ToMessage());

            builder
                .Property(x => x.Descricao2)
                .HasCaption(9415.ToMessage());

            builder
                .Property(x => x.StEntradaSaida)
                .HasCaption(4668.ToMessage())
                .HasValueItems(options =>
                {
                    options.Add("E", 4396.ToMessage());
                    options.Add("S", 4397.ToMessage());
                });

            builder
                .Property(x => x.StGeraDDFinanceiro)
                .HasCaption(4844.ToMessage())
                .HasValueItems(options =>
                {
                    options.Add("S", 3034.ToMessage());
                    options.Add("N", 3124.ToMessage());
                });

            builder
                .Property(x => x.StUpdEstoque)
                .HasCaption(4544.ToMessage())
                .HasValueItems(options =>
                {
                    options.Add("S", 3034.ToMessage());
                    options.Add("N", 3124.ToMessage());
                });
        }

        public override IEnumerable<NaturezaOperacaoViewModel> GetDatasource(NaturezaOperacaoFilterViewModel filter, IEnumerable<SortDescriptor> sortings)
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
