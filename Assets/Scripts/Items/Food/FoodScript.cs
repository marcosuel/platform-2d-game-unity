using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{

    [SerializeField]
    private int score_points = 10;

    [SerializeField]
    private GameObject collected = null;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<PlayerScript>().addPoints(score_points);
            Destroy(this.gameObject);
            Instantiate(collected, transform.position, transform.rotation);
            GameObject.Find("Managers/SoundManager").GetComponent<SoundManagerScript>().PlaySound("collect");
        }
    }
}
