using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private string nextScene = "salle1";

    public void playGame() {
        Debug.Log("Play");
        // Ajouter le nom de la scene
        SceneManager.LoadScene(nextScene);
    }

    public void quitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
