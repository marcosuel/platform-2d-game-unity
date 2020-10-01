using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            PlayerScript script = other.gameObject.GetComponent<PlayerScript>();
            if(!script.states.isHiding){
                script.takeDamage();
            }
        }
    }

    
}
