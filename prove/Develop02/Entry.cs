using System.Text.Json.Serialization;
class Entry
{
    [JsonPropertyName("_date")]
    public string _date { get; set; }

    [JsonPropertyName("_promptText")]
    public string _promptText { get; set; }

    [JsonPropertyName("_entryText")]
    public string _entryText { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_date} | {_promptText} | {_entryText}");
    }
}