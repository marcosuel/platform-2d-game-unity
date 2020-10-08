using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject phaseGoal = null;

    private LevelChangerScript levelChanger;

    [SerializeField]
    private int requiredPoints = 100;

    private void Start()
    {
        levelChanger = GameObject.Find("Managers/LevelChanger").GetComponent<LevelChangerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStatus.Pontos >= requiredPoints){
            phaseGoal.SetActive(true);
        }
    }

    public void RestartScene(){
        if(PlayerStatus.Vidas >= 0){
            Destroy(GameObject.Find("Player"));
            levelChanger.FadeToLevel(SceneManager.GetActiveScene().name);
        }else{
            levelChanger.FadeToLevel("MainMenu");
        }
        
    }

    public int RequiredPoints{
        get{
            return requiredPoints;
        }
        set{
            requiredPoints = value;
        }
    }
}
