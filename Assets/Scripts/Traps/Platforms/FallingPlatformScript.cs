using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformScript : MonoBehaviour
{
    private TargetJoint2D joint2D;
    
    private BoxCollider2D boxCollider2D;
    
    [SerializeField]
    private float fallingTime = 2;

    [SerializeField]
    private float spawnTime = 4;
    
    private void Start()
    {
        joint2D = GetComponent<TargetJoint2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Invoke("Falling", fallingTime);
            //Destroy(this.gameObject, fallingTime);
        }
    }

    void Falling(){
        joint2D.enabled = false;
        boxCollider2D.isTrigger = true;
        Invoke("Spawn", spawnTime);
        Destroy(this.gameObject, spawnTime+1);
    }

    void Spawn(){
        transform.parent.GetComponent<SpawnnerScript>().Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
