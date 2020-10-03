using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterScopeScript : MonoBehaviour
{
    [SerializeField]
    private float xSpeed = 0f;
    
    [SerializeField]
    private float ySpeed = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player")){
            GameObject plr = GameObject.Find("Player");
            float xPos = Mathf.Lerp(transform.position.x, plr.transform.position.x, xSpeed * Time.deltaTime);
            float yPos = Mathf.Lerp(transform.position.y, plr.transform.position.y, ySpeed * Time.deltaTime);
            transform.position = new Vector2(xPos, yPos);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            Debug.Log("POW");
        }
    }
}
