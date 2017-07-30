using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    ShipStatsBehavior shipStat;
    EngienScript speed;
    public float distanceTravled;
    public float goal;

    void Start ()
    {
        shipStat = FindObjectOfType<ShipStatsBehavior>();
        speed = FindObjectOfType<EngienScript>();
	}
	
	void Update ()
    {
        distanceTravled += speed.travelSpeed * Time.deltaTime;

        if (shipStat.healt <= 0 || shipStat.energy <= 0)
        {
            Debug.Log("You losse");
        }
        if (distanceTravled >= goal)
        {
            Debug.Log("You vin");
        }
		
	}
}
