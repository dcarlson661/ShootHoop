using UnityEngine;
using System.Collections;
using UnityEngine.UI;


//Remember this script is on the stats text on the game over scene
public class GameOverScoreDisplay : MonoBehaviour {

    AbsorbeScoreKeeper gameOverScoreAbsorber;
    Text text;

	// Use this for initialization
	void Start () {
        gameOverScoreAbsorber = FindObjectOfType<AbsorbeScoreKeeper>();
        text = GetComponent<Text>();  //the stats text because we drug this script onto stats in the ue
	}
	
	// Update is called once per frame
	void Update () {
        float p            = (gameOverScoreAbsorber.score / gameOverScoreAbsorber.attemps) * 100f;
        string strStatus = string.Format("Score: {0}\nAttemps: {1}\nPercentage: {2}%",
                           gameOverScoreAbsorber.score, 
                           gameOverScoreAbsorber.attemps,
                           p);
        text.text = strStatus;
	}
}
