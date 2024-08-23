namespace CommonLibrary.Core;

public static class CommonCoreModule
{
    public static string Message => typeof(CommonCoreModule).Assembly.GetName().ToString();
}
