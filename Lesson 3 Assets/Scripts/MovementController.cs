using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Copyright (c) Jaydon Reap (Ficus Technologies) 2018
 * 
 * ACM Example Unity Demo
 **/

// Main class, in Unity all classes inherit from MonoBehavior.
// We won't go into too much detail on what example this class does, but think of it
// as the way our script communicates with the Unity engine
public class MovementController : MonoBehaviour {

    // These are special Vector3 variables that Unity provides
    // They represent a point (or direction in this case) in the 3-D space
    Vector3 forward = Vector3.forward;
    Vector3 backwards = Vector3.back;
    Vector3 right = Vector3.right;
    Vector3 left = Vector3.left;

    // We need this to remember what the last position of the cube was
    Vector3 orgposition;

    // This is a special unity variable that references the information of where a object is in world space
    // In our case we need this to allow us to move our cube
    Transform cubie;

    // GameObjects are literally anything that exists in the "game space", in our case this would be our cube.
    // For simplicity we have made this a public variable which means we can set it directly from the Unity Editor
    public GameObject cubeobj;

	// This function is run when the game is started and all assets are loaded
    // Generally this is used for initializing variables and other "first run" variables
	void Start () {

        // Just to make sure we remember to set the value :)
        if(cubeobj == null)
        {
            throw new UnassignedReferenceException();
        }

        // Get the Transform, which like all things is "Attached" to the Gameobject, so we can reference it easier
        cubie = cubeobj.GetComponent<Transform>();

        // Get the starting position
        orgposition = cubie.position;
	}
	
	// This function is called every frame, so 60 times per second if you run at 60fps
    // Most of the actual game logic will be run from here
	void Update () {

       
	}
}
