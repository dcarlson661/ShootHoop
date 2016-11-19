using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    //this, BallSpawner, is on the maincamera in the UE.
    //                   and the camera is a child of the player
    // here we are going to create a reference to our Basketball prefab
    // remember making it public makes it available in the UE
    public GameObject ballPrefab;

    public float ballSpeed = 5.0f;  //public so the designer can see it in the UE

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementAttemps(1);
            //Instantiate returns a GameObject of <T> of what it created.
            GameObject instance = Instantiate(ballPrefab);
            //this ballspawner is on the camera, which is a child of player
            //instance is the ballPrefab so here we're setting
            // the ballPrefab (instance) transform.position to that of the
            //  transform.position and "this" balllauncher script is on the player
            //so the ball will be behind the player when we launch
            instance.transform.position = transform.position;
            //now we can use the instance to get componenets of the created object
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            //possible because the camera is a child and this script object is attached to the player
            Camera camera = GetComponentInChildren<Camera>();
            Vector3 myLaunchVector = new Vector3(0f, 0f, 1f);
            rb.velocity = camera.transform.rotation * myLaunchVector * ballSpeed;
            //ORG rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
        }
    }

}
