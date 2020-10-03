using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    private float currentTime = 0f;
    
    [SerializeField]
    private float startTime = 99f;

    private Text countdownText;

    private bool ended = false;
    // Start is called before the first frame update
    void Start()
    {
        countdownText = transform.GetComponent<Text>();
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= !ended ? Time.deltaTime : 0;

        if(currentTime <= 9.5 && currentTime > 0){
            countdownText.color = Color.red;
        }

        if(currentTime <= 0 && !ended){
            countdownText.color = Color.black;
            ended = true;
            SpawnScope();
        }
        countdownText.text = currentTime.ToString("0");
    }

    void SpawnScope(){
        GameObject.Find("ScopeSpawnner").GetComponent<SpawnnerScript>().Spawn();
    }
    
}
