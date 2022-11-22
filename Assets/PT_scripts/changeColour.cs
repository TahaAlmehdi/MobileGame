using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour {
    public Material startMaterial;
    public Material endMaterial;
    public bool hasChanged = false;

    private Renderer _Renderer;

	// Use this for initialization
	void Start ()
    {
        _Renderer = gameObject.GetComponent<Renderer>();
        _Renderer.material = startMaterial;
	}
	
	// Update is called once per frame
	void Update ()

    {
        if (!hasChanged)
        {
            _Renderer.material = endMaterial;
            hasChanged = true;
        }
	}
}
