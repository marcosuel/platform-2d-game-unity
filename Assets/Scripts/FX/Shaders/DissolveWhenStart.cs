using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveWhenStart : MonoBehaviour
{
    Material material;

    [ColorUsage(true, true)]
    public Color color;

    public float scale;

    bool isDissolving = false;
    float fade = 2f;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
        isDissolving = true;
        material.SetColor("_Color", color);
        material.SetFloat("_Scale", scale);
    }

    // Update is called once per frame
    void Update()
    {
        if(isDissolving){
            fade -= Time.deltaTime;

            if(fade <= 0f){
                fade = 0;
                Destroy(this.gameObject);
            }
        }
        material.SetFloat("_Fade", fade/2);
    }
}
