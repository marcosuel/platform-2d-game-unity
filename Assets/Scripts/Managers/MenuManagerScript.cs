using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public int vidas, pontos;
    
    private LevelChangerScript levelChanger;

    private void Start()
    {
        levelChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
    }

    public void startGame(){
        PlayerStatus.Vidas = vidas;
        PlayerStatus.Pontos = pontos;

        levelChanger.FadeToLevel(levelChanger.nextLevelName);
    }

    public void startTutorial(){
        PlayerStatus.Vidas = 99;
        PlayerStatus.Pontos = pontos;
        //tutorial scene name
        levelChanger.FadeToLevel("Scene00");
    }
    public void exitGame(){
        Application.Quit();
    }
}
