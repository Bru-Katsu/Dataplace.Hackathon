﻿using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Events
{
    public class DataDePrevisaoDeEntregaRemovidaAoOrcamentoEvent : OrcamentoEventBase
    {
        public DataDePrevisaoDeEntregaRemovidaAoOrcamentoEvent(OrcamentoViewModel item) : base(item)
        {

        }
    }
}
