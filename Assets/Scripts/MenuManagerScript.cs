using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{

    public string firstScene;
    public int vidas, pontos;
    

    public void startGame(){
        PlayerStatus.Vidas = vidas;
        PlayerStatus.Pontos = pontos;

        SceneManager.LoadScene(firstScene);
    }

    public void exitGame(){
        Application.Quit();
    }
}
