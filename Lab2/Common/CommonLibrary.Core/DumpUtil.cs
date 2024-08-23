namespace CommonLibrary.Core;

public static class DumpUtil
{
    public static string Dump<T>() => Dump(typeof(T));

    public static string Dump(Type t)
    {
        var assemblyName = t.Assembly.GetName();
        return $"{assemblyName.Name}({assemblyName.Version})";
    }
}
