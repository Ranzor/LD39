using UnityEngine;
using System.Collections;

public class ShieldScript : MonoBehaviour
{
    public int shieldPower = 1;
    public Canvas ShieldCanvas;
    public UnityEngine.UI.Text text;

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
        shieldPower = 1;
    }
    public void SetLevel2()
    {
        shieldPower = 2;
    }
    public void SetLevel3()
    {
        shieldPower = 3;
    }
}
