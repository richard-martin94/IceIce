using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorScript : MonoBehaviour {
	void Start () 
	{
	}

	void Update () 
	{
	}

    void OnCollisionEnter(Collision c)
    {//if the player collides with the floor, reset the jump count allowing players to jump twice
		if (c.gameObject == GameObject.FindGameObjectWithTag("playerObject"))
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().jumpCnt = 0;
        }

    }
}
