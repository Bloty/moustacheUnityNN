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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= boomDelay)
        {
            boomSprite.SetActive(true);
        }
        else
        {
            boomSprite.SetActive(false);
        }

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
