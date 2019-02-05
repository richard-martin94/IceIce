using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyWagonScript : MonoBehaviour 
{
	
	public void EquipWagon ()
	{
		PlayerPrefs.SetInt ("wagonEquiped", 1);
		save ();
	} 
	public void unEquipWagon ()
	{
		PlayerPrefs.SetInt ("wagonEquiped", 0);
		save ();
	}
	public void save() 
	{
	}

}
