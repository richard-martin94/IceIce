using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trayScript : MonoBehaviour {
    
	public int healthBar;
	public int setHealthBar;

    void Start () 
	{//initializing the hp bar as full, making separate cube objects active
		GameObject.FindGameObjectWithTag ("hp1").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp2").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp3").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp4").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp5").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp6").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp7").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp8").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp9").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp10").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp11").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp12").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp13").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp14").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp15").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp16").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp17").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp18").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp19").SetActive(true);
		GameObject.FindGameObjectWithTag ("hp20").SetActive(true);
    }

    void Update()
    {	// healthbar is the running health found in the game script
		healthBar = GameObject.FindGameObjectWithTag ("Manager").GetComponent<GameScript> ().health;
		// setHealthBar takes the health amount and filters it through the setHp method
		setHealthBar = setHp (healthBar);
    }

	int setHp(int h)
	{// setHp sets 'hp' objects to false when players health drops below a certain point
		if (healthBar >= 1000) {
			return h = 1000;
		} else if (healthBar >= 950) {
			GameObject.FindGameObjectWithTag ("hp1").SetActive(false);
			return h = 950;
		} else if (healthBar >= 900) {
			GameObject.FindGameObjectWithTag ("hp2").SetActive(false);
			return h = 900;
		} else if (healthBar >= 850) {
			GameObject.FindGameObjectWithTag ("hp3").SetActive(false);
			return h = 850;
		} else if (healthBar >= 800) {
			GameObject.FindGameObjectWithTag ("hp4").SetActive(false);
			return h = 800;
		} else if (healthBar >= 750) {
			GameObject.FindGameObjectWithTag ("hp5").SetActive(false);
			return h = 750;
		} else if (healthBar >= 700) {
			GameObject.FindGameObjectWithTag ("hp6").SetActive(false);
			return h = 700;
		} else if (healthBar >= 650) {
			GameObject.FindGameObjectWithTag ("hp7").SetActive(false);
			return h = 650;
		} else if (healthBar >= 600) {
			GameObject.FindGameObjectWithTag ("hp8").SetActive(false);
			return h = 600;
		} else if (healthBar >= 550) {
			GameObject.FindGameObjectWithTag ("hp9").SetActive(false);
			return h = 550;
		} else if (healthBar >= 500) {
			GameObject.FindGameObjectWithTag ("hp10").SetActive(false);
			return h = 500;
		} else if (healthBar >= 450) {
			GameObject.FindGameObjectWithTag ("hp11").SetActive(false);
			return h = 450;
		} else if (healthBar >= 400) {
			GameObject.FindGameObjectWithTag ("hp12").SetActive(false);
			return h = 400;
		} else if (healthBar >= 350) {
			GameObject.FindGameObjectWithTag ("hp13").SetActive(false);
			return h = 350;
		} else if (healthBar >= 300) {
			GameObject.FindGameObjectWithTag ("hp14").SetActive(false);
			return h = 300;
		} else if (healthBar >= 250) {
			GameObject.FindGameObjectWithTag ("hp15").SetActive(false);
			return h = 250;
		} else if (healthBar >= 200) {
			GameObject.FindGameObjectWithTag ("hp16").SetActive(false);
			return h = 200;
		} else if (healthBar >= 150) {
			GameObject.FindGameObjectWithTag ("hp17").SetActive(false);
			return h = 150;
		} else if (healthBar >= 100) {
			GameObject.FindGameObjectWithTag ("hp18").SetActive(false);
			return h = 100;
		} else if (healthBar >= 50) {
			GameObject.FindGameObjectWithTag ("hp19").SetActive(false);
			return h = 50;
		} else if (healthBar <= 0) 
		{
			GameObject.FindGameObjectWithTag ("hp20").SetActive(false);
			return h = 0;
		}
		return h;
	}

}
