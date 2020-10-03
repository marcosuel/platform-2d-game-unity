using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Transform parent;

    [SerializeField]
    private Transform[] waypoints = null;

    [SerializeField]
    private float moveSpeed = 4f;

    private int indexCurrentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        moveToPoint();
    }

    void moveToPoint(){
        
        if(this.gameObject.tag == "Enemy"){
            if(parent.position.x >= waypoints[indexCurrentWaypoint].position.x){
                parent.eulerAngles = Vector3.zero;
            } else {
                parent.eulerAngles = new Vector3(0f, 180f, 0f);
            }
        }

        parent.position = Vector2.MoveTowards(parent.position, waypoints[indexCurrentWaypoint].position
                            , moveSpeed * Time.deltaTime);
        if(parent.position == waypoints[indexCurrentWaypoint].position){
            indexCurrentWaypoint++;
        }
        if(indexCurrentWaypoint >= waypoints.Length)
            indexCurrentWaypoint = 0;
    }
}
