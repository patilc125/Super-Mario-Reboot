using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpoller : MonoBehaviour
{
    public GameObject polledObject;
    public int numberOfObject;
    private List<GameObject> gameObjects;
    void Start()
    { 
      gameObjects=new List<GameObject>();
      for(int i=0;i<numberOfObject;i++){
		GameObject gameObject= Instantiate(polledObject);
		gameObject.SetActive(false);
		gameObjects.Add(gameObject);	
	}  
    }
 
   public GameObject GetPooledGameObject(){
	foreach(GameObject gameObject in gameObjects){
		if(!gameObject.activeInHierarchy){
			return gameObject;
		}
	}
       GameObject gameObj = Instantiate(polledObject);
       gameObj.SetActive(false);
       gameObjects.Add(gameObj);

   return gameObj;
		
  }	

    
}
