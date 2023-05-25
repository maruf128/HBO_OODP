public static class ArrayUtils
{
    public static int FindMinimum(int[] arr)
    {
        return RecMinimum(arr, arr.Length - 1);
    }

    // RecMinimum goes here
    private static int RecMinimum(int[] array, int index)
    {
        // zet de min getal in een aparte varr
        int laagste = array.Min();
        if (array[index] == laagste)
        {
            return array[index];
        }
        else
        {
            return RecMinimum(array, index - 1);
        }
    }
}