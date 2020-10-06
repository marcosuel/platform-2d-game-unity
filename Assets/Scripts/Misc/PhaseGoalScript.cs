using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseGoalScript : MonoBehaviour
{

    private LevelChangerScript levelChanger;
    // Start is called before the first frame update
    void Start()
    {
        levelChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            levelChanger.FadeToLevel(levelChanger.nextLevelName);
        }
    }
}
