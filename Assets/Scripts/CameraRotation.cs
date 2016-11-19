using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

    //this, CameraRotation, is a script put on the maincamera in the UE.
    //  now we cause use this script to handle our moving around
    //   by changing our tranform rotation based on mouse or joystick
    //basically it changes what direction we're looking at through the camera

    //private Camera camera;

    public float rotationSpeed = 5.0f;

	// Use this for initialization
	void Start ()
    {
       // Camera camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //match the string argument with the UE editor/pref/input name
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        //now apply the mouse location to the Quaternion (rotation) 
        // of the camera rotation (its view);
        Camera camera = GetComponentInChildren<Camera>();
        //transform is this (player), the camerarotation script that's on the player, think "body"
        // this tilts the body, so to speak.
        transform.localRotation        = Quaternion.Euler(0f, mouseX, 0f)  * transform.localRotation;
        //the camera is a child of Player and can be thought of as the head. (from the two cube example)
        //  thus giving you two objects to rotate in game view when playing.
        camera.transform.localRotation = Quaternion.Euler(-mouseY, 0F, 0f) * camera.transform.localRotation;

    }
}
