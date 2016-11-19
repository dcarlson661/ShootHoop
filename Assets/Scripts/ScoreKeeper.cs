using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public int score   = 0;
    public int attemps = 0;

	// Use this for initialization
	void Start () {
        //gameObject is a field from inheritance
        // this will preserve but remember we then have to destroy it ourselve 
        DontDestroyOnLoad(gameObject); //gameObject is in ScoreKeeper by  means of MonoBehaviour
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore(int amount)
    {
        score += amount;
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
    public void IncrementAttemps(int amount)
    {
        attemps += amount;
    }

}
