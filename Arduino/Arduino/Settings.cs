using Newtonsoft.Json;
using System.IO;

public class Settings
{
    public string hotkeys1 { get; set; }
    public string hotkeys2 { get; set; }
    public string hotkeys3 { get; set; }
}

public static class SettingsManager
{
    private static readonly string _settingsPath = "settings.json";

    public static void SaveSettings(Settings settings)
    {
        var json = JsonConvert.SerializeObject(settings);
        File.WriteAllText(_settingsPath, json);
    }

    public static Settings GetSettings()
    {
        if (!File.Exists(_settingsPath))
        {
            File.Create(_settingsPath);
        }

        var json = File.ReadAllText(_settingsPath);
        return JsonConvert.DeserializeObject<Settings>(json);
    }
}
