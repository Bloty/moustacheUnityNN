using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScissors : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("Boom"))
        {
            Destroy(this.gameObject);
        }
    }
}
