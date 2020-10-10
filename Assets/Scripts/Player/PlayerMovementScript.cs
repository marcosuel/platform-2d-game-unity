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
        Crounch();
        Move();
    }

    #region Private methods

    private void Crounch(){
        //if crunch button is pressed and character is on ground
        if(playerScript.inputScript.isCrounchPressed && playerScript.states.isOnGround){
            playerScript.states.isCrounching = true;
            playerScript.inputScript.xAxis = 0f;
        }else{
            playerScript.states.isCrounching = false;
        }

    }

    private void Move(){
        playerScript.states.isMoving = playerScript.inputScript.xAxis == 0f ? false : true;
        playerScript.rb2d.velocity = new Vector2(playerScript.inputScript.xAxis * playerScript.moveSpeed, playerScript.rb2d.velocity.y);
    }

    private void Jump(){
        if(playerScript.inputScript.isJumpPressed && playerScript.states.isOnGround){
            var jumpModifier = playerScript.states.isCrounching ? playerScript.crunchJumpModifier : 1;
            playerScript.rb2d.velocity = new Vector2(0f, 0f);
            playerScript.rb2d.AddForce(new Vector2(0f, playerScript.jumpForce * jumpModifier), ForceMode2D.Impulse);
            GameObject.Find("Managers/SoundManager").GetComponent<SoundManagerScript>().PlaySound("jump");
        }
    }
    #endregion
}
