using System.Text.Json;

public class JsonHandler
{
    public static void SaveToJson<T>(T obj, string filePath)
    {
        var json = JsonSerializer.Serialize(obj);
        File.WriteAllText(filePath, json);
    }

    public static T LoadFromJson<T>(string filePath)
    {
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}
