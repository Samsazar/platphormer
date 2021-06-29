using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(name);
    }
    public void ReloadLevel()
    {
        LoadLevel(SceneManager.GetActiveScene().name);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
