using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCrankScript : MonoBehaviour
{

    public int reapairPower;
    private ShipStatsBehavior energy;

	void Start ()
    {
        energy = FindObjectOfType<ShipStatsBehavior>();
	}
	

	void Update ()
    {

    }

    private void Repair()
    {
        energy.energy += reapairPower;
    }
}
