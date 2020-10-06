using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChangerScript : MonoBehaviour
{

    public Animator animator;


    public string nextLevelName;
    private string levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            FadeToLevel("Scene01");
        }
    }

    public void FadeToLevel(string levelName){
        levelToLoad = levelName;
        animator.SetTrigger("FadeOut");
    } 

    public void OnFadeComplete(){
        SceneManager.LoadScene(levelToLoad);
    }
}
