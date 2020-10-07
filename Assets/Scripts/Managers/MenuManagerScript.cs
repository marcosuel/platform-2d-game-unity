using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public int vidas, pontos;
    
    private LevelChangerScript levelChanger;

    public GameObject mainMenuUI;
    public GameObject optMenuUI;

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

    public void setLangToEnglish(){
        FileScript.Language = "/En";
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void setLangToPtBr(){
        FileScript.Language = "/Pt-br";
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OpenOptMenu(){
        optMenuUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void OptMenuReturn(){
        optMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
}
