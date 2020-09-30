using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject phaseGoal;

    [SerializeField]
    private int requiredPoints = 100;
    
    // Update is called once per frame
    void Update()
    {
        if(PlayerStatus.Pontos >= requiredPoints){
            phaseGoal.SetActive(true);
        }
    }
}
