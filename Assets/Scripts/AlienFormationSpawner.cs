using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienFormationSpawner : MonoBehaviour {

    public GameObject[] enemyFormations;

    public void SpawnAliens()
    {
        int index = Random.Range(0, enemyFormations.Length);
        GameObject curFormation = Instantiate(enemyFormations[index], transform.position, Quaternion.identity);
        curFormation.transform.parent = transform;
    }
}
