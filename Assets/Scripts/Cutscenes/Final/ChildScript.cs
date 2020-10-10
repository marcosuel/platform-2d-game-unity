using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private GameObject endText = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StartAnimation(){
        anim.SetTrigger("tree");
    }

    public void StartRunAnimation(){
        anim.SetTrigger("run");
    }

    public void StartIdleAnimation(){
        anim.SetTrigger("idle");
    }

    public void StartEndText(){
        Invoke("MusicFade", 3f);
        Invoke("Activate", 0.5f);
    }

    private void MusicFade(){
        GameObject.Find("Managers/BackgroundMusic").GetComponent<BackgroundMusic>().StartFade();
    }

    private void Activate(){
        endText.SetActive(true);
    }
}
