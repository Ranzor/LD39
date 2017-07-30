using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 0;
	}

    public void StartGame()
    {
        Time.timeScale = 1;
    }
}
