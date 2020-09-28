using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    #region Variables
    //Store a reference to all the sub player scripts
    [SerializeField]
    internal PlayerInputScript inputScript = null;
    
    [SerializeField]
    internal PlayerMovementScript movementScript = null;

    [SerializeField]
    internal PlayerCollisionScript collisionScript = null;

    [SerializeField]
    internal PlayerAnimationScript animationScript = null;

    [SerializeField]
    internal PlayerStatesScript states = null;

    internal Rigidbody2D rb2d = null;
    internal Animator anim = null;


    [SerializeField]
    internal float moveSpeed = 5f;
    
    [SerializeField]
    internal float jumpForce = 10f;
    internal int currentLives = 3;

    [SerializeField]
    internal int maxLives = 3;

    #endregion

    #region Monobehavior methods
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    #endregion

    #region Private methods


    #endregion

    #region Public methods

    public int getCurrentLives(){
        return 1;
    }

    public int getMaxLives(){
        return 1;
    }

    #endregion
}
