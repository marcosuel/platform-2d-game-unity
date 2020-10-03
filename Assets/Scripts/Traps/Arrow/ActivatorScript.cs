using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] throwers = null;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            gameObject.GetComponent<Animator>().SetBool("Pressed", true);
            foreach(GameObject t in throwers){
                t.GetComponent<ThrowerScript>().Throw();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            gameObject.GetComponent<Animator>().SetBool("Pressed", false);
        }
    }
}
