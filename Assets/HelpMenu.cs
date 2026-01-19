using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject helpPanel;

    void Update()
    {
        // Required: quit game with ESC
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void ToggleHelp()
    {
        bool show = !helpPanel.activeSelf;
        helpPanel.SetActive(show);

        // Pause / Resume game
        Time.timeScale = show ? 0f : 1f;
    }
}
