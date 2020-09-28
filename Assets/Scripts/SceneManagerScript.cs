using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    public string nextScene;
    public string prevScene;

    public void LoadNextScene(){
        SceneManager.LoadScene(nextScene);
    }

    public void LoadPrevScene(){
        SceneManager.LoadScene(prevScene);
    }
}
