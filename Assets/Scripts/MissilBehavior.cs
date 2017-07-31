using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilBehavior : MonoBehaviour
{
    public int speed;
    public int rotationSpeed;
    public Transform target;
    public GameObject ShipHealt;
    public AudioClip explosionAudio;
    private ShieldScript mitigation;
    private ShipStatsBehavior shipScript;
    public int damage;
    

    void Start ()
    {
        shipScript = FindObjectOfType<ShipStatsBehavior>();
        mitigation = FindObjectOfType<ShieldScript>();
        
    }
	

	void Update ()
    {
        Vector3 vectorToTarget = target.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (mitigation.shieldStrength == 1)
        {
            shipScript.healt -= damage;
        }
        else if (mitigation.shieldStrength == 2)
        {
            shipScript.healt -= (damage / 2);
        }
        else
        {
            shipScript.healt -= (damage * 0);
        }

        AudioSource.PlayClipAtPoint(explosionAudio, transform.position);

        Destroy(gameObject);
    }

}
