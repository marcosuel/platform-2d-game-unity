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
        foreach(GameObject t in throwers){
            t.GetComponent<ThrowerScript>().Throw();
        }
    }
}
