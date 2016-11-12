using UnityEngine;
using System.Collections;

//remember this is on the gameover scene
// and activated when the timer runs out and this scene is Loaded
public class AbsorbeScoreKeeper : MonoBehaviour {
    public int score;
    public int attemps;

    // Use this for initialization
    void Start () {
        //the scorekeeper is not destroyed on scene load (dontdestroyonload)
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = attemps = 0;
        if (oldKeeper)  //but if we have a score the use its values
        {
            score                 = oldKeeper.score;
            attemps               = oldKeeper.attemps;
            Destroy(oldKeeper);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
