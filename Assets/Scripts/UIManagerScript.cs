using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    private Text ui_points;

    private void Start()
    {
        ui_points = GameObject.Find("HUD/Points").GetComponent<Text>();
        ui_points.text = PlayerStats.Pontos.ToString();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)){
            PlayerStats.Pontos += 10;
            ui_points.text = PlayerStats.Pontos.ToString();
        }
    }


}
