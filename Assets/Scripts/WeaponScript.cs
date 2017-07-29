using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour
{
    public int weaponPower = 1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponPower = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponPower = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponPower = 3;
        }
    }
}
