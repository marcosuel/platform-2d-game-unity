using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private Transform parent;

    [SerializeField]
    private Transform[] waypoints = null;

    [SerializeField]
    private float moveSpeed = 4f;

    private int indexCurrentWaypoint = 0;


    private float timer = 0.5f;
    private float timerCount = 0;

    private bool stop = false;
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
        //parent.position = Vector2.Lerp(parent.position, waypoints[indexCurrentWaypoint].position, Time.deltaTime);
        if(stop){
            timerCount += Time.deltaTime;
            if(timerCount >= timer){
                stop = false;
                timerCount = 0;
            }
        }
        if(!stop) parent.position = Vector2.MoveTowards(parent.position, waypoints[indexCurrentWaypoint].position
                            , moveSpeed * Time.deltaTime);
        if(parent.position == waypoints[indexCurrentWaypoint].position && !stop){
            indexCurrentWaypoint++;
            stop = true;
        }
        if(indexCurrentWaypoint >= waypoints.Length)
            indexCurrentWaypoint = 0;
    }
}
