public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var count = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        for (int i = 0; i < sequence.Length; i++)
        {
            var key = sequence[i];
            if (count.TryGetValue(key, out int value)) count[key] = ++value;
            else throw new ArgumentException($"Invalid DNA base: {i}");
        }
        return count;
    }
}