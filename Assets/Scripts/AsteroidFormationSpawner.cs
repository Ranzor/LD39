using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFormationSpawner : MonoBehaviour {

    public GameObject[] asteroidFormations;
    
    public void SpawnAsteroids()
    {
        int index = Random.Range(0, asteroidFormations.Length);
        GameObject curFormation = Instantiate(asteroidFormations[index], transform.position, Quaternion.identity);
        curFormation.transform.parent = transform;
    }    
}
