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

    [SerializeField]
    private GameObject playerHurtPrefab = null;

    internal Rigidbody2D rb2d = null;
    internal Animator anim = null;

    private UIManagerScript UIManager;


    [SerializeField]
    internal float moveSpeed = 5f;
    
    [SerializeField]
    internal float jumpForce = 10f;
    [SerializeField]
    internal float crunchJumpModifier = 1.25f;

    internal int startPoints = 0;
    #endregion

    #region Monobehavior methods
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        UIManager = GameObject.Find("Managers/UIManager").GetComponent<UIManagerScript>();
        startPoints = PlayerStatus.Pontos;
    }


    #endregion

    #region Private methods


    #endregion

    #region Public methods

    public void addPoints(int points){
        PlayerStatus.Pontos += points;
        UIManager.UpdateUI();
    }

    public void takeDamage(){
        resetPoints();
        Destroy(this.gameObject);
        GameObject.Find("Managers/SoundManager").GetComponent<AudioSource>().volume = 0.05f;
        GameObject.Find("Managers/SoundManager").GetComponent<SoundManagerScript>().PlaySound("lose");
        GameObject.Find("Managers/BackgroundMusic").GetComponent<AudioSource>().Stop();
        Instantiate(playerHurtPrefab, transform.position, transform.rotation);
    }

    public void resetPoints(){
        PlayerStatus.Pontos = this.startPoints;
    }

    #endregion
}
