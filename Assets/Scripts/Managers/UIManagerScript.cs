using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    private Text ui_pontos;
    private Text ui_vidas;

    private PlayerScript playerScript;

    private GameManagerScript gmScript;

    [SerializeField]
    private GameObject pauseMenuUI = null;

    private void Start()
    {
        gmScript = GameObject.Find("Managers/GameManager").GetComponent<GameManagerScript>();;
        ui_pontos = GameObject.Find("HUD/Pontos/Text").GetComponent<Text>();
        ui_vidas = GameObject.Find("HUD/Vidas/Text").GetComponent<Text>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        UpdateUI();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Player")){
            SetPauseMenuActive();
        }


        /*
        if(Input.GetKeyDown(KeyCode.V)){
            playerScript.addPoints(10);
        }
        if(Input.GetKeyDown(KeyCode.B)){
            playerScript.takeDamage();
        }*/
    }

    public void SetPauseMenuActive(){
        pauseMenuUI.SetActive(!pauseMenuUI.activeInHierarchy);
        Time.timeScale = pauseMenuUI.activeInHierarchy ? 0 : 1;
        //pause audio too
        AudioListener.pause = pauseMenuUI.activeInHierarchy ? true : false;
    }

    public void UpdateUI(){
        if(PlayerStatus.Pontos >= gmScript.RequiredPoints){
            ui_pontos.color = Color.green;
        }
        ui_pontos.text = PlayerStatus.Pontos.ToString();
        ui_vidas.text = "x " + (PlayerStatus.Vidas >= 0 ? PlayerStatus.Vidas.ToString() : 0.ToString());
    }


}
