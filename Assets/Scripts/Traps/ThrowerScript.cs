using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerScript : MonoBehaviour
{

    [SerializeField]
    private Transform spawnPoint = null;

    [SerializeField]
    private GameObject arrow = null;

    [SerializeField]
    private Vector2 dir = Vector2.zero;

    public void Throw(){
        GameObject arrowObj = Instantiate(arrow, spawnPoint.position, transform.rotation);
        arrow.GetComponent<ArrowScript>().dir = this.dir;
    }
}
