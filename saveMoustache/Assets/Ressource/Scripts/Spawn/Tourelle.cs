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

    void facePlayer()
    {
        Vector3 posPlayer = new Vector3(player.position.x, player.position.y, player.position.z);
        //posPlayer = Camera.main.ScreenToWorldPoint(posPlayer);

        Vector2 direction = new Vector2(posPlayer.x - transform.position.x, posPlayer.y - transform.position.y);

        transform.up = direction;
    }
}
