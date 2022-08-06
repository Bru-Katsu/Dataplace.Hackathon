using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.Imersao.Core.Domain.NaturezaOperacoes.ViewModels;
using Dataplace.Imersao.Core.Infra.Extensions;
using dpLibrary05;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.NaturezaOperacoes.Queries
{
    public class NaturezaOperacaoQueryHandler : IRequestHandler<NaturezaOperacaoFilterViewModel, IEnumerable<NaturezaOperacaoViewModel>>
    {
        public NaturezaOperacaoQueryHandler(ISqlDataAccess dataAccess)
        {
			_dataAccess = dataAccess;
        }

		private readonly IDataAccess _dataAccess;
        public async Task<IEnumerable<NaturezaOperacaoViewModel>> Handle(NaturezaOperacaoFilterViewModel request, CancellationToken cancellationToken)
        {
            var sql = @"SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
						SELECT 
							RTRIM(cdnatoperacao) as cdnatoperacao,
							RTRIM(descricao) as descricao, 
							RTRIM(descricao2) as descricao2, 
							sttpnf, 
							stentradasaida, 
							CASE 
								WHEN stgeraddfinanceiro = 1 THEN 'S' 
								ELSE 'N'
							END AS stgeraddfinanceiro,
							CASE
								WHEN stupdestoque = 1 THEN 'S'
								ELSE 'N'
							END AS stupdestoque
						FROM naturezaoperacao 
						WHERE  stativo = 'S' 
							AND cdnatoperacao IN ('01','0000000001','V1','VDA_SUBST','02','XX','A','F2','SUFRAMA','VENDA','BONIFICA','FT01','01_CONSUMO','10','I9','E9','ZZ','FINANCEIRO','60','0000000001','INDUSTR','V1','75','72','71','78','63','REMESSA','ESTOQUE','REM','SS','SS_22','SSS_22') AND sttpnf <> 'S'  AND descricao2  like '%%'  COLLATE  Latin1_General_CI_AS SELECT cdnatoperacao,descricao, descricao2, sttpnf, (CASE stentradasaida WHEN 'E' THEN 'Entrada' ELSE 'Saída' END) AS stentradasaida, (CASE stgeraddfinanceiro WHEN '1' THEN 'Sim' ELSE 'Não' END) AS stgeraddfinanceiro, (CASE stupdestoque WHEN '1' THEN 'Sim' ELSE 'Não' END) AS stupdestoque FROM naturezaoperacao WHERE  stativo = 'S' AND cdnatoperacao IN ('01','0000000001','V1','VDA_SUBST','02','XX','A','F2','SUFRAMA','VENDA','BONIFICA','FT01','01_CONSUMO','10','I9','E9','ZZ','FINANCEIRO','60','0000000001','INDUSTR','V1','75','72','71','78','63','REMESSA','ESTOQUE','REM','SS','SS_22','SSS_22') 
							AND sttpnf <> 'S'  
							COLLATE  Latin1_General_CI_AS

						/**orderby**/";

			var buider = new SqlBuilder();

			if(request.Sortings?.Count() > 0)
            {
                foreach (var sort in request.Sortings)
					buider.OrderBy($"{sort.Field} {sort.Direction.ToDbValue()}");
            }

			var selector = buider.AddTemplate(sql);

			return _dataAccess.Connection.Query<NaturezaOperacaoViewModel>(new CommandDefinition(selector.RawSql, flags: CommandFlags.NoCache)); 
        }
    }
}
