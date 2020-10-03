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
    // Start is called before the first frame update
    void Start()
    {
        countdownText = transform.GetComponent<Text>();
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 9.5 && currentTime > 0){
            countdownText.color = Color.red;
        }

        if(currentTime <= 0){
            currentTime = 0f;
            countdownText.color = Color.black;
        }
        countdownText.text = currentTime.ToString("0");
    }
    
}
