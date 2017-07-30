using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    ShipStatsBehavior shipStat;
    EngienScript speed;

    public Canvas GOEnergyCanvas;
    public Canvas GOHealthCanvas;
    public Canvas GOWinCanvas;

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
            Time.timeScale = 0;
            
        }else if (shipStat.energy <= 0)
        {
            GOEnergyCanvas.enabled = true;
            Time.timeScale = 0;
        }
        if (distanceTravled >= goal)
        {
            GOWinCanvas.enabled = true;
            Time.timeScale = 0;
        }
		
	}
}
