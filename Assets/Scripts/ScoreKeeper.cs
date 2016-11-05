using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    private int score=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IncrementScore(int amount)
    {
        score += amount;
        print("IncrementScore " + score);
    }

}
