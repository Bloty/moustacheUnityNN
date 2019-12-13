using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
   public Transform player;

    void Update()
    {
        facePlayer();
    }

    //le spawner regarde toujours le joueur
    void facePlayer()
    {
        Vector3 posPlayer = new Vector3(player.position.x, player.position.y, player.position.z);

        Vector2 direction = new Vector2(posPlayer.x - transform.position.x, posPlayer.y - transform.position.y);

        transform.up = direction;
    }
}
