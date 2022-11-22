using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameratest : MonoBehaviour {

    public Transform lookAt;// making variable called lookat
    public GameObject go_thingToBeFollowed;
    public float fl_distanceOn_zAxis = 10f;
    public float fl_distanceOn_xAxis = -3f;
    public float fl_distanceOn_yAxis = -3f;
    public bool bl_pointAt = true;
    private Vector3 v3_new_camera_position = Vector3.zero;
    private bool smooth = true; //variable for smooth and giving the value to true
    private float smoothSpeed = 0.125f; //float smoothspeed and giving 0.125f
    private Vector3 offset = new Vector3(0, 0, -16.5f); //giving the vector3 this amount of value

    private void LateUpdate()
    {
        Vector3 desiredPosition = lookAt.transform.position + offset; // follows the player

        if (smooth)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // followers the player in a smooth speed
        }
        else
        {
            transform.position = desiredPosition; // when the camera is not following good enough it will move to his desiredPosition.
        }

        v3_new_camera_position.x = go_thingToBeFollowed.transform.position.x - fl_distanceOn_xAxis;
        v3_new_camera_position.y = go_thingToBeFollowed.transform.position.y - fl_distanceOn_yAxis;
        v3_new_camera_position.z = go_thingToBeFollowed.transform.position.z - fl_distanceOn_zAxis;
        //
        if (v3_new_camera_position.x != transform.position.x || v3_new_camera_position.y != transform.position.y)
        {
            transform.position = v3_new_camera_position;
        }
        // should we rotate the camera to point at the thing we are following?
        if (bl_pointAt)
        {
            transform.LookAt(go_thingToBeFollowed.transform);
        }
    }
}
