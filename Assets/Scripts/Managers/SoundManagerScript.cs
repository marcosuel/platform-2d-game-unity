using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    //public static AudioClip playerJumpSound, pressurePlateSound, collectSound, shootSoud;
    private AudioSource audioSource;

    private Dictionary<string, AudioClip> sounds = new Dictionary<string, AudioClip>();



    // Start is called before the first frame update
    void Start()
    {
        sounds.Add("jump", Resources.Load<AudioClip>("Sounds/Fx/jump"));
        sounds.Add("pressurePlate", Resources.Load<AudioClip>("Sounds/Fx/pressure-plate"));
        sounds.Add("shoot", Resources.Load<AudioClip>("Sounds/Fx/shoot"));
        sounds.Add("collect", Resources.Load<AudioClip>("Sounds/Fx/collect"));
        sounds.Add("enemyHit", Resources.Load<AudioClip>("Sounds/Fx/enemy-hit"));
        sounds.Add("lose", Resources.Load<AudioClip>("Sounds/Fx/lose"));
        sounds.Add("clear", Resources.Load<AudioClip>("Sounds/Fx/level-complete"));

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySound(string clip){
        audioSource.PlayOneShot(sounds[clip]);
    }
}
