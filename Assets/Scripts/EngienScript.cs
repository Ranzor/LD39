using UnityEngine;
using System.Collections;

public class EngienScript : MonoBehaviour
{
    public int engienPower = 1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            engienPower = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            engienPower = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            engienPower = 3;
        }
    }

}
