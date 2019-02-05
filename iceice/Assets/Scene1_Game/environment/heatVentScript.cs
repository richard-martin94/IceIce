using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heatVentScript : MonoBehaviour {
	
	void Start () 
	{	
	}
	void Update () 
	{
	}

    void OnTriggerEnter(Collider t)
    {//when player collides with heat vent, subtract 100 hit points
		if (t.gameObject == GameObject.FindGameObjectWithTag("playerObject"))
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().health
            = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().health - 100;
            
        }
    }
}
