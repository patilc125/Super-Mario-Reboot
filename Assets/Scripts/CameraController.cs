using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private player pl; 
    private Vector3 lastPosition;
    private float distance;
    void Start()
    {
        pl= FindObjectOfType<player>();
        lastPosition=pl.transform.position;
        
    }

  
    void Update()
    {
        distance= pl.transform.position.x-lastPosition.x;
        transform.position = new Vector3(transform.position.x+distance,transform.position.y,transform.position.z);
        lastPosition=pl.transform.position;
    }
}
