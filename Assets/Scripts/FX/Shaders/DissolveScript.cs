using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveScript : MonoBehaviour
{

    Material material;

    bool isDissolving = false, isAppearing = false;
    float fade = 1f;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V) && !isAppearing){
            isDissolving = true;
        }

        if(Input.GetKeyDown(KeyCode.B) && !isDissolving && fade != 1f){
            isAppearing = true;
        }


        if(isDissolving){
            fade -= Time.deltaTime;

            if(fade <= 0f){
                fade = 0;
                isDissolving = false;
            }
        }
        if(isAppearing){
            fade += Time.deltaTime;

            if(fade >= 1f){
                fade = 1;
                isAppearing = false;
            }
        }


        material.SetFloat("_Fade", fade);
    }
}
