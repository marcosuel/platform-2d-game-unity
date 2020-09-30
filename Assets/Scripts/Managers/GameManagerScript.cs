using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject phaseGoal = null;

    private SceneManagerScript sceneManager;

    [SerializeField]
    private int requiredPoints = 100;

    private void Start()
    {
        sceneManager = GameObject.Find("Managers/SceneManager").GetComponent<SceneManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStatus.Pontos >= requiredPoints){
            phaseGoal.SetActive(true);
        }
        if(PlayerStatus.Vidas < 0){
            sceneManager.RestartGameScene();
        }
    }

    public void RestartScene(){
        sceneManager.RestartCurrentScene();
    }
}
