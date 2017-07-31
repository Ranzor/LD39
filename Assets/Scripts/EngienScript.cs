using UnityEngine;
using System.Collections;

public class EngienScript : MonoBehaviour
{
    public int engienPower = 1;
    public float travelSpeed = 1;
    public Canvas EngineCanvas;
    public UnityEngine.UI.Text text;
    public AudioClip[] boostSounds;
    public AudioClip[] reduceSounds;    

    private void Update()
    {
        text.text = "Current Power Level: " + engienPower.ToString();
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EngineCanvas.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EngineCanvas.enabled = false;
    }

    public void SetLevel1()
    {
        int index = Random.Range(0, 2);
        if (engienPower == 2 || engienPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        engienPower = 1;
        travelSpeed = 1.5f;
    }
    public void SetLevel2()
    {
        int index = Random.Range(0, 2);
        if (engienPower == 3)
        {
            AudioSource.PlayClipAtPoint(reduceSounds[index], transform.position);
        }
        else if (engienPower == 1)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        engienPower = 2;
        travelSpeed = 2;
    }
    public void SetLevel3()
    {
        int index = Random.Range(0, 2);
        if (engienPower == 1 || engienPower == 2)
        {
            AudioSource.PlayClipAtPoint(boostSounds[index], transform.position);
        }
        engienPower = 3;
        travelSpeed = 2.5f;
    }



}
