public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (String.IsNullOrEmpty(input)) return input;

        char[] inputChars = input.ToCharArray();
        Array.Reverse(inputChars);
        var reverseString = string.Join("", inputChars);
        return reverseString;
    }
}