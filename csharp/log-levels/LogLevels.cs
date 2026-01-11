static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int openingBracketIndex = logLine.IndexOf('[');
        int closingBracketIndex = logLine.IndexOf(']');
        int length = closingBracketIndex - openingBracketIndex;

        return logLine.Substring(openingBracketIndex + 1, length - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string[] logLineArray = logLine.Split(':');

        string reformattedMessage = $"{logLineArray[1].Trim()} {logLineArray[0].Replace('[', '(').Replace(']', ')').ToLower()}";
        return reformattedMessage;
    }
}
