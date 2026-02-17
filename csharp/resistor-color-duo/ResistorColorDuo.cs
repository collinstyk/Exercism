public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] referenceColors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        int resistance = 0;
        for (int i = 0; i < 2; i++)
        {
            string color = colors[i];
            if (!referenceColors.Contains(color)) throw new ArgumentException($"Invalid color input: {color}");
            resistance = (10 * resistance) + Array.FindIndex(referenceColors, c => c == color);
        }
        return resistance;
    }
}
