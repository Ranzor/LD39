using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public int speed;
    private Rigidbody2D Player;
	// Use this for initialization
	void Start ()
    {
        Player = GetComponent<Rigidbody2D>();
        Player.fixedAngle = true; 
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
