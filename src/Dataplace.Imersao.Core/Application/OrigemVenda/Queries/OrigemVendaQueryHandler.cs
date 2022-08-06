using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Domain.OrigemVenda.ViewModels;
using Dataplace.Imersao.Core.Infra.Extensions;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.OrigemVenda.Queries
{
    public class OrigemVendaQueryHandler : IRequestHandler<OrigemVendaFilterViewModel, IEnumerable<OrigemVendaViewModel>>
    {
        public OrigemVendaQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        private readonly IDataAccess _dataAccess;
        public async Task<IEnumerable<OrigemVendaViewModel>> Handle(OrigemVendaFilterViewModel request, CancellationToken cancellationToken)
        {
			var sql = @"SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
						SELECT 
							RTRIM(CdOrigemVda) AS CdOrigemVda,
							RTRIM(DsOrigemVda) AS DsOrigemVda
						FROM OrigemVda

						/**orderby**/";

			var buider = new SqlBuilder();

			if (request.Sortings?.Count() > 0)
			{
				foreach (var sort in request.Sortings)
					buider.OrderBy($"{sort.Field} {sort.Direction.ToDbValue()}");
			}

			var selector = buider.AddTemplate(sql);

			return _dataAccess.Connection.Query<OrigemVendaViewModel>(new CommandDefinition(selector.RawSql, flags: CommandFlags.NoCache));
		}
    }
}
