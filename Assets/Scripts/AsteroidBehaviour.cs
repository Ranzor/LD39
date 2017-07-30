using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    //public GameObject shipStats;
    public int damage;
    public int speed;
    private ShipStatsBehavior shipScript;
    // Use this for initialization
	void Start ()
    {
        shipScript = FindObjectOfType<ShipStatsBehavior>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3 (-speed * Time.deltaTime,0,0), 0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shipScript.healt -= damage;
        Destroy(gameObject);
    }
}
