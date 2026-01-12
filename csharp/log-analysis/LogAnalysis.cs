public static class LogAnalysis
{
    public static string SubstringAfter(this string log, string delimeter)
    {
        return log.Split(delimeter)[1];
    }

    public static string SubstringBetween(this string log, string firstDelimeter, string secondDelimeter)
    {
        int startIndex = log.IndexOf(firstDelimeter) + firstDelimeter.Length;
        int endIndex = log.IndexOf(secondDelimeter);
        int length = endIndex - startIndex;

        return log.Substring(startIndex, length);
    }

    public static string Message(this string log)
    {
        return log.SubstringAfter(": ");
    }

    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[", "]");
    }
}