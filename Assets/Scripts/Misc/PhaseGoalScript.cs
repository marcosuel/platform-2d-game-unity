using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseGoalScript : MonoBehaviour
{

    private SceneManagerScript sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.Find("Managers/SceneManager").GetComponent<SceneManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            sceneManager.LoadNextScene();
        }
    }
}
