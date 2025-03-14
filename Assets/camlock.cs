using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camlock : MonoBehaviour
{
    public GameObject cam;

  public Vector3 rotatione;

  
  
  
  
    void Start()
    {
        
    }

    
    void Update()
    {
        rotatione = cam.transform.eulerAngles;
     rotatione.x = 0;
     rotatione.z = 0;
     transform.eulerAngles = rotatione;
    }
}
