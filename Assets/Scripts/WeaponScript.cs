using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour
{
    public int weaponPower = 1;
    public float rateOfFire;
    public Canvas WeaponCanvas;
    public UnityEngine.UI.Text text;
    public AudioClip[] boostSounds;
    public AudioClip[] reduceSounds;

    private void Start()
    {
        SetLevel1();
    }

    private void Update()
    {
        text.text = "Current Power Level: " + weaponPower.ToString();
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        WeaponCanvas.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        WeaponCanvas.enabled = false;
    }
    public void SetLevel1()
    {
        int index = Random.Range(0, 2);
        if (weaponPower == 2 || weaponPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        weaponPower = 1;
        rateOfFire = 7;
    }
    public void SetLevel2()
    {
        int index = Random.Range(0, 2);
        if (weaponPower == 1)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        if (weaponPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        weaponPower = 2;
        rateOfFire = 3;
    }
    public void SetLevel3()
    {
        int index = Random.Range(0, 2);
        if (weaponPower == 1 || weaponPower == 2)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        weaponPower = 3;
        rateOfFire = 0.5f;
    }
}
