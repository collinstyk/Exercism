public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        char[] characters = word.ToCharArray();
        char[] filteredCharacters = characters.Where(character => (character != ' ') && (character != '-')).ToArray();
        HashSet<char> uniqueCharacters = filteredCharacters.ToHashSet();
        return String.Join("", uniqueCharacters) == String.Join("", filteredCharacters);
    }
}
