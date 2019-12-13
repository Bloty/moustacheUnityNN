using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoom : MonoBehaviour
{
    public ScriptMicro scriptMicro;
    public GameObject collisionBoom;
    public GameObject boomSprite;
    public float boomDelay;
    public float time = 0;


    void Update()
    {

        //incrementation du timer
        time += Time.deltaTime;

        //activation du sprite
        if (time >= boomDelay)
        {
            boomSprite.SetActive(true);
        }
        else
        {
            boomSprite.SetActive(false);
        }


        //activation du trigger
        if (scriptMicro.son == true && time >= boomDelay)
        {
            collisionBoom.SetActive(true);
            time = 0;
        }
        else
        {
            collisionBoom.SetActive(false);
        }
    }
}
