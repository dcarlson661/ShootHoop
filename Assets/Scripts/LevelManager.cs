using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
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
            case "FromSplash":
                SceneManager.LoadScene(currentIndex + 1);
                break;
            case "FromGameOver":
                SceneManager.LoadScene(currentIndex - 1);
                break;
            case "Quit":
                Application.Quit();
                return;
        }
    }

}
