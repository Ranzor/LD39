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
    private AlienFormationSpawner alienFormationSpawner;

    void Start ()
    {
        timeUntilEvent = Random.Range(minTid, maxTid);
        asteroidFormationSpawner = formationCointainer.GetComponent<AsteroidFormationSpawner>();
        alienFormationSpawner = formationCointainer.GetComponent<AlienFormationSpawner>();
	}


    void Update ()
    {
        timeUntilEvent -= Time.deltaTime;
        if (timeUntilEvent <= 0)
        {
            timeUntilEvent = Random.Range(minTid, maxTid);
            int eventToUse = Random.Range(0, events.Length);
            Debug.Log(events[eventToUse]);
            if (events[eventToUse] == "Astroid")
            {
                asteroidFormationSpawner.SpawnAsteroids();
            }
            if(events[eventToUse] == "Aliens" )
            {
                alienFormationSpawner.SpawnAliens();
            }

        }
	}
}
