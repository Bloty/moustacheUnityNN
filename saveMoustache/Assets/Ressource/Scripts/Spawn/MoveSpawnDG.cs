﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveSpawnDG : MonoBehaviour
{
    public float speed;
    private Vector3 targetPos;
    private bool isMoving = false;
    private float largeurEcran = 640;

    // Start is called before the first frame update
    void Start()
    {
        //targetPos = new Vector3(largeurEcran, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving == false)
        {
            if (transform.position.x == largeurEcran)
            {
                targetPos = new Vector3(0, 0, 0);
                isMoving = true;
            }
            
            if(transform.position.x == 0)
            {
                targetPos = new Vector3(largeurEcran, 0, 0);
                isMoving = true;
            }   
        }


        move();
    }

    private void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position == targetPos)
        {
            isMoving = false;
        }

        Debug.DrawLine(transform.position, targetPos, Color.red);
    }
}
