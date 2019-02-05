using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour {

	void Start () 
	{
	}

	void Update () 
	{
	}

    void OnTriggerEnter(Collider t)
    {// when player collects smaller coin, grant +1 to count
		if (t.gameObject == GameObject.FindGameObjectWithTag("playerObject"))
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount++;
            // method to update running coincount
			updateCoinCount();
			// make coin disappear after being collected
            this.gameObject.SetActive(false);
        }
    }

    void updateCoinCount ()
	{// updates coin count as player collects coins
        GameObject.FindGameObjectWithTag("coinCount").GetComponent<TextMesh>().text = 
			"" + GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount;
    }
}
