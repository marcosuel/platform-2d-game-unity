using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushScript : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            PlayerScript script = other.gameObject.GetComponent<PlayerScript>();
            if(script.states.isCrounching){
                script.states.isHiding = true;
                other.gameObject.GetComponent<Renderer>().sortingOrder = 1;
            }else{
                script.states.isHiding = false;
                other.gameObject.GetComponent<Renderer>().sortingOrder = 3;
            }
        }
    }
}
