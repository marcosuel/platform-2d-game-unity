using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    public AudioClip first;
    public AudioClip timeOver;

    private AudioSource audioSource;

    private bool fade = false;
    private float time = 0, endTime = 5;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = first;
        audioSource.volume = 0.04f;
        audioSource.Play();
    }

    public void Play(){
        audioSource.Play();
    }

    public void SetTimeOverMusic(){
        audioSource.volume = 0.05f;
        audioSource.clip = timeOver;
    }

    private void Update()
    {
        if(fade)    Fade();
    }

    public void StartFade(){
        fade = true;
    }

    public void Fade(){
        time += Time.deltaTime;
        audioSource.volume = time >= endTime ? 0 : audioSource.volume -=0.008f * Time.deltaTime;
    }
}
