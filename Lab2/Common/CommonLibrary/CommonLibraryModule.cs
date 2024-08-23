using CommonLibrary.Core;

namespace CommonLibrary;

public static class CommonLibraryModule
{
    public static string Message => $"{DumpUtil.Dump(typeof(CommonLibraryModule))}->{CommonLibraryCoreModule.Message}";
}
