using UnityEngine;
using System.Collections;

public class EngienScript : MonoBehaviour
{
    public int engienPower = 1;
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
    }
    public void SetLevel2()
    {
        engienPower = 2;
    }
    public void SetLevel3()
    {
        engienPower = 3;
    }



}
