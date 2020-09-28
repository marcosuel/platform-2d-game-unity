using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    //[SerializeField]
    //PlayerScript playerScript = null;

    internal float xAxis;

    internal bool isJumpPressed;
    internal bool isCrounchPressed;

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        
        isJumpPressed = Input.GetKeyDown(KeyCode.Space);

        isCrounchPressed = Input.GetKey(KeyCode.C);
    }
}
