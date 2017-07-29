﻿using UnityEngine;
using System.Collections;

public class ShipStatsBehavior : MonoBehaviour
{
    public int healt = 0;
    public int energy = 0;
    public int engienDraw = 0;
    public int shieldDraw = 0;
    public int weaponDraw = 0;
    private float timer = 0;
    public GameObject weapons;
    public GameObject shield;
    public GameObject engien;
    WeaponScript weaponScriptCopy;
    ShieldScript shieldScriptCopy;
    EngienScript engenScriptCopy;

    void Start ()
    {
         weaponScriptCopy = weapons.GetComponent<WeaponScript>();
         shieldScriptCopy = shield.GetComponent<ShieldScript>();
         engenScriptCopy = engien.GetComponent<EngienScript>();
    }
	
	void Update ()
    {
        timer = timer + Time.deltaTime;

        if (timer >= 1)
        {
            weaponDraw = weaponScriptCopy.weaponPower;
            shieldDraw = shieldScriptCopy.shieldPower;
            engienDraw = engenScriptCopy.engienPower;
            timer = 0;
            energy = energy - (engienDraw + shieldDraw + weaponDraw);
            Debug.Log(energy);
        }

    }
}
