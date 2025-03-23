using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    void Update()
    {
        // Set the camera objects position to the player
        transform.position = cameraPosition.position; 
    }
}
