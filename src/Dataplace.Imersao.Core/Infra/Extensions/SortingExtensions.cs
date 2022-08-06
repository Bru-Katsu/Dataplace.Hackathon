using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dataplace.Core.Domain.Entities.SortDescriptor;

namespace Dataplace.Imersao.Core.Infra.Extensions
{
    public static class SortingExtensions
    {
        public static string ToDbValue(this SortingDirection direction)
        {
            if (direction == SortingDirection.Ascending)
                return "ASC";

            return "DESC";
        }
    }
}
