using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    //public static AudioClip playerJumpSound, pressurePlateSound, collectSound, shootSoud;
    private AudioSource audioSource;

    private Dictionary<string, (AudioClip audio, float volume)> sounds = new Dictionary<string, (AudioClip audio, float volume)>();


    // Start is called before the first frame update
    void Start()
    {
        sounds.Add("jump", (Resources.Load<AudioClip>("Sounds/Fx/jump"), 0.3f));
        sounds.Add("pressurePlate", (Resources.Load<AudioClip>("Sounds/Fx/pressure-plate"), 0.4f));
        sounds.Add("shoot", (Resources.Load<AudioClip>("Sounds/Fx/shoot"), 0.4f));
        sounds.Add("collect", (Resources.Load<AudioClip>("Sounds/Fx/collect"), 0.6f));
        sounds.Add("enemyHit", (Resources.Load<AudioClip>("Sounds/Fx/enemy-hit"), 0.2f));
        sounds.Add("lose", (Resources.Load<AudioClip>("Sounds/Fx/lose"), 0.1f));
        sounds.Add("clear", (Resources.Load<AudioClip>("Sounds/Fx/level-complete"), 0.2f));

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySound(string clip){
        audioSource.PlayOneShot(sounds[clip].audio);
        audioSource.volume = sounds[clip].volume;
    }
}
