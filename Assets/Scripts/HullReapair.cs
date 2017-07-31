using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HullReapair : MonoBehaviour {

    private ShipStatsBehavior healt;
    public int hullReapairPower;
    public int repairSpeed;

	void Start ()
    {
        healt = FindObjectOfType<ShipStatsBehavior>();
        SetLevel1();
	}
	
	// Update is called once per frame
	void Update ()
    {
        healt.healt += repairSpeed;
	}

    public void SetLevel1()
    {
        hullReapairPower = 1;
        repairSpeed = 0;
    }
    public void SetLevel2()
    {
        hullReapairPower = 2;
        repairSpeed = 1;
    }
    public void SetLevel3()
    {
        hullReapairPower = 3;
        repairSpeed = 5;
    }
}
