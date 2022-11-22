using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { set; get; }// static means its avaivable anywhere in our code
    private int hitpoint = 3; // lifes
    public Transform spawnPosition; // spawn
    public Transform playerTransform;// player spawn

    private void Awake()
    {
        Instance = this; //set our value to ourself
    }

    private void Update()
    {
        if (playerTransform.position.y < 3.515267) // how far can the player drop
        {
            playerTransform.position = spawnPosition.position;// it define an object
            hitpoint--; //hitpoint = hitpoint - 1;
            if (hitpoint <= -0) // if the player drops 3 times it will get a message saying"failure"
            {
                Debug.Log("failure!");// when the player dropped three times it will send the message in the debug.log "failure!"
            }
        }
        
    }
   
}