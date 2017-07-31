using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    //public GameObject shipStats;
    public int damage;
    public int speed;
    private ShipStatsBehavior shipScript;
    private ShieldScript mitigation;
    public AudioClip explosionAudio;
    public GameObject explosionPrefab;
    public float cameraShakeDuration;

    // Use this for initialization
    void Start ()
    {
        shipScript = FindObjectOfType<ShipStatsBehavior>();
        mitigation = FindObjectOfType<ShieldScript>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
                if (mitigation.shieldStrength == 1)
            {
                shipScript.healt -= damage;
            }
            else if(mitigation.shieldStrength == 2)
            {
                shipScript.healt -= (damage/2);
            }
            else
            {
                shipScript.healt -= (damage * 0);
            }

            AudioSource.PlayClipAtPoint(explosionAudio, transform.position);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            if(Random.Range(1,5) == 1)
            {
                FindObjectOfType<ShipGunBehavior>().cameraShakeTimer = cameraShakeDuration;
                int rand = Random.Range(1, 5);
                if(rand == 1)
                {
                    WeaponScript weapon = FindObjectOfType<WeaponScript>();
                    weapon.SetLevel1();
                }
                else if(rand == 2)
                {
                    EngienScript engien = FindObjectOfType<EngienScript>();
                    engien.SetLevel1();
                }
                else if(rand == 3)
                {
                    ShieldScript shield = FindObjectOfType<ShieldScript>();
                    shield.SetLevel1();
                }
                else if(rand == 4)
                {
                    HullReapair hullRepair = FindObjectOfType<HullReapair>();
                    hullRepair.SetLevel1();
                }
            }

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
