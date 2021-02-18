using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Vector3 destination;
    public Vector3 difference;
    public float seconds;



    public void InitCameraMovement(Vector3 destination, float seconds)
    {
        this.destination = destination;
        this.seconds = seconds;
        difference = destination - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime*seconds);
    }
}