using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseGoalScript : MonoBehaviour
{

    private LevelChangerScript levelChanger;

    public GameObject idleScenePrefab;
    // Start is called before the first frame update
    void Start()
    {
        levelChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            GameObject.Find("Managers/SoundManager").GetComponent<SoundManagerScript>().PlaySound("clear");
            GameObject.Find("Managers/BackgroundMusic").GetComponent<AudioSource>().Stop();
            Instantiate(idleScenePrefab, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Invoke("LoadNextLevel", 2f);
        }
    }

    private void LoadNextLevel(){
        levelChanger.FadeToLevel(levelChanger.nextLevelName);
    }
}
