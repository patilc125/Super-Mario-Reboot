using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform groundPoints;
    public Transform minHeightPoint;
    public Transform maxHeightPoint;
	
    private float minY;
    private float maxY;
    
    public float minGap;
    public float maxGap;
    
    private CoinGenerator coinGenerator;

    public Objectpoller[] groundPoolers;
    private float[] groundWidhts;
    void Start()
    { 
        minY= minHeightPoint.position.y;
        maxY= maxHeightPoint.position.y;
        groundWidhts= new float[groundPoolers.Length];
	for(int i=0;i<groundPoolers.Length;i++){
	 groundWidhts[i]= groundPoolers[i].polledObject.GetComponent<BoxCollider2D>().size.x;
	}
        coinGenerator=FindObjectOfType<CoinGenerator>();
    }

  
    void Update()
    { 
     if(transform.position.x<groundPoints.position.x){
          int random=Random.Range(0,groundPoolers.Length);
	  float distance= groundWidhts[random]/2;

           
	  float gap=Random.Range(minGap,maxGap);
          float height =Random.Range(minY,maxY);
	  transform.position= new Vector3(transform.position.x+distance+gap,
		height,transform.position.z);


	GameObject ground= groundPoolers[random].GetPooledGameObject();
	ground.transform.position=transform.position;
	ground.SetActive(true);
         coinGenerator.spawnCoins(
           transform.position,
	   groundWidhts[random]
		); 
	 transform.position= new Vector3(transform.position.x+distance,
	 transform.position.y,transform.position.z);	


	}
        
    }
}
