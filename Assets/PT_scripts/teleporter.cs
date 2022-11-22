using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private CharacterController controller;

    // Use this for initialization
    void Start () {
        if (gameObject.CompareTag("Teleport"))
        {
            Debug.Log("Teleportation magic should happen here :)");
            controller.Move(new Vector3(19.12f, 4.683f, transform.position.z)); // teleport coordinates

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
