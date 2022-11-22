using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPlatform : MonoBehaviour {

    public GameObject moveplatform;

    private void OnTriggerStay()// it means as long if your inside the trigger.
    {
        moveplatform.transform.position += moveplatform.transform.forward * Time.deltaTime;
    }
}
