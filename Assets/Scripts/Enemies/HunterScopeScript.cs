using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterScopeScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    
    [SerializeField]
    private float shootTime = 1f;
    private float countTime = 0;

    private bool shoot = false;

    private Animator animator;

    [SerializeField]
    private GameObject bullet = null; 
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") && !shoot){
            GameObject plr = GameObject.Find("Player");

            //Move with moveTowards

            transform.position = Vector2.MoveTowards(transform.position, plr.transform.position, speed * Time.deltaTime);

            //Move with learp
            /*
            float xPos = Mathf.Lerp(transform.position.x, plr.transform.position.x, speed * Time.deltaTime);
            float yPos = Mathf.Lerp(transform.position.y, plr.transform.position.y, speed * Time.deltaTime);
            transform.position = new Vector2(xPos, yPos);
            */
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            animator.SetBool("Locked", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && !shoot){
            animator.SetBool("Locked", false);
            countTime = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            countTime += Time.fixedDeltaTime;
            if(countTime >= shootTime && !shoot){
                shoot = true;
                animator.SetTrigger("Shoot");
                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
    }

    public void selfDestruction(){
        //GameObject.Find("ScopeSpawnner").GetComponent<SpawnnerScript>().Spawn();
        Destroy(this.gameObject);
    }

}
