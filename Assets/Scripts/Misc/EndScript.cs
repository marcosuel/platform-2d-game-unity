using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public void ReturnToMenu(){
        var lvlChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
        lvlChanger.FadeToLevel(lvlChanger.nextLevelName);
    }
}
