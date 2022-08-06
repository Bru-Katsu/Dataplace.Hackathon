using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Application.Comercializacoes.ViewModels;
using Dataplace.Imersao.Core.Infra.Extensions;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Comercializacoes.Queries
{
    public class ComercializacaoQueryHandler : IRequestHandler<ComercializacaoFilterViewModel, IEnumerable<ComercializacaoViewModel>>
    {
        public ComercializacaoQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        private readonly IDataAccess _dataAccess;
        public async Task<IEnumerable<ComercializacaoViewModel>> Handle(ComercializacaoFilterViewModel request, CancellationToken cancellationToken)
        {
            var sql = @"SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
                        SELECT
                            CdComerc,
                            PercAcordo,
                            PercDiferencaICMS,
                            PercDistribuidora,
                            PercSemGarantia,
                            PercDesconto
                        FROM CondicaoComercial
                        WHERE stativo = 'S'
            
            	/**orderby**/";

			var buider = new SqlBuilder();

			if (request.Sortings?.Count() > 0)
			{
				foreach (var sort in request.Sortings)
					buider.OrderBy($"{sort.Field} {sort.Direction.ToDbValue()}");
			}

			var selector = buider.AddTemplate(sql);

			return _dataAccess.Connection.Query<ComercializacaoViewModel>(new CommandDefinition(selector.RawSql, flags: CommandFlags.NoCache));

		}
    }
}
