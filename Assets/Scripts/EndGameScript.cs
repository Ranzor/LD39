using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    ShipStatsBehavior shipStat;

	void Start ()
    {
        shipStat = FindObjectOfType<ShipStatsBehavior>();
	}
	
	void Update ()
    {
        if (shipStat.healt <= 0 || shipStat.energy <= 0)
        {
            Debug.Log("You losse");
        }
		
	}
}
