using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitplatform : MonoBehaviour {

    public GameObject moveplatform;

    private void OnTriggerExit()
    {
        moveplatform.SetActive(false);
    }
}
