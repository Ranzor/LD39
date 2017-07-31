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

    // Use this for initialization
	void Start ()
    {
        shipScript = FindObjectOfType<ShipStatsBehavior>();
        mitigation = FindObjectOfType<ShieldScript>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3 (-speed * Time.deltaTime,0,0), 0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
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

        if (collision.tag == "Wall")
        {
            AudioSource.PlayClipAtPoint(explosionAudio, transform.position);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
