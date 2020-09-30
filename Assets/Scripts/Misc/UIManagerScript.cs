using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    private Text ui_pontos;
    private Text ui_vidas;

    private void Start()
    {
        ui_pontos = GameObject.Find("HUD/Pontos/Text").GetComponent<Text>();
        ui_vidas = GameObject.Find("HUD/Vidas/Text").GetComponent<Text>();
        UpdateUI();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)){
            PlayerStatus.Pontos += 10;
            ui_pontos.text = PlayerStatus.Pontos.ToString();
        }
        if(Input.GetKeyDown(KeyCode.B)){
            PlayerStatus.Vidas--;
            ui_vidas.text = "x " + PlayerStatus.Vidas.ToString();
        }
    }

    public void UpdateUI(){
        ui_pontos.text = PlayerStatus.Pontos.ToString();
        ui_vidas.text = "x " + PlayerStatus.Vidas.ToString();
    }


}
