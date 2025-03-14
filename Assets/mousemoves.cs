using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemoves : MonoBehaviour
{
        void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }

    public Vector2 turn;
    void Update()
    {
        turn.x += Input.GetAxisRaw("Mouse X");
       turn.y += Input.GetAxisRaw("Mouse Y");
      turn.x = Mathf.Clamp(turn.x,-90f,90f);
        transform.localRotation =  Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
