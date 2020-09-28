using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript = null;

    // Update is called once per frame
    void Update()
    {
        if(playerScript.inputScript.xAxis == 0f){
            playerScript.isMoving = false;
        }else{
            playerScript.isMoving = true;
            transform.eulerAngles = new Vector3(0f, playerScript.inputScript.xAxis > 0 ? 0 : 180, 0);
        }
        playerScript.anim.SetBool("isMoving", playerScript.isMoving);
        playerScript.anim.SetBool("isOnGround", playerScript.isOnGround);
        playerScript.anim.SetBool("isCrounching", playerScript.inputScript.isCrounchPressed);
        playerScript.anim.SetFloat("vSpeed", playerScript.rb2d.velocity.y);
    }
}
