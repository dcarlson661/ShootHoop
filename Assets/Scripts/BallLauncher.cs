using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    //this, BallSpawner, is on the maincamera in the UE
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

            rb.velocity = Vector3.forward * ballSpeed;
        }
    }

}
