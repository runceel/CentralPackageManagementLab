using CommonLibrary;

namespace BusinessA.Public;

public static class BusinessAModule
{
    public static string Message => $"{typeof(BusinessAModule).Assembly.GetName()} -> {CommonModule.Message}";
}
