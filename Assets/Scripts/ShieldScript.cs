using UnityEngine;
using System.Collections;

public class ShieldScript : MonoBehaviour
{
    public int shieldPower = 1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            shieldPower = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            shieldPower = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            shieldPower = 3;
        }
    }
}
