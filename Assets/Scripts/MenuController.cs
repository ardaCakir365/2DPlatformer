using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes available. End of game.");
            // You can implement other logic here, such as returning to the main menu
        }
    }

     public void PlayGame()
    {
       LoadNextScene(); //returns next level
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the game
    }
}

