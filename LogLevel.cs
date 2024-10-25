using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(": ");
        return logLine.Substring(index + 2).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        return logLine.Substring(start, end - start).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
