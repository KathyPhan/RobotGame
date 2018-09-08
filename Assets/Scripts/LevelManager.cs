﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int hitpoint = 3;
    private int score = 0;

    public Vector3 spawnPosition;

    public Transform playerTransform;

    private void Update()
    {

        if(playerTransform.position.y <-20)
        {
            playerTransform.position = spawnPosition;
            hitpoint--;

            if(hitpoint <= 0)
            {
                Debug.Log("Failure");
            }
        }
    }


}
