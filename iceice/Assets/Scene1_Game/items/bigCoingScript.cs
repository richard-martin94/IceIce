using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigCoingScript : MonoBehaviour {

	void Start () 
	{	
	}

	void Update () 
	{
	}

    void OnTriggerEnter(Collider t)
    {// when player collects big coin, grant player +25 coins
        if (t.gameObject == GameObject.FindGameObjectWithTag("playerObject"))
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount 
                = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount + 25;
            // method to update running coin count
			updateCoinCount();
			// make it disapear after collected
            this.gameObject.SetActive(false);

        }
    }
    void updateCoinCount()
    {// updates coin count as player collects coins
        GameObject.FindGameObjectWithTag("coinCount").GetComponent<TextMesh>().text = 
			"" + GameObject.FindGameObjectWithTag("Manager").GetComponent<GameScript>().coinCount;
    }
}
