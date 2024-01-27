using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDis : MonoBehaviour
{
    
    private GameObject point;
	
    void Start()
    {
        point=GameObject.Find("deletepoint");
    }

    
    void Update()
    {
        if(transform.position.x<point.transform.position.x){
		gameObject.SetActive(false);
	}
    }
}
