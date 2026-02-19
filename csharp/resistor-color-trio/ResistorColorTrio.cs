using System.Drawing;
using System.Reflection.Emit;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        string[] referenceColors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        int digit1 = Array.IndexOf(referenceColors, colors[0]);
        int digit2 = Array.IndexOf(referenceColors, colors[1]);
        int multiplier = Array.IndexOf(referenceColors, colors[2]);
        long resistance = (digit1 * 10L + digit2) * (long)Math.Pow(10, multiplier);

        if (resistance >= 1_000_000_000) return $"{resistance / 1_000_000_000} gigaohms";
        else if (resistance >= 1_000_000) return $"{resistance / 1_000_000} megaohms";
        else if (resistance >= 1_000) return $"{resistance / 1_000} kiloohms";
        return $"{resistance} ohms";
    }
}
