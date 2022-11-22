using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting : MonoBehaviour {

    public Transform teleportTarget;// variable, this is where the person is going to be teleported to.
    public GameObject Player;// variable, attach this to the player.

    private void OnTriggerEnter(Collider other)// when collide with the object it will trigger the script
    {
        Player.transform.position = teleportTarget.transform.position;// this is where the teleport actually happening, once the player collide with the teleport it will move to different position.
    }
}
 