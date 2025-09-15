using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt.Replace("\"", "\"\"")}\",\"{Response.Replace("\"", "\"\"")}\"";
    }

    public static Entry FromCsv(string line)
    {
        var parts = line.Split("\",\"");

        if (parts.Length == 3)
        {
            string date = parts[0].Trim('"');
            string prompt = parts[1].Trim('"');
            string response = parts[2].Trim('"');

            Entry entry = new Entry(prompt, response);
            entry.Date = date;
            return entry;
        }

        return null;
    }
}
