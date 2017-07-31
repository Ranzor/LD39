using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldLevel2Script : MonoBehaviour {

    private ShipStatsBehavior shipStats;
	// Use this for initialization
	void Start ()
    {
        shipStats = FindObjectOfType<ShipStatsBehavior>();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (shipStats.shieldDraw == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
