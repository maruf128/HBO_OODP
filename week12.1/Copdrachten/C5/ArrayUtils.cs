public static class ArrayUtils
{
    public static void ReverseArray<T>(T[] arr)
    {
        RecReverseArray(arr, 0, arr.Length - 1);
    }

    //RecReverseArray goes here

    public static void PrintArray<T>(T[] arr)
    {
        foreach (T elem in arr)
        {
            Console.WriteLine(elem);
        }
    }
    private static void RecReverseArray<T>(T[] array, int i, int j)
    {
        // indien het klaar is met switchen
        if (i > j) { return; }
        // bewaar 1 varr in een andere varr
        var bewaarde = array[i];
        array[i] = array[j];
        array[j] = bewaarde;

        // roep de functie dan weer aan en +1 i en -1j
        RecReverseArray(array, i + 1, j - 1);
    }
}
