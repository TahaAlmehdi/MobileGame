using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public int int_numberOftimes = 40;
    public bool bl_infinite = false;
    public float fl_timebetween = 0.5f;
    public GameObject Go_spawner;

    private float fl_nextTime;
    private int int_countsoFar;

	// Use this for initialization
	void Start ()
    {
        fl_nextTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Go_spawner != null)
        {
            if (fl_nextTime < Time.time)
            {
                if (bl_infinite || int_countsoFar < int_numberOftimes)
                {
                    Instantiate(Go_spawner, transform.position, transform.rotation);
                    int_countsoFar++;
                    fl_nextTime = Time.time + fl_timebetween;
                }
            }
        }
	}
}
