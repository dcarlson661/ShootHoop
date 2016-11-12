using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    //LevelManager is on each scene with each scene having a 0 or >0 value for timetillnextlevel
    // on each frame update if this is > 0 then we start a countdown
    public float timeTillNextLevel = 0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
        //remember each scene can set timetill default value to 0 to disable the countdown
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;
            if (timeTillNextLevel <= 0)
            {
                print(timeTillNextLevel);
                LoadSceneByName("NextSceneForward");
            }
        }
        
        
    }

    public void LoadScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1); //load next scene in build settings build order
    }
    public void LoadSceneByName(string sceneName)
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        print(sceneName);
        switch (sceneName)
        {
            case "NextSceneForward":
            case "FromSplash":
                SceneManager.LoadScene(currentIndex + 1);
                break;
            case "PreviousScene":
            case "FromGameOver":
                SceneManager.LoadScene(currentIndex - 1);
                break;
            case "Quit":
                Application.Quit();
                return;
            default:
                return;
        }
    }

}
