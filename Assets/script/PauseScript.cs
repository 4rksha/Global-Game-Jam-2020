using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public static bool GameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.JoystickButton7)) {
            Debug.Log("Start pressed");
            if (GameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume () {
        transform.Find("PauseMenuCanvas").gameObject.SetActive(false);
        GameIsPaused = false;
    }

    void Pause() {
        transform.Find("PauseMenuCanvas").gameObject.SetActive(true);
        GameIsPaused = true;
    }

    public void GoToMenu() {
        Resume();
        SceneManager.LoadScene("MainMenu");
    }

    public void quitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
