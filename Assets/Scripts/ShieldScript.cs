using UnityEngine;
using System.Collections;

public class ShieldScript : MonoBehaviour
{
    public int shieldPower = 1;
    public int shieldStrength = 1;
    public Canvas ShieldCanvas;
    public UnityEngine.UI.Text text;
    public AudioClip[] boostSounds;
    public AudioClip[] reduceSounds;
    public Sprite shieldLevel2;
    public GameObject shieldLevel3;

    private void Start()
    {
        
    }

    private void Update()
    {
        text.text = "Current Power Level: " + shieldPower.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShieldCanvas.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ShieldCanvas.enabled = false;
    }

    public void SetLevel1()
    {
        int index = Random.Range(0, 2);
        if (shieldPower == 2 || shieldPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        shieldPower = 1;
        shieldStrength = 1;
    }
    public void SetLevel2()
    {
        int index = Random.Range(0, 2);
        if (shieldPower == 1)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);         
        }
        if (shieldPower == 3)
        {            
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        shieldPower = 2;
        shieldStrength = 2;
    }
    public void SetLevel3()
    {
        int index = Random.Range(0, 2);
        if (shieldPower == 1 || shieldPower == 2)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        shieldPower = 3;
        shieldStrength = 3;
    }
}
