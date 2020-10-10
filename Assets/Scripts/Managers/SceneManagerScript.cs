using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    private string mainMenuScene = "MainMenu";
    public string nextScene;
    public string prevScene;

    public void LoadNextScene(){
        SceneManager.LoadScene(nextScene);
    }

    public void LoadPrevScene(){
        SceneManager.LoadScene(prevScene);
    }

    public void RestartCurrentScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RestartGameScene(){
        SceneManager.LoadScene(mainMenuScene);
    }
}
