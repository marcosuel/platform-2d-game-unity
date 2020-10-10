using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject child = null;

    [SerializeField]
    private GameObject playerIdlePrefab = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            GetComponent<BlackBarsScript>().Activate = true;
            Instantiate(playerIdlePrefab, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            child.GetComponent<ChildScript>().StartAnimation();
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            var lvlChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
            lvlChanger.FadeToLevel(lvlChanger.nextLevelName);
        }
    }
}
