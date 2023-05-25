public static class RecSearch
{
    public static int BinarySearch(int[] arr, int value)
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    // Overload BinarySearch here
    private static int BinarySearch(int[] arr, int value, int first, int last)
    {
        if (first > last)
        {
            return -1;
        }
        int midden = (first + last) / 2; // totaal bij elkaar delen door 2
        if (arr[midden] == value)
        {
            return midden;
        }
        else if (arr[midden] > value)
        {
            // te hoog geraden
            return BinarySearch(arr, value, first, midden - 1); // stuur de 0 en de laagst mogelijk getal mee sinds midden ook niet gelijk is
        }
        else if (arr[midden] < value)
        {
            /// te laag geraden
            return BinarySearch(arr, value, midden + 1, last); // stuur nu de midden + 1  en de laagst mogelijk getal mee

        }
        return 0;
    }
}