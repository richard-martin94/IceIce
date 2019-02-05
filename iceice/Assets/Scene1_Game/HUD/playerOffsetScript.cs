using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOffsetScript : MonoBehaviour {
    
    private Vector3 offset;

    void Start ()
    {//offset is 0, this way the position of objects with this script stay put and move with the player
		offset = transform.position - GameObject.FindGameObjectWithTag("playerObject").transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
		transform.position = GameObject.FindGameObjectWithTag("playerObject").transform.position + offset;
    }

}

