using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string nomScene;

    public void playGame() {
        Debug.Log("Play");
        // Ajouter le nom de la scene
        // SceneManagement.LoadScene(nomScene);
    }

    public void quitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
