using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        if (index == -1) return string.Empty;
        return str.Substring(index + delimiter.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        int startIndex = str.IndexOf(startDelimiter);
        int endIndex = str.IndexOf(endDelimiter, startIndex + startDelimiter.Length);
        
        if (startIndex == -1 || endIndex == -1) return string.Empty;
        
        return str.Substring(startIndex + startDelimiter.Length, endIndex - (startIndex + startDelimiter.Length));
    }

    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ").Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type

    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]").ToUpper();
    }
}
