using System.Collections.Generic;

public static class FileScript
{
    private static Dictionary<string, string> mappedLines;
    private static string language = "/Pt-br";

    public static string Language 
    {
        get 
        {
            return language;
        }
        set 
        {
            language = value;
        }
    }

    public static Dictionary<string, string> MappedLines 
    {
        get 
        {
            return mappedLines;
        }
        set 
        {
            mappedLines = value;
        }
    }

    public static string GetLineFromKey(string key){
        return mappedLines.ContainsKey(key) ? mappedLines[key] : "";
    }

}
