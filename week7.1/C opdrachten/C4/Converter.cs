public static class Converter
{

    public static T2 ConvertVariables<T1, T2>(T1 getal1)
    {
        T2 NUM = (T2)Convert.ChangeType(getal1, typeof(T2));
        return NUM;
    }
}