using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundElements : MonoBehaviour
{

    [SerializeField]
    private float speed = 2f;

    [SerializeField]
    private Transform neighbour = null;

    public void Move(){
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime);
    }

    public void SnapToNeighbour(){
        transform.position = new Vector2(neighbour.position.x, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Reset"){
            SnapToNeighbour();
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
