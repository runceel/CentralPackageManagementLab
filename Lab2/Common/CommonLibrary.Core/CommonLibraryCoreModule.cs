using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Core;
public static class CommonLibraryCoreModule
{
    public static string Message => DumpUtil.Dump(typeof(CommonLibraryCoreModule));
}
