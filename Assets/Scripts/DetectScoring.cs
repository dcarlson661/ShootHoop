using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

    public int scorePerHit = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //this DetectScoring object is on the Target
    void OnCollisionEnter(Collision collision)
    {
        //FindObjectOfType unity finds objects not necessarily gameobjects
        // but in the heirarchy 
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(scorePerHit);
    }


}
