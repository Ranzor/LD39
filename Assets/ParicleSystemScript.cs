using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParicleSystemScript : MonoBehaviour {
    private ShipStatsBehavior shipStats;
    private ParticleSystem particleSystem;
	// Use this for initialization
	void Start () {
        shipStats = FindObjectOfType<ShipStatsBehavior>();
        particleSystem = FindObjectOfType<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {

        if(shipStats.engienDraw == 1)
        {
            particleSystem.playbackSpeed = 1;
        }
        if (shipStats.engienDraw == 2)
        {
            particleSystem.playbackSpeed = 2;
        }
        if (shipStats.engienDraw == 3)
        {
            particleSystem.playbackSpeed = 3;
        }

    }
}
