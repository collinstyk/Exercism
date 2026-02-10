public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        int length = 0;
        foreach (var item in input)
        {
            length++;
        }
        return length;
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        List<T> reversed = [];

        for (int i = input.Count - 1; i >= 0; i--)
        {
            reversed.Add(input[i]);
        }
        return reversed;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        List<TOut> result = [];
        foreach (TIn item in input)
        {
            result.Add(map(item));
        }
        return result;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        List<T> result = [];
        foreach (T item in input)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        foreach (TIn item in input)
        {
            start = func(start, item);
        }
        return start;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        for (int i = input.Count - 1; i >= 0; i--)
        {
            TIn item = input[i];
            start = func(item, start);
        }
        return start;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        List<T> flattenedList = [];

        foreach (List<T> list in input)
        {
            foreach (T item in list)
            {
                flattenedList.Add(item);
            }
        }
        return flattenedList;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        foreach (T item in right)
        {
            left.Add(item);
        }
        return left;
    }
}