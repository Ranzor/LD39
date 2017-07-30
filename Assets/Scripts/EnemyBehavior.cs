using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int enemyRateOfFire;
    public float timer;
    public GameObject bullet;
    private GameObject bulletOut;
    public Transform target;
    public float rotationSpeed;
    public bool underFire;
    
    

	void Start ()
    {
        underFire = false;
        enemyRateOfFire = 10;
        timer = enemyRateOfFire;

        
	}
	
	void Update ()
    {
        Vector3 vectorToTarget = target.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed * Time.deltaTime);

        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = enemyRateOfFire;
            bulletOut = Instantiate(bullet, transform.position, Quaternion.identity);
            
        }
	}
}
