using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript = null;

    internal float xAxis;

    internal bool isJumpPressed;
    internal bool isActionPressed;

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        
        isJumpPressed = Input.GetKeyDown(KeyCode.Space);

        isActionPressed = Input.GetKeyDown(KeyCode.C);
    }
}
