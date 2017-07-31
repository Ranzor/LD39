using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCrankScript : MonoBehaviour
{

    public int reapairPower;
    private ShipStatsBehavior energy;
    public Canvas energyCrankCanvas;

	void Start ()
    {
        energy = FindObjectOfType<ShipStatsBehavior>();
	}

    public void Repair()
    {
        energy.energy += reapairPower;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        energyCrankCanvas.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        energyCrankCanvas.enabled = false;
    }
}
