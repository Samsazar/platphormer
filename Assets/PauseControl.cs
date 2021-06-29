using UnityEngine.UI;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public Image black_screen;
    public GameObject pause_menu;
    public void Toggle()
    {
        bool pause = !black_screen.enabled;
        black_screen.enabled = pause;
        pause_menu.SetActive(pause);
        Time.timeScale = pause ? 0 : 1;

    }


}
