using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCode : MonoBehaviour
{
    // Canvases for opening and closing the credits and the main menu.
    public Canvas creditsCanvas;
    public Canvas menuCanvas;

    // Function that starts the game when you hit the play button.
    public void OpenGame()
    {
        SceneManager.LoadSceneAsync("CollinTargetScene");
    }

    // Function that quits the game when you hit the quit button.
    public void CloseGame()
    {
        Application.Quit();
    }

    // Function that opens and closes the credits.
    public void ToggleCredits()
    {
        // If the credits canvas isn't enabled, enable it and disable the main menu.
        if (!creditsCanvas.gameObject.activeSelf)
        {
            creditsCanvas.gameObject.SetActive(true);
            menuCanvas.gameObject.SetActive(false);
        }
        // Otherwise, disable the credits and enable the main menu.
        else
        {
            creditsCanvas.gameObject.SetActive(false);
            menuCanvas.gameObject.SetActive(true);
        }
    }
}
