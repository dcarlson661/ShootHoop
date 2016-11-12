using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    Text clock;
    LevelManager levelManager;
	// Use this for initialization
	void Start () {
        clock        = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        clock.text = levelManager.timeTillNextLevel.ToString("F0");
	}
}
