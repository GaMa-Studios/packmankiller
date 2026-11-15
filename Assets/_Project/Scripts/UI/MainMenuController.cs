using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartGame() { Debug.Log("Start Game"); }
    public void OpenSettings() { Debug.Log("Settings"); }
    public void OpenAbout() { Debug.Log("About"); }
    public void ExitGame() { Application.Quit(); }
}
