using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour
{
    public int weaponPower = 1;
    public Canvas WeaponCanvas;
    public UnityEngine.UI.Text text;

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
        weaponPower = 1;
    }
    public void SetLevel2()
    {
        weaponPower = 2;
    }
    public void SetLevel3()
    {
        weaponPower = 3;
    }
}
