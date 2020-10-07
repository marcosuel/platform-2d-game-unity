using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurtScript : MonoBehaviour
{

    private UIManagerScript UIManager;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
        UIManager = GameObject.Find("Managers/UIManager").GetComponent<UIManagerScript>();
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 4, ForceMode2D.Impulse);
    }

    public void OnAnimationComplete(){
        PlayerStatus.Vidas--;
        UIManager.UpdateUI();
        GameObject.Find("Managers/GameManager").GetComponent<GameManagerScript>().RestartScene();
        Destroy(this.gameObject);
    }

}
