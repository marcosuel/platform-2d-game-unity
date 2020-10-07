using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField]
    private string id = "";
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = FileScript.GetLineFromKey(id);
    }
}
