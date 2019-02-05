using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour 
{
    
    public float jumpAmt;// jump height of player
	public int jumpCnt;// keeps track of # of jumps, limited to two
    public int coinCount;// amount of coins player has
	// public int runningCoinCount; not implemented yet, meant to keep track of coins post death
    public int health;// player health
	public int speedmodifier;// how fast the player moves
	public int wagonEquiped;// test variable for wagon

	void Start ()
	{
		health = 1200;
		// running coin count awaiting implemenatation
		//coinCount = PlayerPrefs.GetInt("runningCoinCount");
		speedmodifier = 17;// base speed
		jumpAmt = 185;// base jump amount
		// logic for determining if wagon is equiped or not
		if (PlayerPrefs.GetInt ("wagonEquiped") == 1) {
			speedmodifier = 13;
			jumpAmt = jumpAmt / (float)1.5;
			GameObject.FindGameObjectWithTag ("Player").SetActive (false);

		} else {
			speedmodifier = 17;
			jumpAmt = 185;
			GameObject.FindGameObjectWithTag ("playerWagon").SetActive (false);
		}
	}

	void Update ()
    {
        health--;// health is decreased by 1 every update
        if(health == 0)
		{	/* 
			// part of script that maintains coin counter after death, not implemented yet
			//runningCoinCount = coinCount;
            GameObject.FindGameObjectWithTag("playerObject").SetActive(false);
			runningCoinCount = runningCoinCount + coinCount;
			PlayerPrefs.SetInt ("runningCoinCount", runningCoinCount);
			PlayerPrefs.Save (); */
			SceneManager.LoadScene (0);// on death load main menu
        }

        if (Input.GetButtonDown("Jump"))// jump button is space by default
        {
            if (jumpCnt <= 1)// if player jumps increment jumpCnt
            {
                GameObject.FindGameObjectWithTag("playerObject").GetComponent<Rigidbody>().AddForce(0, jumpAmt, 0);
                jumpCnt++;
            }
        }
	}
    void FixedUpdate()
    {// move player right adding vector3 divided by the speedmodifier
        GameObject.FindGameObjectWithTag("playerObject").transform.position += (Vector3.right)/speedmodifier;
    }


}
