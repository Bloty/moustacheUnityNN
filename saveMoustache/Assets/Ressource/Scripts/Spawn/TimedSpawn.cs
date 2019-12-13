using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject spawnee;
    public float spawnDelay;
    public float timer;

    public float DelayTempReduit;
    public float timerReduit;
    

    void Start()
    {
        timer = spawnDelay;
        timerReduit = DelayTempReduit;
    }

    void Update()
    {
        spawn();

        reductionDuDelay();
    }

    public void spawn()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(spawnee, transform.position, transform.rotation);
            timer = spawnDelay;
        }
    }

    public void reductionDuDelay()
    {
        timerReduit -= Time.deltaTime;
        if (timerReduit < 0)
        {
            timerReduit = DelayTempReduit;
            spawnDelay -= 0.2f;
        }
    }
}