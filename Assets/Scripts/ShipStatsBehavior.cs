using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ShipStatsBehavior : MonoBehaviour
{
    public int healt = 0;
    public int energy = 0;
    public int engienDraw = 0;
    public int shieldDraw = 0;
    public int weaponDraw = 0;
    public int hullReapairDraw;
    public Slider healthSlider;
    public Slider powerSlider;    

    private float timer = 0;
    public GameObject weapons;
    public GameObject shield;
    public GameObject engien;
    WeaponScript weaponScriptCopy;
    ShieldScript shieldScriptCopy;
    EngienScript engenScriptCopy;
    HullReapair hullReapairScriptCopy;


    void Start ()
    {
         weaponScriptCopy = weapons.GetComponent<WeaponScript>();
         shieldScriptCopy = shield.GetComponent<ShieldScript>();
         engenScriptCopy = engien.GetComponent<EngienScript>();
        hullReapairScriptCopy = FindObjectOfType<HullReapair>();
        healthSlider.value = healt;
        powerSlider.value = energy;
        healthSlider.maxValue = healt;
        powerSlider.maxValue = energy;
    }
	
	void Update ()
    {
        timer = timer + Time.deltaTime;
        if(healt > healthSlider.maxValue)
        {
            healt = (int)healthSlider.maxValue;
        }

        if (timer >= 1)
        {
            weaponDraw = weaponScriptCopy.weaponPower;
            shieldDraw = shieldScriptCopy.shieldPower;
            engienDraw = engenScriptCopy.engienPower;
            hullReapairDraw = hullReapairScriptCopy.hullReapairPower;
            timer = 0;
            energy = energy - (engienDraw + shieldDraw + weaponDraw + hullReapairDraw);
            //Debug.Log(energy);

            healthSlider.value = healt;
            powerSlider.value = energy;
        }

    }
}
