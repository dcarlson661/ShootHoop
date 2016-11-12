using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    Text score;
    Text timeText;
    ScoreKeeper scoreKeeper; //one on the scene

    // Use this for initialization
    void Start () {
        score       = GetComponent<Text>();
        timeText    = GetComponent<Text>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + scoreKeeper.score.ToString();
	
	}
}
