using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void FixedUpdate()
    {
        Move(playerScript.inputScript.xAxis);
    }

    #region Private methods

    private void Move(float xAxis){
        if(xAxis == 0f){
            playerScript.isMoving = false;
            //anim.SetBool("isMoving", false);
        }else{
            playerScript.isMoving = true;
            //anim.SetBool("isMoving", true);
            transform.eulerAngles = new Vector3(0f, xAxis > 0 ? 0 : 180, 0);
        }
        playerScript.rb2d.velocity = new Vector2(xAxis * playerScript.moveSpeed, playerScript.rb2d.velocity.y);
    }

    private void Jump(){
        if(playerScript.inputScript.isJumpPressed && playerScript.isOnGround){
            playerScript.rb2d.velocity = new Vector2(0f, 0f);
            playerScript.rb2d.AddForce(new Vector2(0f, playerScript.jumpForce), ForceMode2D.Impulse);
        }
    }
    #endregion
}
