using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    public GameObject[] asteroidPrefab;

    public float spawnDelay = 0f;
    int index;
    // Use this for initialization
    void Start()
    {

        SpawnUntilFull();
    }

    private void Update()
    {
        if (AllMembersDead())
        {
            Destroy(gameObject);
        }
    }

    Transform NextFreePosition()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount == 0)
            {
                return childPositionGameObject;
            }
        }
        return null;
    }

    bool AllMembersDead()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount > 0)
            {
                return false;
            }
        }
        return true;
    }

    void SpawnUntilFull()
    {
        Transform freePosition = NextFreePosition();
        if (freePosition)
        {
            GameObject enemy = Instantiate(asteroidPrefab[index], freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
        }

        if (NextFreePosition())
        {
            Invoke("SpawnUntilFull", spawnDelay);
        }
    }

    void SpawnEnemies()
    {
        foreach (Transform child in transform)
        {
            GameObject enemy = Instantiate(asteroidPrefab[index], child.transform.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = child;
        }
    }
}
