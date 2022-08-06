using dpLibrary05.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static dpLibrary05.Infrastructure.Helpers.LogBuilder;

namespace Dataplace.Imersao.Presentation.Extensions
{
    public static class LogBuilderExtensions
    {
        public static void AddError(this LogBuilder builder, string message)
        {
            builder.Items.Add(message, LogTypeEnum.Err);
        }

        public static void AddInformation(this LogBuilder builder, string message)
        {
            builder.Items.Add(message, LogTypeEnum.Information);
        }

        public static void AddWarning(this LogBuilder builder, string message)
        {
            builder.Items.Add(message, LogTypeEnum.Warning);
        }
    }
}
