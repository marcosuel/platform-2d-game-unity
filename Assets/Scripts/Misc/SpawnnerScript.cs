using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab = null;
    
    public void Spawn(){
        GameObject obj = Instantiate(prefab, transform.position, transform.rotation);
        obj.transform.parent = this.transform;
    }
}
