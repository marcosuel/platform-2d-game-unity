using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] throwers = null;

    private bool isOnCooldown = false;
    private float cooldownTime = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isOnCooldown){
            cooldownTime -= Time.fixedDeltaTime;
            if(cooldownTime <= 0){
                isOnCooldown = false;
                cooldownTime = 2f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && !isOnCooldown){
            isOnCooldown = true;
            gameObject.GetComponent<Animator>().SetBool("Pressed", true);
            GameObject.Find("Managers/SoundManager").GetComponent<SoundManagerScript>().PlaySound("pressurePlate");
            foreach(GameObject t in throwers){
                t.GetComponent<ThrowerScript>().Throw();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            Invoke("ResetAnimation", 2f);
        }
    }

    private void ResetAnimation(){
        gameObject.GetComponent<Animator>().SetBool("Pressed", false);
    }
}
