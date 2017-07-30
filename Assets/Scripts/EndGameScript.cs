using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    ShipStatsBehavior shipStat;
    EngienScript speed;

    public Canvas GOEnergyCanvas;
    public Canvas GOHealthCanvas;

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

        if (shipStat.healt <= 0)
        {
            GOHealthCanvas.enabled = true;
            
        }else if (shipStat.energy <= 0)
        {
            GOEnergyCanvas.enabled = true;
        }
        if (distanceTravled >= goal)
        {
            Debug.Log("You vin");
        }
		
	}
}
