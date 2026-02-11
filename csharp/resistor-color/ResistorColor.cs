public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colors = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
        return Array.FindIndex(colors, item => item == color);
    }

    public static string[] Colors()
    {
        return ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
    }
}