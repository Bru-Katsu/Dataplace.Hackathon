using Dataplace.Core.Application.Contracts.Results;
using Dataplace.Core.Application.Services.Results;
using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.Domain.Notifications;
using Dataplace.Core.Infra.CrossCutting.EventAggregator.Contracts;
using Dataplace.Core.win.Controls.Extensions;
using Dataplace.Core.win.Controls.List.Behaviors;
using Dataplace.Core.win.Controls.List.Behaviors.Contracts;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views;
using Dataplace.Core.win.Views.Extensions;
using Dataplace.Imersao.Core.Application.Comercializacoes.ViewModels;
using Dataplace.Imersao.Core.Application.CondicaoPagamento.ViewModels;
using Dataplace.Imersao.Core.Application.Orcamentos.Commands;
using Dataplace.Imersao.Core.Application.Orcamentos.Queries;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using Dataplace.Imersao.Core.Application.Vendedores.ViewModels;
using Dataplace.Imersao.Core.Domain.NaturezaOperacoes.ViewModels;
using Dataplace.Imersao.Core.Domain.Orcamentos.Enums;
using Dataplace.Imersao.Core.Domain.OrigemVenda.ViewModels;
using Dataplace.Imersao.Presentation.Common;
using Dataplace.Imersao.Presentation.Extensions;
using Dataplace.Imersao.Presentation.Views.Orcamentos.ListViewProviders;
using Dataplace.Imersao.Presentation.Views.Orcamentos.Messages;
using dpLibrary05.Infrastructure.Helpers;
using dpLibrary05.Infrastructure.Helpers.Permission;
using dpLibrary05.SymphonyInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    public partial class CancelarFehacrOrcamentosView : dpLibrary05.Infrastructure.UserControls.ucSymGen_ToolDialog
    {
        #region fields
        private DateTime _startDate;
        private DateTime _endDate;
        private const int _itemSeg = 467;
        private IListBehavior<OrcamentoViewModel, OrcamentoQuery> _orcamentoList;
        private readonly IServiceProvider _serviceProvider;
        private readonly IEventAggregator _eventAggregator;

        #endregion

        #region constructors
        public CancelarFehacrOrcamentosView(
            IServiceProvider serviceProvider,
            IEventAggregator eventAggregator)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _eventAggregator = eventAggregator;

            _orcamentoList = new C1TrueDBGridListBehavior<OrcamentoViewModel, OrcamentoQuery>(gridOrcamento)
                .WithConfiguration(GetConfiguration());

            this.ToolConfiguration += CancelamentoOrcamentoView_ToolConfiguration;
            this.BeforeProcess += CancelamentoOrcamentoView_BeforeProcess;
            this.Process += CancelamentoOrcamentoView_Process;
            this.AfterProcess += CancelamentoOrcamentoView_AfterProcess;


            this.tsiMarcar.Click += TsiMarcarTodos_Click;
            this.tsiDesmarca.Click += TsiDesmarcarTodos_Click;

            this.KeyDown += CancelamentoOrcamentoView_KeyDown;


            this.chkAberto.Click += chk_Click;
            this.chkFechado.Click += chk_Click;
            this.chkCancelado.Click += chk_Click;


            // pegar evento clique das opçoes
            this.optCancelar.Click += opt_Click;
            this.optFechar.Click += opt_Click;

            InitializeControls();

            // pegar key down de um controle
            // dtpPrevisaoEntrega.KeyDown += Dtp_KeyDown;



            // rotina para validar status do controle
            //  desabilitar ou habilitar algun componente em tela
            //  deixar invisível ou algo assim
            VerificarStatusControles();

        }
        #endregion

        #region configurations
        public void InitializeControls()
        {
            _startDate = DateTime.Today.AddMonths(-1);
            _endDate = DateTime.Today;
            rangeDate.Date1.Value = _startDate;
            rangeDate.Date2.Value = _endDate;

            lueCliente.SearchObject = PedidoSearch.find_orcamento_cliente();
            lueTabelaPreco.SearchObject = PedidoSearch.find_tabelapreco();

            var providerOrigemVenda = dpLibrary05.BootStrapper.Container.GetViewProvider<SelectableListView, OrigemVendaListViewProvider>();
            chkOrigemVenda.ConfigureSelector(providerOrigemVenda);

            var providerVendedor = dpLibrary05.BootStrapper.Container.GetViewProvider<SelectableListView, VendedorListViewProvider>();
            chkVendedores.ConfigureSelector(providerVendedor);

            var providerComercializacao = dpLibrary05.BootStrapper.Container.GetViewProvider<SelectableListView, ComercializacaoListViewProvider>();
            chkComercializacao.ConfigureSelector(providerComercializacao);

            var providerCondicaoPagto = dpLibrary05.BootStrapper.Container.GetViewProvider<SelectableListView, CondicaoPagamentoListViewProvider>();
            chkCondicaoPagto.ConfigureSelector(providerCondicaoPagto);
        }

        #endregion

        #region internal methods
        private TipoAcaoEnum TipoAcao => GetTipoAcao();
        private enum TipoAcaoEnum
        {
            ReabrirOrcamento,
            CancelarOrcamento,
            FecharOrcamento,
        }

        private TipoAcaoEnum GetTipoAcao()
        {
            if (optCancelar.Checked)
                return TipoAcaoEnum.CancelarOrcamento;

            if (optFechar.Checked)
                return TipoAcaoEnum.FecharOrcamento;

            if (optReabrir.Checked)
                return TipoAcaoEnum.ReabrirOrcamento;

            // default            
            return TipoAcaoEnum.CancelarOrcamento;
        }

        private TipoPeriodoEnum TipoPeriodo => GetTipoPeriodo();
        private TipoPeriodoEnum GetTipoPeriodo()
        {
            if (optDataAbertura.Checked)
                return TipoPeriodoEnum.Abertura;

            if (optDataFechamento.Checked)
                return TipoPeriodoEnum.Fechamento;

            if (optDataValidade.Checked)
                return TipoPeriodoEnum.Validade;

            if (optDataPrevFechamento.Checked)
                return TipoPeriodoEnum.PrevisaoFechamento;

            //default
            return TipoPeriodoEnum.Abertura;
        }

        //private TipoPeriodo Get
        #endregion

        #region tool events
        private void CancelamentoOrcamentoView_ToolConfiguration(object sender, ToolConfigurationEventArgs e)
        {
            // definições iniciais do projeto
            // item seguraça
            // engine code
            this.Text = "Cancelar/Fechar orçamentos em aberto";
            e.SecurityIdList.Add(_itemSeg);
            e.CancelButtonVisisble = true;
        }

        private void CancelamentoOrcamentoView_BeforeProcess(object sender, BeforeProcessEventArgs e)
        {
            var permission = PermissionControl.Factory().ValidatePermission(_itemSeg, dpLibrary05.mGenerico.PermissionEnum.Execute);
            if (!permission.IsAuthorized())
            {
                e.Cancel = true;
                this.Message.Info(permission.BuildMessage());
                return;
            }

            var itensSelecionados = _orcamentoList.GetCheckedItems();
            if (itensSelecionados.Count() == 0)
            {
                e.Cancel = true;
                this.Message.Info(53727.ToMessage());
                return;
            }

            e.Parameter.Items.Add("acao", TipoAcao);
            e.Parameter.Items.Add("itensSelecionados", itensSelecionados);
        }
        private async void CancelamentoOrcamentoView_Process(object sender, ProcessEventArgs e)
        {
            var acao = (TipoAcaoEnum)e.Parameter.Items.get_Item("acao").Value;
            var itensSelecionados = (IEnumerable<OrcamentoViewModel>)e.Parameter.Items.get_Item("itensSelecionados").Value;

            e.ProgressMinimum = 0;
            e.ProgressMaximum = itensSelecionados.Count();
            e.BeginProcess();

            // um a um
            foreach (var item in itensSelecionados)
            {
                switch (acao)
                {
                    case TipoAcaoEnum.CancelarOrcamento:
                        // registrar log na parte de detalhes
                        var resultCancelar = await CancelarOrcamento(item);
                        if (resultCancelar.Success)
                            e.LogBuilder.AddInformation($"{3140.ToMessage()} {item.NumOrcamento} {3485.ToMessage().ToLower()}");
                        else
                        {
                            foreach (var message in resultCancelar.Notifications)
                                e.LogBuilder.AddError($"{3140.ToMessage()} {item.NumOrcamento} - {message.Message}");
                        }

                        break;
                    case TipoAcaoEnum.FecharOrcamento:
                        var resultFechar = await FecharOrcamento(item);

                        // registrar log na parte de detalhes
                        if (resultFechar.Success)
                            e.LogBuilder.AddInformation($"{3140.ToMessage()} {item.NumOrcamento} {3846.ToMessage().ToLower()}");
                        else
                        {
                            foreach (var message in resultFechar.Notifications)
                                e.LogBuilder.AddError($"{3140.ToMessage()} {item.NumOrcamento} - {message.Message}");
                        }

                        break;
                    case TipoAcaoEnum.ReabrirOrcamento:
                        var resultReabrir = await ReabrirOrcamento(item);

                        // registrar log na parte de detalhes
                        if (resultReabrir.Success)
                            e.LogBuilder.AddInformation($"{3140.ToMessage()} {item.NumOrcamento} {25534.ToMessage().ToLower()}");
                        else
                        {
                            foreach (var message in resultReabrir.Notifications)
                                e.LogBuilder.AddError($"{3140.ToMessage()} {item.NumOrcamento} - {message.Message}");
                        }

                        break;
                    default:
                        break;
                }

                // permitir cancelamento 
                if (e.CancellationRequested)
                    break;

                e.ProgressValue += 1;
            }

            e.EndProcess();
        }
        private void CancelamentoOrcamentoView_AfterProcess(object sender, AfterProcessEventArgs e)
        {
            // exemplo de message box no final do processo
            // this.Message.Info("MENSAGEM FINAL");


            //  desmarcar todos itens no final do processo
            // _orcamentoList.ChangeCheckState(false);
        }

        // teclas de atalho
        private async void CancelamentoOrcamentoView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                await _orcamentoList.LoadAsync();
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.M)
            {
                _orcamentoList.ChangeCheckState(true);
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.D)
            {
                _orcamentoList.ChangeCheckState(false);
            }
        }

        #endregion

        #region list events

        // exemplos conf list
        //  configuration.AllowFilter();  >> permite filtro
        //  configuration.AllowSort(); >> habilita ordenação
        //  configuration.Ignore(x => x.CdVendedor); >> ignora 
        // 


        // adicionar botão (nesse caso seta azul)
        // configuration.Property(x => x.NumOrcamento)
        //    .HasButton(dpLibrary05.mGenerico.oImageList.imgList16.Images[dpLibrary05.mGenerico.oImageList.SETA_AZUL_PEQ], (sender, e) => {
        //        var item = (OrcamentoViewModel)sender;
        //        _eventAggregator.PublishEvent(new OrcamentoSetaAzulClick(item.NumOrcamento));
        //    });



        // exemplode de destaque das linhas
        //configuration.HasHighlight(x => {
        //    // destacando somente cor da fonte
        //    x.Add(orcamento => orcamento.StEntrega == "2", System.Drawing.Color.DarkOrange);

        //    // exemplo para destacar a cor da fonte e cor de fundo da linha
        //    x.Add(orcamento => orcamento.StEntrega == "2", new ViewModePropertyHighlightStyle()
        //        .WithBackColor(System.Drawing.Color.DarkOrange)
        //        .WithForeColor(System.Drawing.Color.White));
        //});


        // exemplo de tradução para valores na coluna
        //configuration.Property(x => x.StAlgumaCoisa)
        //   .HasCaption("St. validade")
        //   .HasValueItems(x =>
        //   {
        //       x.Add("0", "texto para equivalente ao valor 0");
        //       x.Add("1", "texto para equivalente ao valor 1");
        //       x.Add("2", "texto para equivalente ao valor 2");
        //   });

        private ViewModelListBuilder<OrcamentoViewModel> GetConfiguration()
        {
            var configuration = new ViewModelListBuilder<OrcamentoViewModel>();



            configuration.HasHighlight(x =>
            {
                x.Add(orcamento => orcamento.Situacao == Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado.ToDataValue(), System.Drawing.Color.Red);
            });

            // define rotina para obter os filtros que vão ser aplicados na query
            configuration.WithQuery<OrcamentoQuery>(() => GetQuery());

            configuration.Ignore(x => x.CdEmpresa);
            configuration.Ignore(x => x.CdFilial);
            configuration.Ignore(x => x.SqTabela);
            configuration.Ignore(x => x.CdTabela);
            configuration.Ignore(x => x.CdVendedor);
            configuration.Ignore(x => x.DiasValidade);
            configuration.Ignore(x => x.DataValidade);
            configuration.Ignore(x => x.TotalItens);

            configuration.Property(x => x.NumOrcamento)
                .HasMinWidth(100)
                .HasCaption(3141.ToMessage());

            configuration.Property(x => x.Situacao)
                  .HasMinWidth(100)
                  .HasCaption(2805.ToMessage())
                  .HasValueItems(x =>
                  {
                      x.Add(OrcamentoStatusEnum.Aberto.ToDataValue(), 3469.ToMessage());
                      x.Add(OrcamentoStatusEnum.Fechado.ToDataValue(), 3846.ToMessage());
                      x.Add(OrcamentoStatusEnum.Cancelado.ToDataValue(), 3485.ToMessage());
                  });

            configuration.Property(x => x.CdCliente)
               .HasMinWidth(50)
               .HasCaption(2791.ToMessage());

            configuration.Property(x => x.DsCliente)
                .HasMinWidth(200)
                .HasCaption(3025.ToMessage());

            configuration.Property(x => x.DtOrcamento)
                .HasMinWidth(80)
                .HasCaption(3845.ToMessage())
                .HasFormat("d");

            configuration.Property(x => x.VlTotal)
                .HasMinWidth(80)
                .HasCaption(5820.ToMessage())
                .HasFormat("n");

            configuration.Property(x => x.DtFechamento)
                .HasMinWidth(80)
                .HasCaption(3136.ToMessage())
                .HasFormat("d");

            configuration.Property(x => x.CdOrigemVda)
                .HasMinWidth(80)
                .HasCaption(43759.ToMessage());

            configuration.Property(x => x.DsOrigemVda)
                .HasMinWidth(80)
                .HasCaption(43760.ToMessage());

            return configuration;
        }

        private OrcamentoQuery GetQuery()
        {
            var situacaoList = new List<Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum>();

            if (chkAberto.Checked)
                situacaoList.Add(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Aberto);
            if (chkFechado.Checked)
                situacaoList.Add(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Fechado);
            if (chkCancelado.Checked)
                situacaoList.Add(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado);

            DateTime? dtInicio = null;
            DateTime? dtFim = null;
            if (rangeDate.Date1.Value is DateTime d)
                dtInicio = d;

            if (rangeDate.Date2.Value is DateTime d2)
                dtFim = d2;

            var index = lueTabelaPreco.SearchObject.Result.ResultIndex;

            string cdTabela = string.Empty;
            short? sqTabela = null;

            if(!string.IsNullOrEmpty(lueTabelaPreco.GetValue() as string))
            {
                cdTabela = lueTabelaPreco.GetValue<string>();
                sqTabela = lueTabelaPreco.GetValue<short>(1);
            }

            var query = new OrcamentoQuery()
            {
                SituacaoList = situacaoList,
                DtInicio = dtInicio,
                DtFim = dtFim,
                CdCliente = lueCliente.GetValue() as string,
                TipoPeriodo = TipoPeriodo,
                OrigensVenda = chkOrigemVenda.GetSelectedItems<OrigemVendaViewModel>().Select(x => x.CdOrigemVda),
                Vendedores = chkVendedores.GetSelectedItems<VendedorViewModel>().Select(x => x.CdVendedor),
                CondicoesPagto = chkCondicaoPagto.GetSelectedItems<CondicaoPagamentoViewModel>().Select(x => x.CdCondPgto),
                Comercializacoes = chkComercializacao.GetSelectedItems<ComercializacaoViewModel>().Select(x => x.CdComerc),
                CdTabela = cdTabela,
                SqTabela = sqTabela
            };

            return query;
        }

        #endregion

        #region control events
        private void TsiDesmarcarTodos_Click(object sender, EventArgs e)
        {
            _orcamentoList.ChangeCheckState(false);
        }
        private void TsiMarcarTodos_Click(object sender, EventArgs e)
        {
            _orcamentoList.ChangeCheckState(true);
        }

        private async void BtnCarregar_Click(object sender, EventArgs e)
        {
            await _orcamentoList.LoadAsync();
        }

        private async void chk_Click(object sender, EventArgs e)
        {
            await _orcamentoList.LoadAsync();
        }

        private void opt_Click(object sender, EventArgs e)
        {
            VerificarStatusControles();
        }

        private void VerificarStatusControles()
        {

            // exemplo pra deixar componente intaivo dependendo de uma opão
            // dtpPrevisaoEntrega.Enabled = optAtribuirPevisaoEntrega.Checked;

        }
        #endregion

        #region processamentos
        private async Task<IResult> CancelarOrcamento(OrcamentoViewModel item)
        {
            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {
                var command = new CancelarOrcamentoCommand(item);
                var mediator = scope.Container.GetInstance<IMediatorHandler>();

                var notifications = scope.Container.GetInstance<INotificationHandler<DomainNotification>>();
                await mediator.SendCommand(command);

                item.Result = Result.ResultFactory.New(notifications.GetNotifications());
                if (item.Result.Success)
                {
                    item.Situacao = Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado.ToDataValue();
                }
            }

            return item.Result;
        }

        private async Task<IResult> FecharOrcamento(OrcamentoViewModel item)
        {
            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {
                var command = new FecharOrcamentoCommand(item);
                var mediator = scope.Container.GetInstance<IMediatorHandler>();

                var notifications = scope.Container.GetInstance<INotificationHandler<DomainNotification>>();
                await mediator.SendCommand(command);

                item.Result = Result.ResultFactory.New(notifications.GetNotifications());
                if (item.Result.Success)
                {
                    item.Situacao = Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Fechado.ToDataValue();
                    item.DtFechamento = DateTime.Now.Date;
                }
            }

            return item.Result;
        }

        private async Task<IResult> ReabrirOrcamento(OrcamentoViewModel item)
        {
            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {
                var command = new ReabrirOrcamentoCommand(item);
                var mediator = scope.Container.GetInstance<IMediatorHandler>();

                var notifications = scope.Container.GetInstance<INotificationHandler<DomainNotification>>();
                await mediator.SendCommand(command);

                item.Result = Result.ResultFactory.New(notifications.GetNotifications());
                if (item.Result.Success)
                {
                    item.Situacao = Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Fechado.ToDataValue();
                    item.DtFechamento = DateTime.Now.Date;
                }
            }

            return item.Result;
        }

        #endregion
    }
}
