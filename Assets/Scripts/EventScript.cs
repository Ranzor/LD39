using UnityEngine;
using System.Collections;

public class EventScript : MonoBehaviour
{
    public float minTid;
    public float maxTid;
    public float timeUntilEvent;
    public string[] events;
    public GameObject formationCointainer;
    private AsteroidFormationSpawner asteroidFormationSpawner;
    private int eventToUse;

    void Start ()
    {
        timeUntilEvent = Random.Range(minTid, maxTid);
        asteroidFormationSpawner = formationCointainer.GetComponent<AsteroidFormationSpawner>();
	}


    void Update ()
    {
        timeUntilEvent -= Time.deltaTime;
        if(timeUntilEvent <= 0)
        {
            timeUntilEvent = Random.Range(minTid, maxTid);
            eventToUse = Random.Range(0, events.Length);
            Debug.Log(events[eventToUse]);
            if(events[eventToUse] == "Asteroid")
            {
                asteroidFormationSpawner.SpawnAsteroids();
            }
        }
	}
}
