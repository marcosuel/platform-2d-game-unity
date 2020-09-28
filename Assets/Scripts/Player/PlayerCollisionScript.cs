using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
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
        playerScript.isOnGround = Physics2D.BoxCast(playerScript.groundChecker.position, new Vector2(0.25f, 0.5f), 0f, Vector2.zero, 4f, playerScript.groundLayer);
    }

    #region Private methods

    //Draw BoxCast
    private void drawBoxCast(){
        Vector2 origin = playerScript.groundChecker.position;
        Vector2 size = new Vector2(0.25f, 0.5f);
        var angle = 0f;
        var direction = Vector2.zero;
        var distance = 4f;
        playerScript.isOnGround = Physics2D.BoxCast(origin, size, angle, direction, distance, playerScript.groundLayer);
        Debug.Log(playerScript.isOnGround);
        Vector2 t_tl = origin + new Vector2(-size.x * 0.5f, size.y * 0.5f);
        Vector2 t_tr = origin + new Vector2(size.x * 0.5f, size.y * 0.5f);
        Vector2 t_bl = origin + new Vector2(-size.x * 0.5f, -size.y * 0.5f);
        Vector2 t_br = origin + new Vector2(size.x * 0.5f, -size.y * 0.5f);

        Debug.DrawLine(t_tl, t_tr, Color.red);
        Debug.DrawLine(t_bl, t_br, Color.red);
        Debug.DrawLine(t_tl, t_bl, Color.red);
        Debug.DrawLine(t_tr, t_br, Color.red);
    }

    #endregion
}
