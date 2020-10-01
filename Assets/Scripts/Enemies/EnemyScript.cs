using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private int health = 1;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        var rb2d = other.gameObject.GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0f, 0f);
        rb2d.AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);
        health--;
        if(health <= 0){
            Destroy(this.transform.parent.gameObject);
        }
    }
}
