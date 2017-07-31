using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGunBehavior : MonoBehaviour
{
    public float fireRate;
    public float timer;
    private GameObject bulletOut;
    public GameObject bullet;
    public float cameraShakeTimer;
    public float cameraShakeDuration;

    void Start()
    {
        fireRate = FindObjectOfType<WeaponScript>().rateOfFire;
        timer = fireRate;
    }

    void Update()
    {
        fireRate = FindObjectOfType<WeaponScript>().rateOfFire;
        timer -= Time.deltaTime;

        if (cameraShakeTimer > -1)
        {
            cameraShakeTimer -= Time.deltaTime;
        }

        if(cameraShakeTimer >= 0)
        {
            FindObjectOfType<CameraShake>().ShakeCamera();
        }

        EnemyBehavior[] enemys = GameObject.FindObjectsOfType<EnemyBehavior>();
        if (!(enemys.Length == 0))
        {
            if (timer <= 0)
            {
                timer = fireRate;
                for (int t = 0; t < enemys.Length; t++)
                {
                    if (enemys[t].underFire == false)
                    {
                        enemys[t].underFire = true;
                        bulletOut = Instantiate(bullet, transform.position, Quaternion.identity);
                        ShipsMissileBehaivior[] missils = FindObjectsOfType<ShipsMissileBehaivior>();
                        for(int e = 0; e < missils.Length; e++)
                        {
                            if (missils[e].target == null)
                            {
                                missils[e].target = enemys[t].transform;
                            } 
                        }
                        break;
                    }
                }
            }
        }
        else if (timer <= 0)
        {
            timer = fireRate;
        }

    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("ShipMissile");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
