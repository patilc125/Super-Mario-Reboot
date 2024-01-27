using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPiker : MonoBehaviour
{
    private AudioSource coinPickSound;
    private float coinPoints=5f;
    private ScoreManger scoreManager;
    void Start()
    {
      coinPickSound= GameObject.Find("CoinPickSound").GetComponent<AudioSource>();;   
      scoreManager=FindObjectOfType<ScoreManger>();	    
}

    void OnTriggerEnter2D(Collider2D other){
       if(other.gameObject.name=="Player"){
             gameObject.SetActive(false);
             if(coinPickSound.isPlaying){
               coinPickSound.Stop();
		}
coinPickSound.Play();
	 scoreManager.score+=coinPoints;
             //
         }
   }
}
