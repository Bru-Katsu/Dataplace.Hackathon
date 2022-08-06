using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Application.Vendedores.ViewModels;
using Dataplace.Imersao.Core.Infra.Extensions;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Vendedores.Queries
{
    public class VendedorQueryHandler : IRequestHandler<VendedorFilterViewModel, IEnumerable<VendedorViewModel>>
    {
        private readonly IDataAccess _dataAccess;
        public VendedorQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<VendedorViewModel>> Handle(VendedorFilterViewModel request, CancellationToken cancellationToken)
        {
			var sql = @"SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
						SELECT
							CdVendedor,
							Apelido, 
							Nome,
							NumIdentificacao 
						FROM Vendedor
						WHERE StAtivo = 'S'
						/**orderby**/";

			var buider = new SqlBuilder();

			if (request.Sortings?.Count() > 0)
			{
				foreach (var sort in request.Sortings)
					buider.OrderBy($"{sort.Field} {sort.Direction.ToDbValue()}");
			}

			var selector = buider.AddTemplate(sql);

			return _dataAccess.Connection.Query<VendedorViewModel>(new CommandDefinition(selector.RawSql, flags: CommandFlags.NoCache));
		}
    }
}
