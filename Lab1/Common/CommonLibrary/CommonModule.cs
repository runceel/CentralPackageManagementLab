using CommonLibrary.Core;

namespace CommonLibrary;

public static class CommonModule
{
    public static string Message => $"{typeof(CommonModule).Assembly.GetName()} -> {CommonCoreModule.Message}";
}
