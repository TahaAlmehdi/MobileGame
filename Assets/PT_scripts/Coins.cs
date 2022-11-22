using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other) // when the player collide it will start the ttrigger.
    {
        if (other.name == "Player")
        {
            //add 1 point
            other.GetComponent<counter>().points++;// this is adding the points to our game.
            Destroy(gameObject); // destroys the object.
            Debug.Log("you got a coin");
        }
    }
}
