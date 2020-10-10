using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBarsScript : MonoBehaviour
{
    public Transform top, botton;

    public float speed = 0.5f;

    float tTargetPos, bTargetPos;

    bool activate = false;
    private void Start()
    {
        tTargetPos = top.localPosition.y - 40;
        bTargetPos = botton.localPosition.y + 40;
    }

    void Update()
    {
        if(activate){
            top.localPosition = Vector2.MoveTowards(top.localPosition, new Vector2(top.localPosition.x, tTargetPos)
                            , speed * Time.deltaTime);
            botton.localPosition = Vector2.MoveTowards(botton.localPosition, new Vector2(botton.localPosition.x, bTargetPos)
                , speed * Time.deltaTime);
            
            //top.localPosition = new Vector2(top.localPosition.x, Mathf.Lerp(top.localPosition.y, tTargetPos, speed * Time.deltaTime));
            //botton.localPosition = new Vector2(botton.localPosition.x, Mathf.Lerp(botton.localPosition.y, bTargetPos, speed * Time.deltaTime));
        }
    }

    public bool Activate{
        get{
            return activate;
        }
        set{
            activate = value;
        }
    }

}
