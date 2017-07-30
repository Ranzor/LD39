using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsMissileBehaivior : MonoBehaviour
{

    public int speed;
    public int rotationSpeed;
    public Transform target;


    void Start()
    {
        
    }


    void Update()
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
        if(collision.tag != "Wall")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
