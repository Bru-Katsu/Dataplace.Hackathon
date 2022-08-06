using dpLibrary05.Infrastructure.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Presentation.Extensions
{
    public static class LookupEditorExtensions
    {
        public static T GetValue<T>(this DPLookUpEdit editor, int colIndex = 0)
        {
            var value  = editor.GetControl(colIndex).Text;
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
