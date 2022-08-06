using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Application.CondicaoPagamento.ViewModels;
using Dataplace.Imersao.Core.Infra.Extensions;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.CondicaoPagamento.Queries
{
    public class CondicaoPagamentoQueryHandler : IRequestHandler<CondicaoPagamentoFilterViewModel, IEnumerable<CondicaoPagamentoViewModel>>
    {
        private readonly IDataAccess _dataAccess;
        public CondicaoPagamentoQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<CondicaoPagamentoViewModel>> Handle(CondicaoPagamentoFilterViewModel request, CancellationToken cancellationToken)
        {
			var sql = @"SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
						SELECT 
							RTRIM(cdcondpgto) as cdcondpgto,
							LTRIM(RTRIM(descricao)) as descricao,
							numparcelas,
							LTRIM(RTRIM(observacao)) as observacao,
							PrazoMedio
						FROM CondicaoPgto
						WHERE stativo = 'S'
						/**orderby**/";

			var buider = new SqlBuilder();

			if (request.Sortings?.Count() > 0)
			{
				foreach (var sort in request.Sortings)
					buider.OrderBy($"{sort.Field} {sort.Direction.ToDbValue()}");
			}

			var selector = buider.AddTemplate(sql);

			return _dataAccess.Connection.Query<CondicaoPagamentoViewModel>(new CommandDefinition(selector.RawSql, flags: CommandFlags.NoCache));
		}
    }
}
