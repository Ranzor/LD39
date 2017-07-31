using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HullReapair : MonoBehaviour {

    private ShipStatsBehavior healt;
    public int hullReapairPower;
    public int repairSpeed;

    public Canvas hullCanvas;
    public UnityEngine.UI.Text text;
    public AudioClip[] boostSounds;
    public AudioClip[] reduceSounds;

    public float timer;

    void Start ()
    {
        healt = FindObjectOfType<ShipStatsBehavior>();
        SetLevel1();
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= 10)
        {
            healt.healt += repairSpeed;
            timer = 0;
        }
        text.text = "Current Repair Level: " + hullReapairPower.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hullCanvas.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        hullCanvas.enabled = false;
    }

    public void SetLevel1()
    {
        int index = Random.Range(0, 2);
        if (hullReapairPower == 2 || hullReapairPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        hullReapairPower = 1;
        repairSpeed = 0;
    }
    public void SetLevel2()
    {
        int index = Random.Range(0, 2);
        if (hullReapairPower == 1)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        if (hullReapairPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        hullReapairPower = 2;
        repairSpeed = 1;
    }
    public void SetLevel3()
    {
        int index = Random.Range(0, 2);
        if (hullReapairPower == 1 || hullReapairPower == 2)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        hullReapairPower = 3;
        repairSpeed = 5;
    }
}
