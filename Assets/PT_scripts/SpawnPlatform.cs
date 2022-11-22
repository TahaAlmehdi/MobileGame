using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour {

    public GameObject moveplatform;

    private void OnTriggerEnter()
    {
        moveplatform.SetActive(false);
    }
}
