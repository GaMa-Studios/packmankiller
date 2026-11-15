using UnityEngine;
using System.IO;

public class SettingsManager : MonoBehaviour
{
    private string savePath;
    public GameSettings currentSettings;

    private void Awake()
    {
        savePath = Path.Combine(Application.persistentDataPath, "settings.json");
        LoadSettings();
    }

    public void SaveSettings()
    {
        string json = JsonUtility.ToJson(currentSettings, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Settings saved to " + savePath);
    }

    public void LoadSettings()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            currentSettings = JsonUtility.FromJson<GameSettings>(json);
            Debug.Log("Settings loaded.");
        }
        else
        {
            currentSettings = new GameSettings();
            SaveSettings();
            Debug.Log("No settings found. Created default settings.");
        }
    }
}
