using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour {
	
	void Start () 
	{
	}
	void Update ()
	{
    }

    void OnTriggerEnter(Collider t)
    {// player collides with health cube, increase health by 200
		if (t.gameObject == GameObject.FindGameObjectWithTag("playerObject"))
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().health
            = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().health + 200;
			// make health disappear after collected
            this.gameObject.SetActive(false);
        }
    }
}
