using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart() {
        SceneManager.LoadScene(1);
    }

    public void Menu() {
        SceneManager.LoadScene(0);
    }

    public void Quit() {
        Debug.Log("quit");
        Application.Quit();
    }
}