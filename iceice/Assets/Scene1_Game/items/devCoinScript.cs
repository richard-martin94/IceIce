using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devCoinScript : MonoBehaviour {
	// dev coins are used to test shop buttons 
	void Start () 
	{
	}

	void Update () 
	{
	}

    void OnTriggerEnter(Collider t)
    {
		if (t.gameObject == GameObject.FindGameObjectWithTag("playerObject"))
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount =
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount+10000000;
            updateCoinCount();
            this.gameObject.SetActive(false);
        }
    }
    void updateCoinCount()
    {
        GameObject.FindGameObjectWithTag("coinCount").GetComponent<TextMesh>().text = "" + GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount;
    }
}
