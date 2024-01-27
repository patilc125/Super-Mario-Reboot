using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
   public Objectpoller coinPooler;

   public void spawnCoins(Vector3 position,float groundWidth){
   int random=Random.Range(1,100);
   if(random<50){
      return ;

  }	
   int numberOfCoins =(int)Random.Range(3f,groundWidth);
   float y=Random.Range(2,4);
   for(int i=0;i<numberOfCoins;i++){
    float x=position.x-(groundWidth/2)+1;
    
    GameObject coin=coinPooler.GetPooledGameObject();
    coin.transform.position = new Vector3(x+i,position.y+y,position.z);
     coin.SetActive(true);	
    }
  }  
}
