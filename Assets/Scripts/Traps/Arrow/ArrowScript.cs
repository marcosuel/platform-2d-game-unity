using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public Vector2 dir;
    
    [SerializeField]
    private float moveSpeed = 10f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 4);
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2d.velocity = dir * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            Destroy(this.gameObject, 0);
        } else {
            Destroy(this.gameObject, 2);
        }
    }

}
