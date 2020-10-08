using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuScript : MonoBehaviour
{

    private LevelChangerScript levelChanger;

    // Start is called before the first frame update
    void Start()
    {
        levelChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartLevel(){
        Time.timeScale = 1;
        var player = GameObject.Find("Player");
        player.GetComponent<PlayerScript>().resetPoints();
        Destroy(player);
        levelChanger.FadeToLevel(SceneManager.GetActiveScene().name);
    }

    public void ExitToMainMenu(){
        Time.timeScale = 1;
        levelChanger.FadeToLevel("MainMenu");
    }
}
