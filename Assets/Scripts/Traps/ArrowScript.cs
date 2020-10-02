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
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2d.velocity = dir * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject, 2);
    }

    public void setDir(Vector2 direction){
        this.dir = Vector2.up;
        Debug.Log("tudo ok");
    }
}
