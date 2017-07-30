using UnityEngine;
using System.Collections;

public class EngienScript : MonoBehaviour
{
    public int engienPower = 1;
    public float travelSpeed = 1;
    public Canvas EngineCanvas;
    public UnityEngine.UI.Text text;

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
        engienPower = 1;
        travelSpeed = 1.5f;
    }
    public void SetLevel2()
    {
        engienPower = 2;
        travelSpeed = 2;
    }
    public void SetLevel3()
    {
        engienPower = 3;
        travelSpeed = 2.5f;
    }



}
